using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OurProject._0
{ 
    public partial class Helper : Form
    {
        public Helper()                                // Конструктор класса Helper
        {
            InitializeComponent();           
            keyboard.Show();
            keyboard.Visible = false;
            InitializeListOfAnswerCheckBox();
        }

        // Метод для смены цветов в программе
        public void ChangeColor(Color backColor, Color buttonColor, Color textOfButtonColor, Color labelColor)
        {
            for (int i = 0; i < 6; i++) 
            {
                foreach (var control in PageTabControl.GetControl(i).Controls)
                {
                    if (control.GetType() == typeof(Button))                            // Меняем цвет кнопок
                    {
                        ((Button)control).BackColor = buttonColor;
                        ((Button)control).ForeColor = textOfButtonColor;
                    }
                    if (control.GetType() == typeof(Label))                             // Меняем цвет надписей
                        ((Label)control).ForeColor = labelColor;
                    else if (control.GetType() == typeof(CheckBox))                         
                        ((CheckBox)control).ForeColor = labelColor;
                    else if (control.GetType() == typeof(TextBox))
                        ((TextBox)control).ForeColor = labelColor;
                    else if (control.GetType() == typeof(NumericUpDown))
                        ((NumericUpDown)control).ForeColor = labelColor;
                }
                PageTabControl.GetControl(i).BackColor = backColor;                     // Меняем цвет фона
            }
        }

        // Открытие формы, в которой настраивается дизайн интерфейса
        public void OpenDesignFormButton_Click(object sender, EventArgs e)
        {
            var designForm = new DesignForm(this);
            designForm.Show();
        }
        
         
        // Методы, исполняемые при нажатии на кнопки в главном меню, которые переносят пользователя на разные вкладки
        private void TypingButton_Click(object sender, EventArgs e) => PageTabControl.SelectedIndex = 1;

        private void TestButton_Click(object sender, EventArgs e) => PageTabControl.SelectedIndex = 2;

        private void MathLogicButton_Click(object sender, EventArgs e) => PageTabControl.SelectedIndex = 3;

        private void MGIAButton_Click(object sender, EventArgs e) => PageTabControl.SelectedIndex = 4;

        private void PolygonButton_Click(object sender, EventArgs e) => PageTabControl.SelectedIndex = 5;

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PageTabControl.SelectedIndex != 1)
            {
                keyboard.Visible = false;
                armLeft.Visible = false;
                armRight.Visible = false;
            }
        }
    }
}