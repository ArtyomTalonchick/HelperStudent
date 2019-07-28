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
        //поля
        private string stringOfText="   ";
        private string inputLetter;
        private string necessaryLetter;
        private int lenghtOfLine = 25;
        private int numberOfLetterOfText = 0;
        private int numberOfCorrectlyEnteredLetters = 0;
        private int numberOfEnteredLetters = 0;
        private int timeCounter = 0;
        private int training_time = 30;
        private bool isTyping = false;
        private bool isRussianAlphabet;
        private Keyboard keyboard = new Keyboard();
        private ArmLeft armLeft = new ArmLeft();
        private ArmRight armRight = new ArmRight();
        private DateTime timeText = new DateTime();
        private Typing_ResultForm resultForm = new Typing_ResultForm();

        //метод запуска тренировки
        private void StartTyping()
        {
            isTyping = true;
            WriteBox.Focus();
            numberOfLetterOfText = 0;
            NewText.Text = stringOfText.Substring(0, lenghtOfLine);
            OldText.Text = null;
            necessaryLetter = stringOfText.Substring(0, 1);
            keyboard.InputLetter(necessaryLetter, isRussianAlphabet, armLeft, armRight);
            keyboard.necessaryLetterCopy = null;
            keyboard.errorLetterCopy = null;
        }
       
        //метод для окончания тренировк
        private void FinishTyping()
        {
            WriteResultToFile();
            Timer.Enabled = false;
            isTyping = false;
            CurrentTimeOfTypingLabel.Text = "00:00";
            resultForm.countResults(timeCounter, timeText.ToLongTimeString().Substring(2), numberOfEnteredLetters, numberOfCorrectlyEnteredLetters);

            this.Enabled = false;
            keyboard.Enabled = false;
            numberOfCorrectlyEnteredLetters = 0;
            numberOfEnteredLetters = 0;
            timeText = timeText.AddSeconds(-timeCounter);
            timeCounter = 0;
            WriteBox.Focus();
        }
        
        //метод изменения координат "Клавиатуры" и "рук" в зависимости от координат глвной формы
        private void ChangeKeyboardLocation()
        {
            keyboard.Left = this.Left + 243;
            keyboard.Top = this.Top + 382;
            armLeft.Location = keyboard.Location;
            armRight.Location = keyboard.Location;
        }
        
        //метод записи результата тренировки в файл
        private void WriteResultToFile()
        {
            int numberOfRecordedResultsEnglish = -1;
            int numberOfRecordedResultsRussian = -1;
            string[] ResStor = new string[100];
            string[] ResStorTime = new string[100];
            string[] ResStorDate = new string[100];
            string[] ResStorSpeed = new string[100];
            if (isRussianAlphabet == false)
            {
                numberOfRecordedResultsEnglish = Convert.ToInt32(File.ReadAllText(@"ResultStoryEnglishIndex.txt"));
                numberOfRecordedResultsEnglish++;
                File.WriteAllText(@"ResultStoryEnglishIndex.txt", Convert.ToString(numberOfRecordedResultsEnglish));
                ResStor = File.ReadAllLines(@"ResultStoryEnglish.txt");
            }
            else
            {
                numberOfRecordedResultsRussian = Convert.ToInt32(File.ReadAllText(@"ResultStoryRussiaIndex.txt"));
                numberOfRecordedResultsRussian++;
                File.WriteAllText(@"ResultStoryRussiaIndex.txt", Convert.ToString(numberOfRecordedResultsRussian));
                ResStor = File.ReadAllLines(@"ResultStoryRussia.txt");
            }
            if (isRussianAlphabet == false)
            {
                ResStorTime[numberOfRecordedResultsEnglish] = timeCounter.ToString();
                ResStorDate[numberOfRecordedResultsEnglish] = Date.Text;
                ResStorSpeed[numberOfRecordedResultsEnglish] = (60 * numberOfCorrectlyEnteredLetters / timeCounter).ToString();
                ResStor[numberOfRecordedResultsEnglish] = ResStorDate[numberOfRecordedResultsEnglish] + "\t\t" + ResStorTime[numberOfRecordedResultsEnglish] + "\t\t" + ResStorSpeed[numberOfRecordedResultsEnglish];
            }
            else
            {
                ResStorTime[numberOfRecordedResultsRussian] = timeCounter.ToString();
                ResStorDate[numberOfRecordedResultsRussian] = Date.Text;
                ResStorSpeed[numberOfRecordedResultsRussian] = (60 * numberOfCorrectlyEnteredLetters / timeCounter).ToString();
                ResStor[numberOfRecordedResultsRussian] = ResStorDate[numberOfRecordedResultsRussian] + "\t\t" + ResStorTime[numberOfRecordedResultsRussian] + "\t\t" + ResStorSpeed[numberOfRecordedResultsRussian];
            }
            if (isRussianAlphabet == false)
                File.WriteAllLines(@"ResultStoryEnglish.txt", ResStor);
            else
                File.WriteAllLines(@"ResultStoryRussia.txt", ResStor);
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
        }
        

        //метод оброботки события нажатия на кнопку "Клавиатура" - показывает/убирает клавиатуру
        private void KeyboardButton_Click(object sender, EventArgs e)
        {
            if (keyboard.Visible == false)
            {
                keyboard.Visible = true;
                this.Top = 0;
            }
            else
            {
                keyboard.Visible = false;
                armLeft.Visible = false;
                armRight.Visible = false;
            }
        }
        
        //метод оброботки события нажатия на кнопку "Руки" - показывает/убирает "руки"
        private void ArmsButton_Click(object sender, EventArgs e)
        {
            if (keyboard.Visible == true)
            {
                if (armLeft.Visible == false)
                {
                    armLeft.Visible = true;
                    armLeft.Visible = true;
                    armRight.Visible = true;
                }
                else if (keyboard.Visible == true)
                {
                    armLeft.Visible = false;
                    armLeft.Visible = false;
                    armRight.Visible = false;
                }
            }
        }
        
        //метод оброботки события нажатия на кнопку "Стоп" - досрочное окончание тренировки
        private void Stop_Click(object sender, EventArgs e)
        {
            if (numberOfEnteredLetters != 0)
                FinishTyping();
        }
        
        //метод оброботки события нажатия на кнопку "Результаты" - открывает форму с результатами
        private void ResultStoryButton_Click(object sender, EventArgs e)
        {
            Typing_ResultStoryForm ResultStoryForm = new Typing_ResultStoryForm();
            ResultStoryForm.Show();
            this.Enabled = false;
            keyboard.Enabled = false;
        }
       
        //метод оброботки события Timer - срабатывает во время тренировки с периодом в одну секунды
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeText = timeText.AddSeconds(1);
            CurrentTimeOfTypingLabel.Text = timeText.ToLongTimeString().Substring(2);
            timeCounter++;
            WriteBox.Focus();
        }

        //метод оброботки события Timer с периодом срабатывания одна милисекунда
        private void Сycle_Tick(object sender, EventArgs e)
        {
            if (isTyping == true)
            {
                TimeSelectNumericUpDown.Enabled = false;
                ResultStoryButton.Enabled = false;
                MinuteOfTypingLabel.Enabled = false;
                SelectTextForTypingMenuStrip.Enabled = false;
                PageTraining.Show();
                training_time = ((int)TimeSelectNumericUpDown.Value) * 60;
            }
            else
            {
                TimeSelectNumericUpDown.Enabled = true;
                MinuteOfTypingLabel.Enabled = true;
                SelectTextForTypingMenuStrip.Enabled = true;
                ResultStoryButton.Enabled = true;
            }
            if (timeCounter == training_time)
                FinishTyping();
            if (stringOfText.Substring(numberOfLetterOfText, 3) == "   " && isTyping == true)
            {
                FinishTyping();
                isTyping = false;
                OldText.Text = "Начинаем";
                NewText.Text = " тыкать?";
            }
            ChangeKeyboardLocation();
        }
       
        //метод оброботки события Timer с периодом срабатывания одна секунда для помещения фокуса на WriteBox (поле ввода)
        private void FocusOnWriteBoxTimer_Tick(object sender, EventArgs e) => WriteBox.Focus();

        //метод оброботки события изменения TimeSelectNumericUpDown - изменение MinuteOfTypingLabel 
        private void TimeSelectNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (((int)TimeSelectNumericUpDown.Value) > 10 && ((int)TimeSelectNumericUpDown.Value) < 15)
                MinuteOfTypingLabel.Text = "Минут";
            else
            {
                switch (((int)TimeSelectNumericUpDown.Value) % 10)
                {
                    case 1:
                        MinuteOfTypingLabel.Text = "Минута";
                        break;
                    case 2:
                    case 3:
                    case 4:
                        MinuteOfTypingLabel.Text = "Минуты";
                        break;
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 0:
                        MinuteOfTypingLabel.Text = "Минут";
                        break;
                }
            }
        }
        
        //метод оброботки события изменения компонента WriteBox - обработка ввода пользователем буквы
        private void WriteBox_TextChanged(object sender, EventArgs e)
        {
            keyboard.InputLetter(necessaryLetter, isRussianAlphabet, armLeft, armRight);
            if (WriteBox.Text != "")
            {
                isTyping = true;
                Timer.Enabled = true;
                inputLetter = WriteBox.Text;
                numberOfEnteredLetters++;
                if (inputLetter != stringOfText.Substring(numberOfLetterOfText, 1))
                {
                    keyboard.LetterError(inputLetter, isRussianAlphabet);
                }                
            }
            if (WriteBox.Text == stringOfText.Substring(numberOfLetterOfText, 1) && numberOfLetterOfText + 1 < stringOfText.Length && isTyping == true)
            {
                numberOfLetterOfText++;
                NewText.Text = stringOfText.Substring(numberOfLetterOfText, lenghtOfLine);
                if (numberOfLetterOfText < lenghtOfLine)
                    OldText.Text = stringOfText.Substring(0, numberOfLetterOfText);
                else
                    OldText.Text = stringOfText.Substring(numberOfLetterOfText - lenghtOfLine, lenghtOfLine);
                numberOfCorrectlyEnteredLetters++;
                necessaryLetter = stringOfText.Substring(numberOfLetterOfText, 1);
            }
            if (WriteBox.Text != "")
                WriteBox.Text = null;
        }
    }
}