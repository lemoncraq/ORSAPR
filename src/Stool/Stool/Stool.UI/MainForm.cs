using System;
using System.Drawing;
using System.Windows.Forms;
using StoolParameters;

namespace Stool.UI
{
    /// <summary>
    /// Главная форма для ввода параметров
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Создание переменной типа Parameters
        /// Хранит вводимые в форме параметры
        /// </summary>
        private Parameters _stoolParameters;

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

        public MainForm()
        {
            InitializeComponent();
            _stoolParameters = new Parameters();
        }

        /// <summary>
        /// Проверка на соответствие вводимых данных типу int
        /// </summary>
        /// <param name="textBox">ссылка на соответствующий TextBox</param>
        /// <returns></returns>
        private int CheckValueType(TextBox textBox)
        {
            try
            {
                var value = Convert.ToInt32(textBox.Text);
                toolTip.SetToolTip(textBox, "");
                buttonBuild.Enabled = true;
                return value;
            }
            catch (Exception)
            {
                toolTip.SetToolTip(textBox, "Недопустимые символы");
                textBox.BackColor = Color.DarkSalmon;
                buttonBuild.Enabled = false;
                return 0;
            }
        }

        /// <summary>
        /// Толщина ножек табурета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _legThickness = CheckValueType(textBox1);
            if (_legThickness == 0) return;

            try
            {
                _stoolParameters.LegThickness = _legThickness;
                textBox1.BackColor = Color.White;
                toolTip.SetToolTip(textBox1, "");
                buttonBuild.Enabled = true;
            }
            catch (Exception exception)
            {
                textBox1.BackColor = Color.DarkSalmon;
                toolTip.SetToolTip(textBox1, exception.Message);
                buttonBuild.Enabled = false;
            }
        }

        /// <summary>
        /// Длина ножек табурета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _legHeight = CheckValueType(textBox2);
            if (_legHeight == 0) return;

            try
            {
                _stoolParameters.LegHeight = _legHeight;
                textBox2.BackColor = Color.White;
                toolTip.SetToolTip(textBox2, "");
                buttonBuild.Enabled = true;
            }
            catch (Exception exception)
            {
                textBox2.BackColor = Color.DarkSalmon;
                toolTip.SetToolTip(textBox2, exception.Message);
                buttonBuild.Enabled = false;
            }
        }

        /// <summary>
        /// Длина попепречин
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _lengthOfCrossbeams = CheckValueType(textBox3);
            if (_lengthOfCrossbeams == 0) return;

            try
            {
                _stoolParameters.LengthOfCrossbeams = _lengthOfCrossbeams;
                textBox3.BackColor = Color.White;
                toolTip.SetToolTip(textBox3, "");
                buttonBuild.Enabled = true;
            }
            catch (Exception exception)
            {
                textBox3.BackColor = Color.DarkSalmon;
                toolTip.SetToolTip(textBox3, exception.Message);
                buttonBuild.Enabled = false;
            }
        }

        /// <summary>
        /// Толщина поперечин
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            _crossbeamThickness = CheckValueType(textBox4);
            if (_crossbeamThickness == 0) return;

            try
            {
                _stoolParameters.CrossbeamThickness = _crossbeamThickness;
                textBox4.BackColor = Color.White;
                toolTip.SetToolTip(textBox1, "");
                buttonBuild.Enabled = true;
            }
            catch (Exception exception)
            {
                textBox4.BackColor = Color.DarkSalmon;
                toolTip.SetToolTip(textBox4, exception.Message);
                buttonBuild.Enabled = false;
            }
        }

        /// <summary>
        /// Длина сиденья
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            _seatLength = CheckValueType(textBox5);
            if (_seatLength == 0) return;

            try
            {
                _stoolParameters.SeatLength = _seatLength;
                textBox5.BackColor = Color.White;
                toolTip.SetToolTip(textBox1, "");
                buttonBuild.Enabled = true;
            }
            catch (Exception exception)
            {
                textBox5.BackColor = Color.DarkSalmon;
                toolTip.SetToolTip(textBox5, exception.Message);
                buttonBuild.Enabled = false;
            }
        }

        /// <summary>
        /// Построение 3D-модели табурета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            try
            {
                _stoolParameters = new Parameters(_legThickness, _legHeight, _lengthOfCrossbeams, _crossbeamThickness, _seatLength);
                buttonBuild.Enabled = true;
            }
            catch
            {
                buttonBuild.Enabled = false;
            }
        }
    }
}
