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
    public partial class Keyboard : Form
    {
        public Keyboard()
        {
            InitializeComponent();
            backColor();
        }
        private void Keyboard_Load(object sender, EventArgs e)
        {

        }
        
        string ErrorLetterCopy;
        string NecessaryLetterCopy=null;
        string EnglishAlphabet = " 0`~1!2@3#4$5%6^7&8*9(0)-_=+qQwWeErRtTyYuUiIoOpP[{]}aAsSdDfFgGhHjJkKlL;:'$$|zZxXcCvVbBnNmM,<.>/?000";        
        string RussianAlphabet = " 0ёЁ1!2$3№4;5%6:7?8*9(0)-_=+йЙцЦуУкКеЕнНгГшШщЩзЗхХъЪфФыЫвВаАпПрРоОлЛдДжЖэЭ$/яЯчЧсСмМиИтТьЬбБюЮ.,000";
        string Alphabet;
        char symbol1=(char) 34;
        char symbbol2 = (char) 92;

        public void foreColor()
        {
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
            label12.ForeColor = Color.White;
            label13.ForeColor = Color.White;
            label14.ForeColor = Color.White;
            label15.ForeColor = Color.White;
            label16.ForeColor = Color.White;
            label17.ForeColor = Color.White;
            label18.ForeColor = Color.White;
            label19.ForeColor = Color.White;
            label20.ForeColor = Color.White;
            label21.ForeColor = Color.White;
            label22.ForeColor = Color.White;
            label23.ForeColor = Color.White;
            label24.ForeColor = Color.White;
            label25.ForeColor = Color.White;
            label26.ForeColor = Color.White;
            label27.ForeColor = Color.White;
            label28.ForeColor = Color.White;
            label30.ForeColor = Color.White;
            label32.ForeColor = Color.White;
            label34.ForeColor = Color.White;
            label36.ForeColor = Color.White;
            label38.ForeColor = Color.White;
            label40.ForeColor = Color.White;
            label42.ForeColor = Color.White;
            label44.ForeColor = Color.White;
            label46.ForeColor = Color.White;
            label48.ForeColor = Color.White;
            label49.ForeColor = Color.White;
            label50.ForeColor = Color.White;
            label51.ForeColor = Color.White;
            label52.ForeColor = Color.White;
            label54.ForeColor = Color.White;
            label56.ForeColor = Color.White;
            label58.ForeColor = Color.White;
            label60.ForeColor = Color.White;
            label62.ForeColor = Color.White;
            label64.ForeColor = Color.White;
            label66.ForeColor = Color.White;
            label68.ForeColor = Color.White;
            label70.ForeColor = Color.White;
            label71.ForeColor = Color.White;
            label72.ForeColor = Color.White;
            label73.ForeColor = Color.White;
            label74.ForeColor = Color.White;
            label75.ForeColor = Color.White;
            label76.ForeColor = Color.White;
            label78.ForeColor = Color.White;
            label80.ForeColor = Color.White;
            label82.ForeColor = Color.White;
            label84.ForeColor = Color.White;
            label86.ForeColor = Color.White;
            label88.ForeColor = Color.White;
            label90.ForeColor = Color.White;
            label91.ForeColor = Color.White;
            label92.ForeColor = Color.White;
            label93.ForeColor = Color.White;
            label94.ForeColor = Color.White;
            label95.ForeColor = Color.White;
            space.Visible = false;
            spaceEr.Visible = false;
            ShiftLeft.Visible = false;
            ShiftRight.Visible = false;
        }
        public void backColor()
        {
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent; 
            label16.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            label18.BackColor = Color.Transparent;
            label19.BackColor = Color.Transparent;
            label20.BackColor = Color.Transparent;
            label21.BackColor = Color.Transparent;
            label22.BackColor = Color.Transparent;
            label23.BackColor = Color.Transparent;
            label24.BackColor = Color.Transparent;
            label25.BackColor = Color.Transparent;
            label26.BackColor = Color.Transparent;
            label27.BackColor = Color.Transparent;
            label28.BackColor = Color.Transparent;
            label30.BackColor = Color.Transparent;
            label32.BackColor = Color.Transparent;
            label34.BackColor = Color.Transparent;
            label36.BackColor = Color.Transparent;
            label38.BackColor = Color.Transparent;
            label40.BackColor = Color.Transparent;
            label42.BackColor = Color.Transparent;
            label44.BackColor = Color.Transparent;
            label46.BackColor = Color.Transparent;
            label49.BackColor = Color.Transparent;
            label48.BackColor = Color.Transparent;
            label51.BackColor = Color.Transparent;
            label50.BackColor = Color.Transparent;
            label52.BackColor = Color.Transparent;
            label54.BackColor = Color.Transparent;
            label56.BackColor = Color.Transparent;
            label58.BackColor = Color.Transparent;
            label60.BackColor = Color.Transparent;
            label62.BackColor = Color.Transparent;
            label64.BackColor = Color.Transparent;
            label66.BackColor = Color.Transparent;
            label68.BackColor = Color.Transparent;
            label70.BackColor = Color.Transparent;
            label71.BackColor = Color.Transparent;
            label72.BackColor = Color.Transparent;
            label73.BackColor = Color.Transparent;
            label74.BackColor = Color.Transparent;
            label75.BackColor = Color.Transparent;
            label76.BackColor = Color.Transparent;
            label78.BackColor = Color.Transparent;
            label80.BackColor = Color.Transparent;
            label82.BackColor = Color.Transparent;
            label84.BackColor = Color.Transparent;
            label86.BackColor = Color.Transparent;
            label88.BackColor = Color.Transparent;
            label90.BackColor = Color.Transparent;
            label91.BackColor = Color.Transparent;
            label92.BackColor = Color.Transparent;
            label93.BackColor = Color.Transparent;
            label94.BackColor = Color.Transparent;
            label95.BackColor = Color.Transparent;
                        
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
        public void EnglishAlphabetFunc()
        {            
            Alphabet = EnglishAlphabet;
            label3.Text = "~";
            label5.Text = "!";
            label7.Text = "@";
            label9.Text = "#";
            label11.Text = "$";
            label13.Text = "%";
            label15.Text = "^";
            label17.Text = "&&";
            label19.Text = "*";
            label21.Text = "(";
            label23.Text = ")";
            label28.Text = "Q";
            label30.Text = "W";
            label32.Text = "E";
            label34.Text = "R";
            label36.Text = "T";
            label38.Text = "Y";
            label40.Text = "U";
            label42.Text = "I";
            label44.Text = "O";
            label46.Text = "P";
            label48.Text = "[";
            label49.Text = "{";
            label50.Text = "]";
            label51.Text = "}";
            label52.Text = "A";
            label54.Text = "S";
            label56.Text = "D";
            label58.Text = "F";
            label60.Text = "G";
            label62.Text = "H";
            label64.Text = "J";
            label66.Text = "K";
            label68.Text = "L";
            label70.Text = ";";
            label71.Text = ":";
            label72.Text = "'";
            label73.Text = Convert.ToString(symbol1);
            //   label74.Text = "\";
            label75.Text = "|";
            label76.Text = "Z";
            label78.Text = "X";
            label80.Text = "C";
            label82.Text = "V";
            label84.Text = "B";
            label86.Text = "N";
            label88.Text = "M";
            label90.Text = ",";
            label91.Text = "<";
            label92.Text = ".";
            label93.Text = ">";
            label94.Text = "/";
            label95.Text = "?";

            label2.Visible = true;
            label48.Visible = true;
            label50.Visible = true;
            label70.Visible = true;
            label72.Visible = true;
            label90.Visible = true;
            label92.Visible = true;


            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

        }
        public void RussianAlphabetFunc()
        {
            Alphabet = RussianAlphabet;
            label3.Text = "Ё";
            label5.Text = "!";
            label7.Text = Convert.ToString(symbol1);
            label9.Text = "№";
            label11.Text = ";";
            label13.Text = "%";
            label15.Text = ":";
            label17.Text = "?";
            label19.Text = "*";
            label21.Text = "(";
            label23.Text = ")";
            label28.Text = "Й";
            label30.Text = "Ц";
            label32.Text = "У";
            label34.Text = "К";
            label36.Text = "Е";
            label38.Text = "Н";
            label40.Text = "Г";
            label42.Text = "Ш";
            label44.Text = "Щ";
            label46.Text = "З";
            label49.Text = "Х";
            label51.Text = "Ъ";
            label52.Text = "Ф";
            label54.Text = "Ы";
            label56.Text = "В";
            label58.Text = "А";
            label60.Text = "П";
            label62.Text = "Р";
            label64.Text = "О";
            label66.Text = "Л";
            label68.Text = "Д";
            label71.Text = "Ж";
            label73.Text = "Э";
            //label72.Text =;
            //label74.Text =;
            label75.Text = "/";
            label76.Text = "Я";
            label78.Text = "Ч";
            label80.Text = "С";
            label82.Text = "М";
            label84.Text = "И";
            label86.Text = "Т";
            label88.Text = "Ь";
            label91.Text = "Б";
            label93.Text = "Ю";
            label94.Text = ".";
            label95.Text = ",";


            label2.Visible = false;
            label48.Visible = false;
            label50.Visible = false;
            label70.Visible = false;
            label72.Visible = false;
            label90.Visible = false;
            label92.Visible = false;
            //     label49.Font.Size=

            //     label49 = new System.Windows.Forms.Label();
            
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));


        }
        public void LetterEr(string ErrorLetter, bool AlphabetNumber)
        {
            if (ErrorLetterCopy==null)
                ErrorLetterCopy = ErrorLetter;
            if (AlphabetNumber == false)
                EnglishAlphabetFunc();
            else
                RussianAlphabetFunc();

            if (ErrorLetter == Alphabet.Substring(4, 1))
                label4.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(5, 1))
                label5.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(6, 1))
                label6.ForeColor = Color.Red;
            // label7 для русского это "
            if (ErrorLetter == Alphabet.Substring(8, 1))
                label8.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(9, 1))
                label9.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(10, 1))
                label10.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(11, 1))
                label11.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(12, 1))
                label12.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(13, 1))
                label13.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(14, 1))
                label14.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(15, 1))
                label15.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(16, 1))
                label16.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(17, 1))
                label17.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(18, 1))
                label18.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(19, 1))
                label19.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(20, 1))
                label20.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(21, 1))
                label21.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(22, 1))
                label22.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(23, 1))
                label23.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(24, 1))
                label24.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(25, 1))
                label25.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(26, 1))
                label26.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(27, 1))
                label27.ForeColor = Color.Red;

            if (ErrorLetter == Alphabet.Substring(28, 1) || ErrorLetter == Alphabet.Substring(29, 1))
                label28.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(30, 1) || ErrorLetter == Alphabet.Substring(31, 1))
                label30.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(32, 1) || ErrorLetter == Alphabet.Substring(33, 1))
                label32.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(34, 1) || ErrorLetter == Alphabet.Substring(35, 1))
                label34.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(36, 1) || ErrorLetter == Alphabet.Substring(37, 1))
                label36.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(38, 1) || ErrorLetter == Alphabet.Substring(39, 1))
                label38.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(40, 1) || ErrorLetter == Alphabet.Substring(41, 1))
                label40.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(42, 1) || ErrorLetter == Alphabet.Substring(43, 1))
                label42.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(44, 1) || ErrorLetter == Alphabet.Substring(45, 1))
                label44.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(46, 1) || ErrorLetter == Alphabet.Substring(47, 1))
                label46.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(52, 1) || ErrorLetter == Alphabet.Substring(53, 1))
                label52.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(54, 1) || ErrorLetter == Alphabet.Substring(55, 1))
                label54.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(56, 1) || ErrorLetter == Alphabet.Substring(57, 1))
                label56.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(58, 1) || ErrorLetter == Alphabet.Substring(59, 1))
                label58.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(60, 1) || ErrorLetter == Alphabet.Substring(61, 1))
                label60.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(62, 1) || ErrorLetter == Alphabet.Substring(63, 1))
                label62.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(64, 1) || ErrorLetter == Alphabet.Substring(65, 1))
                label64.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(66, 1) || ErrorLetter == Alphabet.Substring(67, 1))
                label66.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(68, 1) || ErrorLetter == Alphabet.Substring(69, 1))
                label68.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(76, 1) || ErrorLetter == Alphabet.Substring(77, 1))
                label76.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(78, 1) || ErrorLetter == Alphabet.Substring(79, 1))
                label78.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(80, 1) || ErrorLetter == Alphabet.Substring(81, 1))
                label80.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(82, 1) || ErrorLetter == Alphabet.Substring(83, 1))
                label82.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(84, 1) || ErrorLetter == Alphabet.Substring(85, 1))
                label84.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(86, 1) || ErrorLetter == Alphabet.Substring(87, 1))
                label86.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(88, 1) || ErrorLetter == Alphabet.Substring(89, 1))
                label88.ForeColor = Color.Red;

            if (Alphabet==EnglishAlphabet)
            {
                if (ErrorLetter == Alphabet.Substring(2, 1))
                    label2.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(3, 1))
                    label3.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(7, 1))
                    label7.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(48, 1))
                    label48.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(49, 1))
                    label49.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(50, 1))
                    label50.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(51, 1))
                    label51.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(70, 1))
                    label70.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(71, 1))
                    label71.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(72, 1))
                    label72.ForeColor = Color.Red;
                if (ErrorLetter == Convert.ToString(symbol1))
                    label73.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(90, 1))
                    label90.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(91, 1))
                    label91.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(92, 1))
                    label92.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(93, 1))
                    label93.ForeColor = Color.Red;

            }
            else
            {

                if (ErrorLetter == Convert.ToString(symbol1))
                    label7.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(2, 1) || ErrorLetter == Alphabet.Substring(3, 1))
                    label2.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(2, 1) || ErrorLetter == Alphabet.Substring(3, 1))
                    label3.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(48, 1) || ErrorLetter == Alphabet.Substring(49, 1))
                    label49.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(50, 1) || ErrorLetter == Alphabet.Substring(51, 1))
                    label51.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(70, 1) || ErrorLetter == Alphabet.Substring(71, 1))
                    label71.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(72, 1) || ErrorLetter == Alphabet.Substring(73, 1))
                    label73.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(90, 1) || ErrorLetter == Alphabet.Substring(91, 1))
                    label91.ForeColor = Color.Red;
                if (ErrorLetter == Alphabet.Substring(92, 1) || ErrorLetter == Alphabet.Substring(93, 1))
                    label93.ForeColor = Color.Red;
            }
                        
            if (ErrorLetter == Convert.ToString(symbbol2))
                label74.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(75, 1))
                label75.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(94, 1))
                label94.ForeColor = Color.Red;
            if (ErrorLetter == Alphabet.Substring(95, 1))
                label95.ForeColor = Color.Red;

            if (ErrorLetter == Alphabet.Substring(0, 1))
                spaceEr.Visible = true;

            if (ErrorLetter != ErrorLetterCopy)
            {
                foreColor();
                ErrorLetterCopy = ErrorLetter;
            }
        }
        public void Letter(string NecessaryLetter, bool AlphabetNumber, bool start)
        {
            if (start == true)
                NecessaryLetterCopy = NecessaryLetter;
            if (AlphabetNumber == false)
                EnglishAlphabetFunc();
            else
                RussianAlphabetFunc();
                        
            if (NecessaryLetter == Alphabet.Substring(4, 1))
                label4.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(5, 1))
                label5.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(6, 1))
                label6.ForeColor = Color.Lime;
            // label7 для русского это "
            if (NecessaryLetter == Alphabet.Substring(8, 1))
                label8.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(9, 1))
                label9.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(10, 1))
                label10.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(11, 1))
                label11.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(12, 1))
                label12.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(13, 1))
                label13.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(14, 1))
                label14.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(15, 1))
                label15.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(16, 1))
                label16.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(17, 1))
                label17.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(18, 1))
                label18.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(19, 1))
                label19.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(20, 1))
                label20.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(21, 1))
                label21.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(22, 1))
                label22.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(23, 1))
                label23.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(24, 1))
                label24.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(25, 1))
                label25.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(26, 1))
                label26.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(27, 1))
                label27.ForeColor = Color.Lime;

            if (NecessaryLetter == Alphabet.Substring(28, 1) || NecessaryLetter == Alphabet.Substring(29, 1))
                label28.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(30, 1) || NecessaryLetter == Alphabet.Substring(31, 1))
                label30.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(32, 1) || NecessaryLetter == Alphabet.Substring(33, 1))
                label32.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(34, 1) || NecessaryLetter == Alphabet.Substring(35, 1))
                label34.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(36, 1) || NecessaryLetter == Alphabet.Substring(37, 1))
                label36.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(38, 1) || NecessaryLetter == Alphabet.Substring(39, 1))
                label38.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(40, 1) || NecessaryLetter == Alphabet.Substring(41, 1))
                label40.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(42, 1) || NecessaryLetter == Alphabet.Substring(43, 1))
                label42.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(44, 1) || NecessaryLetter == Alphabet.Substring(45, 1))
                label44.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(46, 1) || NecessaryLetter == Alphabet.Substring(47, 1))
                label46.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(52, 1) || NecessaryLetter == Alphabet.Substring(53, 1))
                label52.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(54, 1) || NecessaryLetter == Alphabet.Substring(55, 1))
                label54.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(56, 1) || NecessaryLetter == Alphabet.Substring(57, 1))
                label56.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(58, 1) || NecessaryLetter == Alphabet.Substring(59, 1))
                label58.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(60, 1) || NecessaryLetter == Alphabet.Substring(61, 1))
                label60.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(62, 1) || NecessaryLetter == Alphabet.Substring(63, 1))
                label62.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(64, 1) || NecessaryLetter == Alphabet.Substring(65, 1))
                label64.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(66, 1) || NecessaryLetter == Alphabet.Substring(67, 1))
                label66.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(68, 1) || NecessaryLetter == Alphabet.Substring(69, 1))
                label68.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(76, 1) || NecessaryLetter == Alphabet.Substring(77, 1))
                label76.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(78, 1) || NecessaryLetter == Alphabet.Substring(79, 1))
                label78.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(80, 1) || NecessaryLetter == Alphabet.Substring(81, 1))
                label80.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(82, 1) || NecessaryLetter == Alphabet.Substring(83, 1))
                label82.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(84, 1) || NecessaryLetter == Alphabet.Substring(85, 1))
                label84.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(86, 1) || NecessaryLetter == Alphabet.Substring(87, 1))
                label86.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(88, 1) || NecessaryLetter == Alphabet.Substring(89, 1))
                label88.ForeColor = Color.Lime;

            if (Alphabet==EnglishAlphabet)
            {

                if (NecessaryLetter == Alphabet.Substring(7, 1))
                    label7.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(48, 1))
                    label48.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(49, 1))
                    label49.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(50, 1))
                    label50.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(51, 1))
                    label51.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(70, 1))
                    label70.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(71, 1))
                    label71.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(72, 1))
                    label72.ForeColor = Color.Lime;
                if (NecessaryLetter == Convert.ToString(symbol1))
                    label73.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(90, 1))
                    label90.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(91, 1))
                    label91.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(92, 1))
                    label92.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(93, 1))
                    label93.ForeColor = Color.Lime;
            }
            else
            {

                if (NecessaryLetter == Convert.ToString(symbol1))
                    label7.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(2, 1) || NecessaryLetter == Alphabet.Substring(3, 1))
                    label2.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(2, 1) || NecessaryLetter == Alphabet.Substring(3, 1))
                    label3.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(48, 1) || NecessaryLetter == Alphabet.Substring(49, 1))
                    label49.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(50, 1) || NecessaryLetter == Alphabet.Substring(51, 1))
                    label51.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(70, 1) || NecessaryLetter == Alphabet.Substring(71, 1))
                    label71.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(72, 1) || NecessaryLetter == Alphabet.Substring(73, 1))
                    label73.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(90, 1) || NecessaryLetter == Alphabet.Substring(91, 1))
                    label91.ForeColor = Color.Lime;
                if (NecessaryLetter == Alphabet.Substring(92, 1) || NecessaryLetter == Alphabet.Substring(93, 1))
                    label93.ForeColor = Color.Lime;
            }

            if (NecessaryLetter == Convert.ToString(symbbol2))
                label74.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(75, 1))
                label75.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(94, 1))
                label94.ForeColor = Color.Lime;
            if (NecessaryLetter == Alphabet.Substring(95, 1))
                label95.ForeColor = Color.Lime;

            if (NecessaryLetter == Alphabet.Substring(0, 1))
                space.Visible = true;
            for (int i=1; i<=95; i+=2)
            {
                if(NecessaryLetter== Alphabet.Substring(i, 1))
                {
                    ShiftLeft.Visible = true;
                    ShiftRight.Visible = true;
                }
            }
            if (NecessaryLetterCopy != NecessaryLetter)
            {
                foreColor();
                NecessaryLetterCopy = NecessaryLetter;
            }
        }

       
    }
}
