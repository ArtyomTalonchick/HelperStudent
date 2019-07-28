using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OurProject._0
{
    public partial class Helper
    {
        string[] ResStor = new string[100];
        string[] ResStorTime = new string[100];
        string[] ResStorDate = new string[100];
        string[] ResStorSpeed = new string[100];
        int EnglishIndex = -1;
        int RussiaIndex = -1;

        public void ResultStory()
        {
            if (isRussianAlphabet == false)
            {
                EnglishIndex = Convert.ToInt32(File.ReadAllText(@"ResultStoryEnglishIndex.txt"));
                EnglishIndex++;
                File.WriteAllText(@"ResultStoryEnglishIndex.txt", Convert.ToString(EnglishIndex));
                ResStor = File.ReadAllLines(@"ResultStoryEnglish.txt");
            }
            else
            {
                RussiaIndex = Convert.ToInt32(File.ReadAllText(@"ResultStoryRussiaIndex.txt"));
                RussiaIndex++;
                File.WriteAllText(@"ResultStoryRussiaIndex.txt", Convert.ToString(RussiaIndex));
                ResStor = File.ReadAllLines(@"ResultStoryRussia.txt");
            }
            if (isRussianAlphabet == false)
            {
                ResStorTime[EnglishIndex] = timeCounter.ToString();
                ResStorDate[EnglishIndex] = Date.Text;
                ResStorSpeed[EnglishIndex] = (60 * rightElement / timeCounter).ToString();
                ResStor[EnglishIndex] = ResStorDate[EnglishIndex] + "\t\t" + ResStorTime[EnglishIndex] + "\t\t" + ResStorSpeed[EnglishIndex];
            }
            else
            {
                ResStorTime[RussiaIndex] = timeCounter.ToString();
                ResStorDate[RussiaIndex] = Date.Text;
                ResStorSpeed[RussiaIndex] = (60 * rightElement / timeCounter).ToString();
                ResStor[RussiaIndex] = ResStorDate[RussiaIndex] + "\t\t" + ResStorTime[RussiaIndex] + "\t\t" + ResStorSpeed[RussiaIndex];
            }

            if (isRussianAlphabet == false)
                File.WriteAllLines(@"ResultStoryEnglish.txt", ResStor);
            else
                File.WriteAllLines(@"ResultStoryRussia.txt", ResStor);
        }

        void StartTyping()
        {
            keyboard.ChangeForeColor();
            WriteBox.Focus();
            i = 0;
            NewText.Text = ArrayOfText.Substring(0, lenghtOfLine);
            OldText.Text = null;
            necessaryLetter = ArrayOfText.Substring(0, 1);
            keyboard.InputLetter(necessaryLetter, isRussianAlphabet, true, armLeft, armRight);
        }

        void FinishTyping()
        {
            ResultStory();
            if (isRussianAlphabet == false)
            {
                File.Delete(@"ResultStoryEnglish.txt");
                File.WriteAllLines(@"ResultStoryEnglish.txt", ResStor);
            }
            else
            {
                File.Delete(@"ResultStoryRussia.txt");
                File.WriteAllLines(@"ResultStoryRussia.txt", ResStor);
            }
            Timer.Enabled = false;
            TimeLabel.Text = "00:00";
            ResultForm Result = new ResultForm(timeCounter, timeText.ToLongTimeString().Substring(2), allElement, rightElement);
            Result.Show();

            this.Enabled = false;
            keyboard.Enabled = false;
            rightElement = 0;
            allElement = 0;
            timeText = timeText.AddSeconds(-timeCounter);
            timeCounter = 0;
            WriteBox.Focus();
            keyboard.ChangeForeColor();
        }

        string ArrayOfText = "0000000000000000   ";
        int i = 0;
        int lenghtOfLine = 25;
        int rightElement = 0;
        int allElement = 0;
        int timeCounter = 0;
        DateTime timeText = new DateTime();
        int time = 30;
        bool isTyping = false;
        string necessaryLetter;
        string inputLetter;
        bool isRussianAlphabet;

        private void Stop_Click(object sender, EventArgs e)
        {
            if (allElement != 0)
                FinishTyping();
        }
        bool writeBoxIsEmpty = false;
        private void WriteBox_TextChanged(object sender, EventArgs e)
        {
            if (writeBoxIsEmpty == false)
            {
                inputLetter = WriteBox.Text;
            }
            writeBoxIsEmpty = !writeBoxIsEmpty;
            if ((inputLetter != ArrayOfText.Substring(i, 1)))
            {
                keyboard.LetterError(inputLetter, isRussianAlphabet);
            }
            if (WriteBox.Text != null && isTyping == true)
            {
                Timer.Enabled = true;
                allElement++;
            }
            if (WriteBox.Text == ArrayOfText.Substring(i, 1) && i + 1 < ArrayOfText.Length && isTyping == true)
            {
                i++;
                NewText.Text = ArrayOfText.Substring(i, lenghtOfLine);
                if (i < lenghtOfLine)
                    OldText.Text = ArrayOfText.Substring(0, i);
                else
                    OldText.Text = ArrayOfText.Substring(i - lenghtOfLine, lenghtOfLine);
                rightElement++;
                necessaryLetter = ArrayOfText.Substring(i, 1);
            }

            WriteBox.Text = null;
            keyboard.InputLetter(necessaryLetter, isRussianAlphabet, false, armLeft, armRight);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeText = timeText.AddSeconds(1);
            TimeLabel.Text = timeText.ToLongTimeString().Substring(2);
            timeCounter++;
        }

        private void Сycle_Tick(object sender, EventArgs e)
        {
            if (Timer.Enabled == true)
            {
                TimeSelect.Enabled = false;
                ResultStoryButton.Enabled = false;
                MinuteText.Enabled = false;
                time = ((int)TimeSelect.Value) * 60;
            }
            else
            {
                if (((int)TimeSelect.Value) > 10 && ((int)TimeSelect.Value) < 15)
                    MinuteText.Text = "Минут";
                else
                {
                    switch (((int)TimeSelect.Value) % 10)
                    {
                        case 1:
                            MinuteText.Text = "Минута";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            MinuteText.Text = "Минуты";
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 0:
                            MinuteText.Text = "Минут";
                            break;
                    }
                }

                TimeSelect.Enabled = true;
                MinuteText.Enabled = true;
            }
            if (timeCounter == time)
            {
                FinishTyping();
            }
            if (ArrayOfText.Substring(i, 3) == "   " && isTyping == true)
            {
                FinishTyping();
                isTyping = false;
                OldText.Text = "Начинаем";
                NewText.Text = " тыкать?";
            }
            if (Timer.Enabled == true)
            {
                TrainingSelect.Enabled = false;
                PageTraining.Show();
            }
            else
            {
                TrainingSelect.Enabled = true;
                ResultStoryButton.Enabled = true;
            }
            windowLeft = this.Left;
            windowTop = this.Top;
            locationOfKeyboard.X = windowLeft + 243;
            locationOfKeyboard.Y = windowTop + 382;
            keyboard.Location = locationOfKeyboard;
            armLeft.Location = locationOfKeyboard;
            armRight.Location = locationOfKeyboard;
        }
        private void Cycle1Sek_Tick(object sender, EventArgs e)
        {
            WriteBox.Focus();
        }

        Keyboard keyboard = new Keyboard();
        Point locationOfKeyboard = new Point();
        Point locationOfForm = new Point();
        ArmLeft armLeft = new ArmLeft();
        ArmRight armRight = new ArmRight();
        int windowLeft;
        int windowTop;
        bool KeyboardVisible = false;
        bool ArmsVisible = false;

        private void KeyboardButton_Click(object sender, EventArgs e)
        {
            KeyboardVisible = !KeyboardVisible;
            if (KeyboardVisible == true)
            {
                this.StartPosition = FormStartPosition.Manual;
                locationOfForm.X = windowLeft;
                locationOfForm.Y = 0;
                this.Location = locationOfForm;
                keyboard.Show();
            }
            else
            {
                keyboard.Visible = false;
                if (ArmsVisible == true)
                {
                    ArmsVisible = false;
                    armLeft.Visible = false;
                    armRight.Visible = false;
                }
                /*     this.StartPosition = FormStartPosition.CenterScreen;
                     PointForm1.X = 0;
                     PointForm1.Y = 0;                                            ???????????/
                     this.Location = PointForm1;
                   */
            }
        }
        private void ArmsButton_Click(object sender, EventArgs e)
        {
            ArmsVisible = !ArmsVisible;
            if (ArmsVisible == true && KeyboardVisible == true)
            {
                this.StartPosition = FormStartPosition.Manual;
                locationOfForm.X = windowLeft;
                locationOfForm.Y = 0;
                this.Location = locationOfForm;
                armLeft.Show();
                armRight.Show();
            }
            else
            {
                armLeft.Visible = false;
                armRight.Visible = false;
            }
        }
        private void ResultStoryButton_Click(object sender, EventArgs e)
        {
            ResultStoryForm ResultStoryForm = new ResultStoryForm();
            ResultStoryForm.Show();
            this.Enabled = false;
            keyboard.Enabled = false;
        }
    }
}