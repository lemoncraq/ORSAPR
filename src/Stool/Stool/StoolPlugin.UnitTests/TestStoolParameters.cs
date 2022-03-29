using System;
using NUnit.Framework;
using StoolPlugin.Model.Parameters;
using Assert = NUnit.Framework.Assert;

namespace StoolPlugin.UnitTests
{
    /// <summary>
    /// Класс для тестирования класса <see cref="StoolParameters"/>
    /// </summary>
    class TestStoolParameters
    {
        /// <summary>
        /// Возвращает новый экземпляр класс <see cref="StoolParameters"/>
        /// </summary>
        private StoolParameters _stoolParameters  = new StoolParameters();

        [TestCase(ParameterType.StoolTopLength, 350,
            Description = "Проверка корректного значения" +
                          " получения свойства StoolTopLength")]
        [TestCase(ParameterType.StoolTopWidth, 350,
            Description = "Проверка корректного значения " +
                          " получения свойства StoolTopWidth")]
        [TestCase(ParameterType.StoolTopThickness, 30,
            Description = "Проверка корректного значения  " +
                          " получения свойства StoolTopThickness")]
        [TestCase(ParameterType.StoolLegsHeight, 350,
            Description = "Проверка корректного значения  " +
                          " получения свойства StoolLegsHeight")]
        [TestCase(ParameterType.StoolLegsBase, 30,
            Description = "Проверка корректного значения " +
                          " получения свойства StoolLegsBase")]
        public void Test_GetValue_CorrectGetValue(
            ParameterType parameterType,
            int value)
        {
            var stoolParameters = _stoolParameters;

            var expected = value;

            stoolParameters.SetValue(parameterType, value);

            var actual = stoolParameters.GetValue(parameterType);

            Assert.AreEqual(expected, actual, 
                "Вернулось некорректное значение");
        }

        [TestCase(ParameterType.StoolTopLength,
            "Длина сиденья",
            Description = "Проверка корректного получения " +
                          "названия свойства StoolTopLength")]
        [TestCase(ParameterType.StoolTopWidth,
            "Ширина сиденья",
            Description = "Проверка корректного  получения " +
                          "названия свойства StoolTopWidth")]
        [TestCase(ParameterType.StoolTopThickness,
            "Толщина сиденья",
            Description = "Проверка корректного получения " +
                          "названия свойства StoolTopThickness")]
        [TestCase(ParameterType.StoolLegsBase,
            "Основание ножек табурета",
            Description = "Проверка корректного получения " +
                          "названия свойства StoolLegsBase")]
        [TestCase(ParameterType.StoolLegsHeight,
            "Высота ножек табурета",
            Description = "Проверка корректного получения " +
                          "названия свойства StoolLegsHeight")]
        public void Test_GetValue_CorrectGetName(
            ParameterType parameterType,
            string name)
        {
            var stoolParameters = _stoolParameters;

            var expected = name;

            var actual = stoolParameters.GetName(parameterType);
            Assert.AreEqual(expected, actual,
                "Вернулось некорректное название параметра");
        }

        [TestCase(ParameterType.StoolTopLength, 350,
            Description = "Проверка корректной записи значения" +
                          " свойства StoolTopLength")]
        [TestCase(ParameterType.StoolTopWidth, 350,
            Description = "Проверка корректной записи значения" +
                          " свойства StoolTopWidth")]
        [TestCase(ParameterType.StoolTopThickness, 30,
            Description = "Проверка корректной записи значения" +
                          " свойства StoolTopThickness")]
        [TestCase(ParameterType.StoolLegsHeight, 350,
            Description = "Проверка корректной записи значения " +
                          " свойства StoolLegsHeight")]
        [TestCase(ParameterType.StoolLegsBase, 30,
            Description = "Проверка корректной записи значения " +
                          " свойства StoolLegsHeight")]
        public void Test_SetValue_CorrectSetValue(
            ParameterType parameterType,
            int value)
        {
            var stoolParameters = _stoolParameters;

            Assert.DoesNotThrow(
                () => stoolParameters.SetValue(parameterType, value),
                "Не удалось присвоить корректное значение");
        }

        [TestCase(ParameterType.StoolTopLength, 200,
            Description = "Проверка некорректной записи значения" +
                          " свойства StoolTopLength" +
                          " меньше минимального")]
        [TestCase(ParameterType.StoolTopWidth, 200,
            Description = "Проверка некорректной записи значения" +
                          " свойства StoolTopWidth" +
                          " меньше минимального")]
        [TestCase(ParameterType.StoolTopThickness, 10,
            Description = "Проверка некорректной записи значения" +
                          "свойства StoolTopThickness" +
                          " меньше минимального")]
        [TestCase(ParameterType.StoolLegsHeight, 200,
            Description = "Проверка некорректной записи значения" +
                          " свойства StoolLegsHeight" +
                          " меньше минимального ")]
        [TestCase(ParameterType.StoolLegsBase, 20,
            Description = "Проверка некорректной записи значения" +
                          " свойства StoolLegsHeight" +
                          " меньше минимального ")]
        [TestCase(ParameterType.StoolTopLength, 1000,
            Description = "Проверка некорректной записи значения " +
                          " свойства StoolTopLength" +
                          " больше максимального")]
        [TestCase(ParameterType.StoolTopWidth, 1000,
            Description = "Проверка некорректной записи значения " +
                          " свойства StoolTopWidth" +
                          " больше максимального")]
        [TestCase(ParameterType.StoolTopThickness, 1000,
            Description = "Проверка некорректной записи значения  " +
                          " свойства StoolTopThickness" +
                          " мбольше максимального")]
        [TestCase(ParameterType.StoolLegsHeight, 1000,
            Description = "Проверка некорректной записи значения  " +
                          " свойства StoolLegsHeight" +
                          " больше максимального")]
        [TestCase(ParameterType.StoolLegsBase, 1000,
            Description = "Проверка некорректной записи значения " +
                          " свойства StoolLegsHeight" +
                          " больше максимального")]
        public void Test_SetValue_IncorrectSetValue(
            ParameterType parameterType,
            int value)
        {
            var stoolParameters = _stoolParameters;

            Assert.Throws<ArgumentException>(
                () => stoolParameters.SetValue(parameterType, value),
                $"Было присвоено значение не входящие в диапазон");
        }
    }
}
