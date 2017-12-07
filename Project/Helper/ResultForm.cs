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
    public partial class ResultForm : Form
    {
        //  public ResultForm() => InitializeComponent();
        int SpeedNum;

        public ResultForm(int TimeCounter, string Time, int AllElement, int RightElement)
        {            
            InitializeComponent();

            SpeedNum = (60 * RightElement / TimeCounter);
            TimeLabel.Text = Time;          
            Speed.Text = SpeedNum.ToString();
            KPD.Text = ((RightElement * 200) / AllElement).ToString();
            if (SpeedNum >= 300)       //?????????????????????????
                Mark.Text = "Ты Бог!!!";
            if (SpeedNum >= 250 && SpeedNum < 300)
                Mark.Text = "Ты монстр!!!";
            if (SpeedNum >= 200 && SpeedNum < 250)
                Mark.Text = "Красавчик!!!";
            if (SpeedNum >= 150 && SpeedNum < 200)
                Mark.Text = "Не плохо!!!";
            if (SpeedNum >= 100 && SpeedNum < 150)
                Mark.Text = "Так себе!!!";
            if (SpeedNum < 100)
                Mark.Text = "Ужасно!!!";            
        }
        private void Сontinue_Click(object sender, EventArgs e)
        {
            ((Helper)(Application.OpenForms[1])).Enabled = true;
            ((Keyboard)(Application.OpenForms[0])).Enabled = true;
            this.Close();
        }
        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
