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
    public partial class Keyboard : Form
    {
        //конструктор
        public Keyboard()
        {
            InitializeComponent();
            InitializeKeyboardLabel();
            TransparentBackColor();
            this.ShowInTaskbar = false;
        }
        
        //поля
        public string errorLetterCopy=null;
        public string necessaryLetterCopy = null;
        private string englishAlphabet = "`~1!2@3#4$5%6^7" + (char)39 + "8*9(0)-_=+QWERTYUIOP[{]}ASDFGHJKL;:'" + (char)34 + (char)92 + "|ZXCVBNM,<.>/?";
        private string englishAlphabetSmall = "` 1 2 3 4 5 6 7 8 9 0 - = qwertyuiop[ ] asdfghjkl; ' " + (char)92 + "|zxcvbnm, . / ";
        private string russianAlphabet = "ёЁ1!2" + (char)34 + "3№4;5%6:7?8*9(0)-_=+ЙЦУКЕНГШЩЗ Х ЪФЫВАПРОЛД Ж Э " + (char)92 + "ЯЧСМИТЬ Б Ю .,";
        private string russianAlphabetSmall = "ё 1 2 3 4 5 6 7 8 9 0 - = йцукенгшщз х ъфывапролд ж э " + (char)92 + "ячсмить б ю . ";
        private string correctAlphabet;
        private string correctAlphabetSmall;
        private List<Label> keyboard = new List<Label>();

        //метод создания списка "keyboard"
        private void InitializeKeyboardLabel()
        {
            foreach (var control in this.Controls)
            {
                if (control.GetType() == typeof(Label) && ((Label)control).Name.StartsWith("label"))
                {
                    keyboard.Add((Label)control);
                }
            }
            Comparison<Label> labelComparison = delegate (Label l1, Label l2)
            {
                return int.Parse(l1.Name.Substring(5)) - int.Parse(l2.Name.Substring(5));
            };

            keyboard.Sort(labelComparison);
        }
        
        //метод для пприсваивания свойству BackColor всех экземпляров класса Label значение Color.Transparent
        private void TransparentBackColor()
        {
            for (int i = 0; i < keyboard.Count; i++)
            {
                keyboard[i].BackColor = Color.Transparent;
            }
            ShiftLeftText.BackColor = Color.Transparent;
            ShiftRightText.BackColor = Color.Transparent;
            CtrlLeft.BackColor = Color.Transparent;
            CtrlRight.BackColor = Color.Transparent;
            AltLeft.BackColor = Color.Transparent;
            AltRigt.BackColor = Color.Transparent;
            Tab.BackColor = Color.Transparent;
            CapsLock.BackColor = Color.Transparent;
            PrtSc.BackColor = Color.Transparent;
            Enter.BackColor = Color.Transparent;
            Backspace.BackColor = Color.Transparent;          
        }

        //метод для присваивания свойству ForeColor некоторых экземпляров класса Label значение Color.White
        private void ChangeForeColor()
        {

            for (int i = 0; i < keyboard.Count; i++)
            {
                keyboard[i].ForeColor = Color.White;
            }
            space.Visible = false;
            spaceEr.Visible = false;
            ShiftLeft.Visible = false;
            ShiftRight.Visible = false;
        }

        //метод для инициализации букв на клавишах клавиатуры соответствующих английской раскладке
        private void EnglishAlphabetFunc()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
            correctAlphabet = englishAlphabet;
            correctAlphabetSmall = englishAlphabetSmall;
            for (int i = 0; i < keyboard.Count; i++)
            {
                keyboard[i].Text = englishAlphabet.Substring(i, 1);
            }

            label2.Visible = true;
            label48.Visible = true;
            label50.Visible = true;
            label70.Visible = true;
            label72.Visible = true;
            label90.Visible = true;
            label92.Visible = true;           
        }

        //метод для инициализации букв на клавишах клавиатуры соответствующих русской раскладке
        private void RussianAlphabetFunc()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
            correctAlphabet = russianAlphabet;
            correctAlphabetSmall = russianAlphabetSmall;
            for (int i = 0; i < keyboard.Count; i++)
            {
                keyboard[i].Text = russianAlphabet.Substring(i, 1);
            }
            label2.Visible = false;
            label48.Visible = false;
            label50.Visible = false;
            label70.Visible = false;
            label72.Visible = false;
            label90.Visible = false;
            label92.Visible = false;
          }

        //метод, который помечает неправильно введенную букву красным цветом
        public void LetterError(string ErrorLetter, bool isRussianAlphabet)
        {
            ChangeLetterСolor(ErrorLetter, ref errorLetterCopy, isRussianAlphabet, Color.Red, null, null, false);
        }
               
        //метод, который помечает букву, которую необходимо нажать зеленым цветом
        public void InputLetter(string NecessaryLetter, bool isRussianAlphabet, ArmLeft armLeft, ArmRight armRight)
        {
            ChangeLetterСolor(NecessaryLetter, ref necessaryLetterCopy, isRussianAlphabet, Color.Lime, armLeft, armRight, true);
            
        }

        //метод, который помечает букву и вызывает "руки" в соответствии с параметрами
        private void ChangeLetterСolor(string letter, ref string letterCopy, bool isRussianAlphabet, Color color, ArmLeft armLeft, ArmRight armRight, bool itIsNecessary)
        {
            //ChangeForeColor();
            if (letterCopy == null)
            {
                letterCopy = letter;
            }
            else if (letterCopy != letter)
            {
                ChangeForeColor();
                letterCopy = letter;
            }
            if (isRussianAlphabet)
                RussianAlphabetFunc();
            else
                EnglishAlphabetFunc();
            if (letter == " ")
            {
                if (itIsNecessary)
                {
                    armLeft.ShowArm(41, false);
                    armRight.ShowArm(47, false);
                }
                space.Visible = true;
                return;
            }
            for (int i = 0; i < keyboard.Count; i++)
            {
                if (letter == correctAlphabetSmall.Substring(i, 1))
                {
                    if (itIsNecessary)
                    {
                        armLeft.ShowArm(i, false);
                        armRight.ShowArm(i, false);
                    }
                    keyboard[i].ForeColor = color;
                    break;
                }
                if (letter == correctAlphabet.Substring(i, 1))
                {
                    if (itIsNecessary)
                    {
                        armLeft.ShowArm(i, true);
                        armRight.ShowArm(i, true);
                    }
                    keyboard[i].ForeColor = color;
                    ShiftLeft.Visible = true;
                    ShiftRight.Visible = true;
                    break;
                }
            }
        }
    }
}