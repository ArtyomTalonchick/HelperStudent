using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OurProject._0
{
    public partial class Helper
    { 
        // Метод, который отвечает за чтение вопросов и ответов из файла
        public void ChooseQuestions(string questionFileName, string answerFileName)
        {
            RandomOrderOfQuestion();
            questions = File.ReadAllLines(questionFileName, Encoding.Default);                              // Чтение вопросов из файлов
            string[] tempString = File.ReadAllLines(answerFileName, Encoding.Default);                      // Чтение ответов на вопросы из файла
            for (int i = 0; i < numberOfQuestions; i++)
                rightAnswer[i] = Convert.ToInt32(tempString[i]);                                            // Перевод ответов на вопросы в целые числа
            numberOfQuestion = 0;
            StartQuestion(orderOfQuestions[0]);
        }

        private void QuestionEnglish1_Click(object sender, EventArgs e) => ChooseQuestions(@"Test\Question\QuestionEnglish1.txt", @"Test\Answer\AnswerEnglish1.txt");      

        private void QuestionHistory1_Click(object sender, EventArgs e) => ChooseQuestions(@"Test\Question\QuestionHistory1.txt", @"Test\Answer\AnswerHistory1.txt");      
        private void QuestionHistory2_Click(object sender, EventArgs e) => ChooseQuestions(@"Test\Question\QuestionHistory2.txt", @"Test\Answer\AnswerHistory2.txt");      
        private void QuestionHistory3_Click(object sender, EventArgs e) => ChooseQuestions(@"Test\Question\QuestionHistory3.txt", @"Test\Answer\AnswerHistory3.txt");      
        private void QuestionHistory4_Click(object sender, EventArgs e) => ChooseQuestions(@"Test\Question\QuestionHistory4.txt", @"Test\Answer\AnswerHistory4.txt");     
        private void QuestionHistory5_Click(object sender, EventArgs e) => ChooseQuestions(@"Test\Question\QuestionHistory5.txt", @"Test\Answer\AnswerHistory5.txt");      
        private void QuestionHistory6_Click(object sender, EventArgs e) => ChooseQuestions(@"Test\Question\QuestionHistory6.txt", @"Test\Answer\AnswerHistory6.txt");           
        private void QuestionHistory7_Click(object sender, EventArgs e) => ChooseQuestions(@"Test\Question\QuestionHistory7.txt", @"Test\Answer\AnswerHistory7.txt");
      
        private void QuestionMGiA1_Click(object sender, EventArgs e) => ChooseQuestions(@"Test\Question\QuestionMGiA1.txt", @"Test\Answer\AnswerMGiA1.txt");   
        private void QuestionMGiA2_Click(object sender, EventArgs e) => ChooseQuestions(@"Test\Question\QuestionMGiA2.txt", @"Test\Answer\AnswerMGiA2.txt");
      
        private void QuestionMMA1_Click(object sender, EventArgs e) => ChooseQuestions(@"Test\Question\QuestionMMA1.txt", @"Test\Answer\AnswerMMA1.txt");      
    }
}
