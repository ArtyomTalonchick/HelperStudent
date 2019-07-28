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
        private const int numberOfQuestions = 8;
        private string[] questions = new string[50];
        private int[] rightAnswer = new int[numberOfQuestions];
        private int[] orderOfQuestions = new int[numberOfQuestions];
        private int numberOfUserAnswer = 0;
        private int numberOfQuestion = 0;
        private int numberOfRightAnswers = 0;
        private bool IsAnswerOnQuestion = false;
        private bool[] isAnswerChoose = new bool[4];
        private List<CheckBox> listOfAnswers = new List<CheckBox>();
       
        // Метод, предназначенный для инициализации списка CheckBox
        public void InitializeListOfAnswerCheckBox()
        {
            listOfAnswers.Add(Answer1);
            listOfAnswers.Add(Answer2);
            listOfAnswers.Add(Answer3);
            listOfAnswers.Add(Answer4);
        }
             
        // Метод, который рандомит порядок вопросов
        public void RandomOrderOfQuestion()
        {
            numberOfQuestion = 0;
            numberOfRightAnswers = 0;
            bool isQuestionDoesNotFit = false;
            Random rand = new Random();
            for (int i = 0; i < numberOfQuestions; i++)
            {
                do
                {
                    isQuestionDoesNotFit = false;

                    orderOfQuestions[i] = rand.Next(numberOfQuestions);
                    for (int j = 0; j < i; j++)
                    {
                        if (orderOfQuestions[i] == orderOfQuestions[j])
                            isQuestionDoesNotFit = true;
                    }
                } while (isQuestionDoesNotFit == true);
            }
        }

        // Метод, отображающий вопрос
        public void StartQuestion(int i)
        {
            NumberQuestionText.Text = (numberOfQuestion  + 1).ToString() + '.';                             // Отображение номера вопроса

            if (numberOfQuestion == 1)
                FinishButton.Enabled = true;
            QuestionText.Text = questions[5 * i];                                                           // Отображение вопроса
            Answer1.Text = questions[5 * i + 1];
            Answer2.Text = questions[5 * i + 2];                                                            // Отображение вариантов ответа
            Answer3.Text = questions[5 * i + 3];
            Answer4.Text = questions[5 * i + 4];
            Answer1.BackColor = Color.Transparent;
            Answer2.BackColor = Color.Transparent;                                                       
            Answer3.BackColor = Color.Transparent;
            Answer4.BackColor = Color.Transparent;
            Answer1.Checked = false;
            Answer2.Checked = false;
            Answer3.Checked = false;                                                                        // Ни один вариант ответа не выбран
            Answer4.Checked = false;
            Answer1.Enabled = true;
            Answer2.Enabled = true;
            Answer3.Enabled = true;                                                                         // Доступ к выбору вариантам ответа
            Answer4.Enabled = true;
            AnswerButton.Text = "Ок";
            MarkLabel.Text = "";
            TestSelectMenuStrip.Enabled = false;
        }
        
        // Метод, вызывающийся при выборе ответа
        public void ChooseAnswer(ref bool isAnswerChoose, int numberOfUserAnswer, params CheckBox[] Answer)
        {
            if (isAnswerChoose == false)                                                                    // Если этот вариант ответа не выбран                    
            {
                this.numberOfUserAnswer = numberOfUserAnswer;
                Answer[0].Checked = false;
                Answer[1].Checked = false;
                Answer[2].Checked = false;
                isAnswerChoose = true;                                                                      // Он помечается как выбранный
                AnswerButton.Enabled = true;
                AnswerButton.Focus();
            }
            else
            {
                isAnswerChoose = false;                                                                     // Иначе, он помечается как невыбранный
                AnswerButton.Enabled = false;
            }
        }
        
        // Метод, заканчивающий тест
        public void FinishTest()
        {
            Test_ResultForm test_ResultForm = new Test_ResultForm(numberOfQuestion, numberOfRightAnswers);       // Отображение результатов теста
            test_ResultForm.Show();
            this.Enabled = false;

            Answer1.BackColor = Color.Transparent;
            Answer2.BackColor = Color.Transparent;
            Answer3.BackColor = Color.Transparent;
            Answer4.BackColor = Color.Transparent;
            Answer1.Checked = false;
            Answer2.Checked = false;                                                                        // Ни один вариант ответа не выбран    
            Answer3.Checked = false;
            Answer4.Checked = false;
            Answer1.Enabled = false;
            Answer2.Enabled = false;
            Answer3.Enabled = false;                                                                        // Закрыть доступ к выбору вариантам ответа
            Answer4.Enabled = false;
            AnswerButton.Enabled = false;
            FinishButton.Enabled = false;
            TestSelectMenuStrip.Enabled = true;

            Answer1.Text = "Answer1";
            Answer2.Text = "Answer2";
            Answer3.Text = "Answer3";
            Answer4.Text = "Answer4";
            QuestionText.Text = "Ну чё, порёшаем тестики!?";                                                // Возвращение к начальному виду окна
            NumberOfIncorrectAnswerLabel.Text = "0";
            NumberOfRightAnswersLabel.Text = "0";
            AnswerButton.Text = "Ок";
            MarkLabel.Text = "";
            NumberQuestionText.Text = "0.";

            numberOfQuestion = 0;
            numberOfRightAnswers = 0;
        }

        // Метод, вызывающийся при нажатии на кнопку при ответе на вопрос
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            if (IsAnswerOnQuestion == true)                                                                 // Проверка на то что: последовал ли ответ на вопрос
            {
                if (numberOfQuestion < numberOfQuestions)
                    StartQuestion(orderOfQuestions[numberOfQuestion]);
                else
                    FinishTest();                                                                           
                AnswerButton.Enabled = false;
                IsAnswerOnQuestion = false;
            }
            else
            {
                foreach (var checkBox in listOfAnswers)
                    checkBox.Enabled = false;
                if (numberOfUserAnswer == rightAnswer[orderOfQuestions[numberOfQuestion]])
                {
                    numberOfRightAnswers++;
                    MarkLabel.ForeColor = Color.LimeGreen;                                                  // Если пользователь ответил верно
                    MarkLabel.Text = "Правильно!";
                }
                else
                {
                    MarkLabel.ForeColor = Color.Firebrick;
                    MarkLabel.Text = "Ошибка!!!";                                                           // Если пользователь ответил неверно
                    listOfAnswers[numberOfUserAnswer - 1].BackColor = Color.Firebrick;                    
                }
                listOfAnswers[rightAnswer[orderOfQuestions[numberOfQuestion]] - 1].BackColor = Color.LimeGreen;     // Отображение правильного ответа
                foreach (var checkBox in listOfAnswers)
                    checkBox.Checked = false;
                
                AnswerButton.Text = "Далее";
                IsAnswerOnQuestion = true;
                numberOfQuestion++;

                AnswerButton.Enabled = true;
                AnswerButton.Focus();
            }            
            NumberOfRightAnswersLabel.Text = (numberOfRightAnswers).ToString();
            NumberOfIncorrectAnswerLabel.Text = (numberOfQuestion - numberOfRightAnswers).ToString();
            NumberOfRightAnswersLabel.ForeColor = Color.Lime;
            NumberOfIncorrectAnswerLabel.ForeColor = Color.Red;
        }

        // Кнопка, обрабатывающая конец теста
        private void FinishButton_Click(object sender, EventArgs e) => FinishTest();
        private void Answer1_CheckedChanged(object sender, EventArgs e) => ChooseAnswer(ref isAnswerChoose[0], 1, Answer2, Answer3, Answer4);
        private void Answer2_CheckedChanged(object sender, EventArgs e) => ChooseAnswer(ref isAnswerChoose[1], 2, Answer1, Answer3, Answer4);
        private void Answer3_CheckedChanged(object sender, EventArgs e) => ChooseAnswer(ref isAnswerChoose[2], 3, Answer1, Answer2, Answer4);
        private void Answer4_CheckedChanged(object sender, EventArgs e) => ChooseAnswer(ref isAnswerChoose[3], 4, Answer1, Answer2, Answer3);
    }
}