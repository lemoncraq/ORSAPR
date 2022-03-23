using System;
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
    /// Класс для работы с формой плагина
    /// </summary>
    public partial class StoolForm : Form
    {
        private StoolBuilder _stoolBuilder;

        private StoolParameters _stoolParameters;

        public StoolForm()
        {
            InitializeComponent();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {

        }
    }
}
