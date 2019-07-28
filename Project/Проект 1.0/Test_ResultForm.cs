using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurProject._0
{
    public partial class Test_ResultForm : Form
    {
        public Test_ResultForm(int NumberAnswer, int NumberRigtAnswer)              // Конструктор класса Test_ResultForm
        {            
            InitializeComponent();
                        
            AllAnswer.Text = (NumberAnswer).ToString();                             // Отображает на сколько вопросов ответил пользователь
            RightAnswer.Text = (NumberRigtAnswer).ToString();                       // Отображает на сколько вопросов пользователь ответил правильно
            ResultMark.Text = (10 * NumberRigtAnswer / NumberAnswer).ToString();    // Отображает на сколько вопросов пользователь ответил правильно
            if ((10 * NumberRigtAnswer / NumberAnswer) < 4)
                LevelOfTestLabel.Text = "Ужасно";
            else if ((10 * NumberRigtAnswer / NumberAnswer) < 6)
                LevelOfTestLabel.Text = "Плохо";
            else if ((10 * NumberRigtAnswer / NumberAnswer) < 9)
                LevelOfTestLabel.Text = "Хорошо";
            else
                LevelOfTestLabel.Text = "Отлично";
        }

        // Метод, возвращающий пользователя из окна результатов в окно с тестами
        private void Continue_Click(object sender, EventArgs e)
        {
            ((Helper)(Application.OpenForms[1])).Enabled = true;
            this.Close();
        }

        // Метод, возвращающий пользователя из окна результатов в главное меню
        private void Menu_Click(object sender, EventArgs e)
        {
            ((Helper)(Application.OpenForms[1])).Enabled = true;
            this.Close();
        }
    }
}
