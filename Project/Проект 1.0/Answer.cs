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
    public partial class Helper
    {        
        public void random()
        {
            NumberAnswer = 0;
            NumberRigtAnswer = 0;
            bool OurFlag = false;
            for (int i = 0; i < AllAnswerNumber; i++)
            {
                do
                {
                    OurFlag = false;

                    OrderQuestions[i] = rand.Next(0, AllAnswerNumber);
                    for (int j = 0; j < i; j++)
                    {
                        if (OrderQuestions[i] == OrderQuestions[j])
                        {
                            OurFlag = true;
                        }
                    }
                }
                while (OurFlag == true);
            }

        }
        int NumberQuestion = 0;
        public void StartQuestion(int i)
        {
            NumberQuestionText.Text = (++NumberQuestion).ToString()+'.';

            if (NumberAnswer == 1)
                FinishButton.Enabled = true;
            QuestionText.Text = Answer[5 * i];
            Answer1.Text = Answer[5 * i + 1];
            Answer2.Text = Answer[5 * i + 2];
            Answer3.Text = Answer[5 * i + 3];
            Answer4.Text = Answer[5 * i + 4];
            Answer1.BackColor = Color.Transparent;
            Answer2.BackColor = Color.Transparent;
            Answer3.BackColor = Color.Transparent;
            Answer4.BackColor = Color.Transparent;
            Answer1.Checked = false;
            Answer2.Checked = false;
            Answer3.Checked = false;
            Answer4.Checked = false;
            Answer1.Enabled = true;
            Answer2.Enabled = true;
            Answer3.Enabled = true;
            Answer4.Enabled = true;
            AnswerButton.Text = "Ок";
            Mark.Text = "";

        }
        
        private void FinishButton_Click(object sender, EventArgs e)
        {
            FinishQuestion();
        }
        public void FinishQuestion()
        {
            ResultFormTest ResultFormTest = new ResultFormTest(NumberAnswer, NumberRigtAnswer);
            ResultFormTest.Show();
            this.Enabled = false;
            Answer1.BackColor = Color.Transparent;
            Answer2.BackColor = Color.Transparent;
            Answer3.BackColor = Color.Transparent;
            Answer4.BackColor = Color.Transparent;
            Answer1.Checked = false;
            Answer2.Checked = false;
            Answer3.Checked = false;
            Answer4.Checked = false;
            Answer1.Enabled = false;
            Answer2.Enabled = false;
            Answer3.Enabled = false;
            Answer4.Enabled = false;
            FinishButton.Enabled = false;
            Answer1.Text = "Answer1";
            Answer2.Text = "Answer2";
            Answer3.Text = "Answer3";
            Answer4.Text = "Answer4";
            QuestionText.Text = "Ну чё, порёшаем тестики!?";
            NumberAnswer = 0;
            NumberRigtAnswer = 0;
            IncorrectAnswer.Text = "0";
            RightAnswerText.Text = "0";
            AnswerButton.Text = "Ок";
            Mark.Text = "";
            NumberQuestionText.Text = "0.";

        }

        string[] Answer = new string[50];
        int[] RightAnswer = new int[10];
        int[] OrderQuestions = new int[10];
        //    int NumberQuestion;
        int AllAnswerNumber = 8;
        int OurAnswer = 0;
        int NumberAnswer = 0;
        int NumberRigtAnswer = 0;
        bool FlagAnswer = false;

        public void AnswerButton_Click(object sender, EventArgs e)
        {
            if (FlagAnswer == true)
            {
                if (NumberAnswer < AllAnswerNumber)
                    StartQuestion(OrderQuestions[NumberAnswer]);
                else
                    FinishQuestion();
                FlagAnswer = false;
            }
            else
            {
                Answer1.Enabled = false;
                Answer2.Enabled = false;
                Answer3.Enabled = false;
                Answer4.Enabled = false;
                if (OurAnswer == RightAnswer[OrderQuestions[NumberAnswer]])
                {
                    NumberRigtAnswer++;
                    Mark.ForeColor = Color.LimeGreen;
                    Mark.Text = "Правильно!";
                }
                else
                {
                    Mark.ForeColor = Color.Firebrick;
                    Mark.Text = "Ошибка!!!";
                    switch (OurAnswer)
                    {
                        case 1:
                            if (Answer1.Enabled == false)
                                Answer1.BackColor = Color.Firebrick;
                            break;
                        case 2:
                            if (Answer2.Enabled == false)
                                Answer2.BackColor = Color.Firebrick;
                            break;
                        case 3:
                            if (Answer3.Enabled == false)
                                Answer3.BackColor = Color.Firebrick;
                            break;
                        case 4:
                            if (Answer4.Enabled == false)
                                Answer4.BackColor = Color.Firebrick;
                            break;
                    }
                }
                switch (RightAnswer[OrderQuestions[NumberAnswer]])
                {
                    case 1:
                        if (Answer1.Enabled == false)
                            Answer1.BackColor = Color.LimeGreen;
                        break;
                    case 2:
                        if (Answer2.Enabled == false)
                            Answer2.BackColor = Color.LimeGreen;
                        break;
                    case 3:
                        if (Answer3.Enabled == false)
                            Answer3.BackColor = Color.LimeGreen;
                        break;
                    case 4:
                        if (Answer4.Enabled == false)
                            Answer4.BackColor = Color.LimeGreen;
                        break;
                }

                Answer1.Checked = false;
                Answer2.Checked = false;
                Answer3.Checked = false;
                Answer4.Checked = false;
                
                AnswerButton.Text = "Далее";
                
                FlagAnswer = true;

                NumberAnswer++;
            }            
            RightAnswerText.Text = (NumberRigtAnswer).ToString();
            IncorrectAnswer.Text = (NumberAnswer - NumberRigtAnswer).ToString();
        }

        private void CycleTest_Tick(object sender, EventArgs e)
        { 
            if (Answer1.Checked == false && Answer2.Checked == false && Answer3.Checked == false && Answer4.Checked == false && FlagAnswer == false)
                AnswerButton.Enabled = false;
        }
        

        bool FlagOurAnswer1 = false;
        bool FlagOurAnswer2 = false;
        bool FlagOurAnswer3 = false;
        bool FlagOurAnswer4 = false;

        private void Answer1_CheckedChanged(object sender, EventArgs e)
        {
            if (FlagOurAnswer1 == false)
            {
                OurAnswer = 1;
                Answer2.Checked = false;
                Answer3.Checked = false;
                Answer4.Checked = false;
                FlagOurAnswer1 = true;
            }
            else
                FlagOurAnswer1 = false;
            AnswerButton.Enabled = true;
            AnswerButton.Focus();
        }
        private void Answer2_CheckedChanged(object sender, EventArgs e)
        {
            if (FlagOurAnswer2 == false)
            {
                OurAnswer = 2;
                Answer1.Checked = false;
                Answer3.Checked = false;
                Answer4.Checked = false;
                FlagOurAnswer2 = true;
            }
            else
                FlagOurAnswer2 = false;
            AnswerButton.Enabled = true;
            AnswerButton.Focus();
        }
        private void Answer3_CheckedChanged(object sender, EventArgs e)
        {
            if (FlagOurAnswer3 == false)
            {
                OurAnswer = 3;
                Answer1.Checked = false;
                Answer2.Checked = false;
                Answer4.Checked = false;
                FlagOurAnswer3 = true;
            }
            else
                FlagOurAnswer3 = false;
            AnswerButton.Enabled = true;
            AnswerButton.Focus();
        }
        private void Answer4_CheckedChanged(object sender, EventArgs e)
        {
            if (FlagOurAnswer4 == false)
            {
                OurAnswer = 4;
                Answer1.Checked = false;
                Answer2.Checked = false;
                Answer3.Checked = false;
                FlagOurAnswer4 = true;
            }
            else
                FlagOurAnswer4 = false;
            AnswerButton.Enabled = true;
            AnswerButton.Focus();

        }
    }
}