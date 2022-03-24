using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StoolPlugin.Model.Parameters
{
    /// <summary>
    /// Класс параметров табурета
    /// </summary>
    public class StoolParameters
    {

        /// <summary>
        /// Коэффициент зависимых значений.
        /// Используется только расчётов.
        /// </summary>
        private const double СoefficientDependentParameter = 3.0;

        /// <summary>
        /// Минимальная длина сиденья
        /// </summary>
        private const int MinStoolTopLength = 300;

        /// <summary>
        /// Минимальная ширина сиденья
        /// </summary>
        private const int MinStoolTopWidth = 300;

        /// <summary>
        /// Минимальная толщина сиденья
        /// </summary>
        private const int MinStoolTopThickness = 20;

        /// <summary>
        /// Максимальное значение ножек табурета
        /// </summary>
        private const int MaxStoolLegsBase = 35;

        /// <summary>
        /// Минимальная высота ножек табурета
        /// </summary>
        private const int MinStoolLegsHeight = 300;

        /// <summary>
        /// Минимальная общая (толщина сиденья + высота ножек) высота табурета
        /// </summary>
        private const int MinTotalHeightStool = 330;

        /// <summary>
        /// Словарь параметров класса <see cref="StoolParameters"/>
        /// </summary>
        private readonly Dictionary<ParameterType, Parameter> _parameters =
            new Dictionary<ParameterType, Parameter>
            {
                { ParameterType.StoolTopLength,
                    new Parameter(MinStoolTopLength,400,350, "Длина сиденья")},
                { ParameterType.StoolTopWidth,
                    new Parameter(MinStoolTopWidth,600,350, "Ширина сиденья")},
                { ParameterType.StoolTopThickness,
                    new Parameter(MinStoolTopThickness,35,30, "Толщина сиденья")},
                { ParameterType.StoolLegsBase,
                    new Parameter(25,MaxStoolLegsBase,30,"Основание ножек табурета")},
                { ParameterType.StoolLegsHeight,
                    new Parameter(MinStoolLegsHeight,400,350, "Высота ножек табурета")},
            };

        /// <summary>
        /// Конструктор класса <see cref="StoolParameters"/> без параметров
        /// </summary>
        public StoolParameters()
        { }

        /// <summary>
        /// Установить значение параметра
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <param name="value">Значение параметра</param>
        public void SetValue(ParameterType parameterType, int value)
        {
            var minValue = _parameters[parameterType].Minimum;
            var maxValue = _parameters[parameterType].Maximum;

            switch(parameterType)
            {
                case ParameterType.StoolTopLength:
                {
                    minValue =
                        SetValueDependentParameters(ParameterType.StoolTopLength, 
                            MinStoolTopLength);
                        break;
                }
                case ParameterType.StoolTopWidth:
                {
                    minValue = 
                        SetValueDependentParameters(ParameterType.StoolTopWidth, 
                            MinStoolTopWidth);
                        break;
                }
                case ParameterType.StoolTopThickness:
                {
                        minValue =
                            SetValueTotalHeightTable(ParameterType.
                                StoolTopThickness,
                                MinStoolTopThickness, 
                                ParameterType.
                                    StoolLegsHeight);
                        break;
                }
                case ParameterType.StoolLegsHeight:
                {
                        minValue =
                            SetValueTotalHeightTable(ParameterType.
                                StoolLegsHeight,
                                MinStoolLegsHeight,
                                ParameterType.
                                StoolTopThickness);
                        break;
                }
                case ParameterType.StoolLegsBase:
                {
                    maxValue = SetValueTableLegsBase(ParameterType.
                        StoolLegsBase,
                        MaxStoolLegsBase);
                        break;
                }
            }

            _parameters[parameterType].Minimum = minValue;
            _parameters[parameterType].Maximum = maxValue;
            _parameters[parameterType].Value = value;
        }

        /// <summary>
        /// Установка значения для зависимого параметра
        /// "Высота сиденья" или "Высота ножек табурета".
        ///  Значение "Высота сиденья" + "Высота ножек табурета"
        /// должно быть больше 400
        /// </summary>
        /// <param name="parameterType">Тип паарметра</param>
        /// <param name="minAllowedValue">Минимальное допустимое значение</param>
        /// <param name="depedentParameterType">Тип зависимого параметра</param>
        /// <returns></returns>
        private int SetValueTotalHeightTable(ParameterType parameterType,
            int minAllowedValue, ParameterType depedentParameterType)
        {
            if (parameterType != ParameterType.StoolTopThickness
                && parameterType != ParameterType.StoolLegsHeight)
            {
                string textError = "Передан неправильный ParameterType " +
                                   "в метод SetValueTableLegsBase";
                throw new ArgumentException(textError);
            }

            int minValue = (double.IsNaN(_parameters[parameterType].Value) ?
                minAllowedValue :
                (MinTotalHeightStool - 
                 _parameters[depedentParameterType].Value));

            if (minValue < minAllowedValue)
            {
                minValue = minAllowedValue;
            }
            return minValue;
            
        }

        /// <summary>
        /// Установка значений для параметра "Основание ножек табурета"
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <param name="maxAllowedValue">
        /// Максимальное допустимое значение</param>
        /// <returns></returns>
        private int SetValueTableLegsBase(ParameterType parameterType,
            int maxAllowedValue)
        {
            if (parameterType != ParameterType.StoolLegsBase)
            {
                string textError = "Передан неправильный ParameterType " +
                                   "в метод SetValueTableLegsBase";
                throw new ArgumentException(textError);
            }
            var minimumValue = Math.
                Min(_parameters[ParameterType.StoolTopWidth].Value,
                    _parameters[ParameterType.StoolTopLength].Value);
            var tempValue = (int)Math.
                Round(minimumValue / СoefficientDependentParameter,
                    0, MidpointRounding.AwayFromZero);
            var maxValue = (double.IsNaN(_parameters[ParameterType.
                StoolLegsBase].Value)
                ? MaxStoolLegsBase
                : tempValue);
            if (maxValue > maxAllowedValue)
            {
                maxValue = maxAllowedValue;
            }
            return maxValue;
        }

        /// <summary>
        /// Установка значений для параметра
        /// "Длина сиденья", "Ширина сиденья".
        ///  "Длина сиденья", "Ширина сиденья" зависят от
        ///  параметра "Значение основание табурета" 
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <param name="minAllowedValue">Минимальное допустимое значение</param>
        /// <returns>Значения минимума</returns>
        private int SetValueDependentParameters(ParameterType parameterType, 
            int minAllowedValue)
        {
            if (parameterType != ParameterType.StoolTopLength
                && parameterType != ParameterType.StoolTopWidth)
            {
                string textError = "Передан неправильный ParameterType " +
                                   "в метод SetValueDependentParameters";
                throw new ArgumentException(textError);
            }

            var tempMinValue = (int)Math.
                Round(_parameters[ParameterType.StoolLegsBase].
                        Value * СoefficientDependentParameter,
                    0, MidpointRounding.AwayFromZero);
            var minValue = (double.IsNaN(_parameters[parameterType].Value)
                ? minAllowedValue
                : tempMinValue);

            if (minValue < minAllowedValue)
            {
                minValue = minAllowedValue;
            }
            return minValue;
        }

        /// <summary>
        /// Получить значение параметра
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <returns>Значение параметра</returns>
        public int GetValue(ParameterType parameterType)
        {
            return _parameters[parameterType].Value;
        }

        /// <summary>
        /// Получить название параметра
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <returns>Имя параметра</returns>
        public string GetName(ParameterType parameterType)
        {
            return _parameters[parameterType].Name;
        }
    }
}