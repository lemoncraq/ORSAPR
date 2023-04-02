﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoolPlugin.Model.Parameters;
using StoolPlugin.Model.Kompas;

namespace StoolPlugin.UI
{
    /// <summary>
    /// Класс для работы с формой (главным окном) плагина
    /// </summary>
    public partial class StoolPluginForm : Form
    {
        /// <summary>
        /// Класс для построения табурета
        /// </summary>
        private StoolBuilder _stoolBuilder;

        /// <summary>
        /// Параметры табурета
        /// </summary>
        private StoolParameters _stoolParameters;

        /// <summary>
        /// Тип ножек табурета
        /// По умолчанию заданы квадратные ножки табурета.
        /// </summary>
        private LegsType _legsType = LegsType.SquareLegs;

        /// <summary>
        /// Словарь ошибок
        /// </summary>
        private Dictionary<ParameterType, string> _errors 
            = new Dictionary<ParameterType, string>();

        /// <summary>
        /// Конструктор класса <see cref="StoolPluginForm"/>
        /// </summary>
        public StoolPluginForm()
        {
            InitializeComponent();
              _stoolParameters = new StoolParameters();
              LegsTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
              LegsTypeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Возращает строку всех ошибок
        /// </summary>
        /// <returns></returns>
        private string GetAllErrors()
        {
            var errorMessage = string.Empty;
            for (var i = 0; i < _errors.Keys.Count; i++)
            {
                var key = _errors.Keys.ToArray()[i];
                errorMessage += _errors[key] + Environment.NewLine;
            }
            return errorMessage;
        }

        /// <summary>
        /// Обработчик кнопки "Построить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            if(_errors.Any())
            {
                var message = GetAllErrors();
                MessageBox.Show(message, "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _stoolBuilder = _stoolBuilder ?? new StoolBuilder();
               _stoolBuilder.Build(_stoolParameters, _legsType);
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  Установить значение параметру табурета
        /// </summary>
        /// <param name="numericUpDown">Значение будет браться из поля
        /// <see cref="NumericUpDown"/></param>
        /// <param name="parameterType">Тип параметра для записи</param>
        private void SetValueParameter(NumericUpDown numericUpDown,
            ParameterType parameterType)
        {
            try
            {
                var value = (int)numericUpDown.Value;
                if (numericUpDown.Text == String.Empty)
                {
                    var nameParameter = _stoolParameters.
                        GetName(parameterType);
                    throw new ArgumentException($"{nameParameter}: " +
                                                $"введена пустая строка.");
                }
                _stoolParameters.SetValue(parameterType, value);
                if (_errors.ContainsKey(parameterType))
                {
                    _errors.Remove(parameterType);
                }
            }
            catch (ArgumentException exception)
            {
                numericUpDown.BackColor = Color.Red;
                if (!_errors.ContainsKey(parameterType))
                {
                    _errors.Add(parameterType, exception.Message);
                }
                else
                {
                    _errors[parameterType] = exception.Message;
                }
                return;
            }
            numericUpDown.BackColor = Color.White;
        }

        /// <summary>
        /// Поиск  <see cref="ParameterType"/> по названию
        /// поля <see cref="NumericUpDown"/>
        /// </summary>
        /// <param name="numericUpDownName">
        /// Название <see cref="NumericUpDown"/></param>
        /// <returns>Возврат значения перечисления
        /// из <see cref="ParameterType"/> </returns>
        private ParameterType FindParameters(string numericUpDownName)
        {
            var parameters = Enum.GetValues(typeof(ParameterType))
                .Cast<ParameterType>()
                .ToList();
            foreach (var parameter in parameters)
            {
                if (numericUpDownName.Contains(parameter.ToString()))
                {
                    return parameter;
                }
            }
            throw new ArgumentException(
                "Не найдено значение в перечисление ParameterType");
        }

        /// <summary>
        /// Событие проверки данных из
        /// поля <see cref="NumericUpDown"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnyValueNumericUpDown_Validating(object sender,
            CancelEventArgs e)
        {
            if (!(sender is NumericUpDown numericUpDown))
            {
                return;
            }
            SetValueParameter(numericUpDown,
                FindParameters(numericUpDown.Name));
        }

        /// <summary>
        /// Обработчик события при изменении значения
        /// поля <see cref="NumericUpDown"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnyValueNumericUpDown_ValueChanged(object sender, 
            EventArgs e)
        {
            if (!(sender is NumericUpDown numericUpDown))
            {
                return;
            }
            SetValueParameter(numericUpDown,
                FindParameters(numericUpDown.Name));
        }

        private void LegsTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LegsTypeComboBox.SelectedIndex)
            {
                case 0:
                {
                    _legsType = LegsType.SquareLegs;
                    break;
                }
                case 1:
                {
                    _legsType = LegsType.RoundLegs;
                    break;
                }
                case 2:
                {
                    _legsType = LegsType.TriangularLegs;
                    break;
                }
            }
        }
    }
}
