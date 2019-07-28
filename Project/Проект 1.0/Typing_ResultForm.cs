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
    public partial class Typing_ResultForm : Form
    {
        // Конструктор класса Typing_ResultForm
        public Typing_ResultForm()
        {
            InitializeComponent();                 
        }

        //Метод подсчёта результатов и отображения формы
        public void countResults(int TimeCounter, string Time, int AllElement, int RightElement)
        {
            this.Show();
            int speedNum = (60 * RightElement / TimeCounter);               // Подсчёт скорости печатания
            TimeLabel.Text = Time;                                          // Отображение времени печатания
            Speed.Text = speedNum.ToString();                               // Отображение скорости печатания
            KPD.Text = ((RightElement * 100) / AllElement).ToString();      // Отображение КПД печатания
            if (speedNum >= 300)
                Mark.Text = "Монстр!!!";
            else if (speedNum >= 250)
                Mark.Text = "Машина!!!";
            else if (speedNum >= 200)
                Mark.Text = "Красавчик!!!";
            else if (speedNum >= 150)
                Mark.Text = "Неплохо!!!";
            else if (speedNum >= 100)
                Mark.Text = "Плохо!!!";
            else
                Mark.Text = "Ужасно!!!";
        }

        // Метод, возвращающий пользователя из окна результатов в окно с печатным тренажёром
        private void Сontinue_Click(object sender, EventArgs e)   
        {
            ((Helper)(Application.OpenForms[1])).Enabled = true;
            ((Keyboard)(Application.OpenForms[0])).Enabled = true;
            this.Visible = false;
        }

        // Метод, возвращающий пользователя из окна результатов в окно с тестами
        private void Menu_Click(object sender, EventArgs e)     
        {
            ((Helper)(Application.OpenForms[1])).Enabled = true;
            ((Keyboard)(Application.OpenForms[0])).Enabled = true;
            this.Close();
        }
    }
}
