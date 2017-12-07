using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper._0
{
    public partial class ResultFormTest : Form
    {
        public ResultFormTest(int NumberAnswer, int NumberRigtAnswer)
        {            
            InitializeComponent();

            AllAnswer.Text = (NumberAnswer).ToString();
            RightAnswer.Text = (NumberRigtAnswer).ToString();
            ResultMark.Text=(10* NumberRigtAnswer/ NumberAnswer).ToString();
        }
        private void ResultFormTest_Load(object sender, EventArgs e)
        {

        }

        private void Continue_Click(object sender, EventArgs e)
        {
            ((Helper)(Application.OpenForms[1])).Enabled = true;
            this.Close();
        }
    }
}
