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
    public partial class DesignForm : Form
    {
        private Helper helper;

        // Конструктор класса DesignForm
        public DesignForm(Helper helper)
        {
            InitializeComponent();
            this.helper = helper;
            BackColorComboBox.SelectedIndex = 0;
            ButtonCollorComboBox.SelectedIndex = 0;
            TextOfButtonColorComboBox.SelectedIndex = 0;
            LabelColorComboBox.SelectedIndex = 0;
        }

        // Выбор цветов для дизайна
        public Color GetSelectedColor(ComboBox comboBox)
        {
            int chooseIndex = comboBox.SelectedIndex;
            if (chooseIndex == 0)
                return Color.Gray;
            else if (chooseIndex == 1)
                return Color.Black;
            else if (chooseIndex == 2)
                return Color.White;
            else if (chooseIndex == 3)
                return Color.Red;
            else if (chooseIndex == 4)
                return Color.Coral;
            else if (chooseIndex == 5)
                return Color.Pink;
            else if (chooseIndex == 6)
                return Color.Orange;
            else if (chooseIndex == 7)
                return Color.Yellow;
            else if (chooseIndex == 8)
                return Color.Gold;
            else if (chooseIndex == 9)
                return Color.LimeGreen;
            else if (chooseIndex == 10)
                return Color.LawnGreen;
            else if (chooseIndex == 11)
                return Color.Aquamarine;
            else if (chooseIndex == 12)
                return Color.Blue;
            else if (chooseIndex == 13)
                return Color.DarkBlue;
            else 
                return Color.Purple;
        }

        // Сохранение выбранных пользователем цветов
        public void SaveDesignButton_Click(object sender, EventArgs e)
        {
            Color backColor = GetSelectedColor(BackColorComboBox);
            Color buttonColor = GetSelectedColor(ButtonCollorComboBox);
            Color textOfButtonColor = GetSelectedColor(TextOfButtonColorComboBox);
            Color labelColor = GetSelectedColor(LabelColorComboBox);
            helper.ChangeColor(backColor, buttonColor, textOfButtonColor, labelColor);
            Close();
        }

        //обработчик события визуального компонента ComboBox (выбор цвета)
        private void BackColorComboBox_SelectedIndexChanged(object sender, EventArgs e) => BackgroundColorLabel.ForeColor = GetSelectedColor(BackColorComboBox);

        //обработчик события визуального компонента ComboBox (выбор цвета)
        private void ButtonCollorComboBox_SelectedIndexChanged(object sender, EventArgs e)=> ButtonCollorLabel.ForeColor = GetSelectedColor(ButtonCollorComboBox);

        //обработчик события визуального компонента ComboBox (выбор цвета)
        private void TextOfButtonColorComboBox_SelectedIndexChanged(object sender, EventArgs e) => TextOfButtonColorLabel.ForeColor = GetSelectedColor(TextOfButtonColorComboBox);

        //обработчик события визуального компонента ComboBox (выбор цвета)
        private void LabelColorComboBox_SelectedIndexChanged(object sender, EventArgs e) => LabelColorLabel.ForeColor = GetSelectedColor(LabelColorComboBox);
    }
}
