using System;

namespace StoolParameters
{
    /// <summary>
    /// Класс логики, хранящий значения параметров табурета
    /// </summary>
    public class Parameters
    {
        /// <summary>
        /// Толщина ножек
        /// </summary>
        private int _legThickness;

        /// <summary>
        /// Высота ножек
        /// </summary>
        private int _legHeight;

        /// <summary>
        /// Длинна поперечин
        /// </summary>
        private int _lengthOfCrossbeams;

        /// <summary>
        /// Толщина поперечин
        /// </summary>
        private int _crossbeamThickness;

        /// <summary>
        /// Длина сиденья
        /// </summary>
        private int _seatLength;

        /// <summary>
        /// Толщина сиденья
        /// </summary>
        private int _seatThickness;

        /// <summary>
        /// Валидация значений параметров
        /// </summary>
        /// <param name="value">значение, которое должно быть присвоено</param>
        /// <param name="min">минимальное значение параметра</param>
        /// <param name="max">максимальное значение параметра</param>
        private static int ValidationValue(int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Значение вне диапазона");
            }

            return value;
        }

        /// <summary>
        /// Возвращает или задает значение толщины ножек
        /// </summary>
        public int LegThickness
        {
            get => _legThickness;
            set => _legThickness = ValidationValue(value, 40, 50);
        }

        /// <summary>
        /// Возвращает или задает значение длины ножек
        /// </summary>
        public int LegHeight
        {
            get => _legHeight;
            set => _legHeight = ValidationValue(value, 450, 470);
        }

        /// <summary>
        /// Возвращает или задает значение длины поперечин
        /// </summary>
        public int LengthOfCrossbeams
        {
            get => _lengthOfCrossbeams;
            set => _lengthOfCrossbeams = ValidationValue(value, 210, 230);
        }

        /// <summary>
        /// Возвращает или задает значение толщины поперечин
        /// </summary>
        public int CrossbeamThickness
        {
            get => _crossbeamThickness;
            set => _crossbeamThickness = ValidationValue(value, 20, 40);
        }
        /// <summary>
        /// Возвращает или задает значение длины сиденья
        /// </summary>
        public int SeatLength
        {
            get => _seatLength;
            set => _seatLength = ValidationValue(value, 320, 340);
        }

        /// <summary>
        /// Возвращает или задает значение толщины сиденья
        /// </summary>
        public int SeatThickness
        {
            get => _seatThickness;
            set => _seatThickness = value + 20;
        }

        /// <summary>
        /// Пустой конструктор класса Parameters
        /// </summary>
        public Parameters()
        {

        }

        /// <summary>
        /// Конструктор класса Parameters
        /// </summary>
        /// <param name="legThickness">Толщина ножек</param>
        /// <param name="legHeight">Длина ножек</param>
        /// <param name="lengthOfCrossbeams">Длина поперечин</param>
        /// <param name="crossbeamThickness">Толщина поперечин</param>
        /// <param name="seatLength">Длина сиденья</param>
        public Parameters(int legThickness, int legHeight, int lengthOfCrossbeams, int crossbeamThickness,
            int seatLength)
        {
            LegThickness = legThickness;
            LegHeight = legHeight;
            LengthOfCrossbeams = lengthOfCrossbeams;
            CrossbeamThickness = crossbeamThickness;
            SeatThickness = 0;
        }
    }
}
