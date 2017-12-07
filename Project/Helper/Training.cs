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
    public partial class Helper
    {
        void start()
        {
            Keyboard.foreColor();
            WriteBox.Focus();
            i = 0;
            NewText.Text = array.Substring(0, len);
            OldText.Text = null;
            NecessaryLetter = array.Substring(0, 1);
            Keyboard.Letter(NecessaryLetter, AlphabetNumber, true);
        }
        void finish()
        {
            Timer.Enabled = false;
            TimeLabel.Text = "00:00";
            ResultForm Result = new ResultForm(TimeCounter, TimeText.ToLongTimeString().Substring(2), AllElement, RightElement);
            Result.Show();

            this.Enabled = false;
            Keyboard.Enabled = false;
            RightElement = 0;
            AllElement = 0;
            TimeText = TimeText.AddSeconds(-TimeCounter);
            TimeCounter = 0;
            WriteBox.Focus();
            Keyboard.foreColor();
        }

        string array = "0000000000000000   ";
        int i = 0;
        int len = 25;
        int RightElement = 0;
        int AllElement = 0;
        int TimeCounter = 0;
        DateTime TimeText = new DateTime();
        int Time = 180;                                                                    //????????????????????????
        bool Flag = false;
        string NecessaryLetter;
        string ErrorLetter;
        bool AlphabetNumber;

        private void Stop_Click(object sender, EventArgs e)
        {
            if (AllElement!= 0)
                finish();
        }
        bool FlagWriteBox = false;
        private void WriteBox_TextChanged(object sender, EventArgs e)
        {
            if (FlagWriteBox ==false)
            {
                ErrorLetter= WriteBox.Text;
            }
            FlagWriteBox = !FlagWriteBox;
            if (ErrorLetter != array.Substring(i, 1))
            {
                Keyboard.LetterEr(ErrorLetter, AlphabetNumber);
            }
            if (WriteBox.Text != null && Flag == true)
            {          
                Timer.Enabled = true;
                AllElement++;
            }
            if (WriteBox.Text == array.Substring(i, 1) && array.Substring(i, 3) != "   " && Flag == true)
            {
                if (i + 1 < array.Length)
                    i++;
                NewText.Text = array.Substring(i, len);
                if (i < len)
                    OldText.Text = array.Substring(0, i);
                else
                    OldText.Text = array.Substring(i - len, len);
                RightElement++;
                NecessaryLetter = array.Substring(i, 1);
            }              
           
            Keyboard.Letter(NecessaryLetter, AlphabetNumber, false);
            WriteBox.Text = null;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {           
            TimeText = TimeText.AddSeconds(1);
            TimeLabel.Text = TimeText.ToLongTimeString().Substring(2);
            TimeCounter++;
        }
        
        private void Сycle_Tick(object sender, EventArgs e)
        {           
            if (TimeCounter == Time)
            {
                finish();
            }
            if (array.Substring(i, 3) == "   " && Flag == true)
            {
                finish();
                Flag = false;
                OldText.Text = "Начинаем ";
                NewText.Text = "печатать?";
            }
            if (Timer.Enabled == true)
            {
             //  English.Enabled = false;                                  //????????????????????????
            }
            windowLeft = this.Left;
            windowTop = this.Top;
            PointKeyboard.X = windowLeft + 243;
            PointKeyboard.Y = windowTop + 382;
            Keyboard.Location = PointKeyboard;
                  
        }
        private void Cycle1Sek_Tick(object sender, EventArgs e)
        {             
            WriteBox.Focus();
        }

      //  public void Letter("  ");
        Keyboard Keyboard = new Keyboard();
        Point PointKeyboard = new Point();
        Point PointForm1 = new Point();
        int windowLeft;
        int windowTop;
        bool KeyboardFlag = false;

        private void KeyboardButton_Click(object sender, EventArgs e)
        {            
            KeyboardFlag = !KeyboardFlag;
            if(KeyboardFlag==true)
            {
                this.StartPosition = FormStartPosition.Manual;
                PointForm1.X = windowLeft;
                PointForm1.Y = 0;
                this.Location = PointForm1;
                Keyboard.Show();
            }
            else
            {
                Keyboard.Visible = false;
           /*     this.StartPosition = FormStartPosition.CenterScreen;
                PointForm1.X = 0;
                PointForm1.Y = 0;                                            ???????????/
                this.Location = PointForm1;
              */
            }
                
                     
        }
    }
}
