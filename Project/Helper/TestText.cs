using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper._0
{
    public partial class Helper
    {

        Random rand = new Random();
        private void QuestionEnglish1_Click(object sender, EventArgs e)
        {
            NumberAnswer = 0;
            NumberRigtAnswer = 0;

            bool OurFlag = false;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    OurFlag = false;
                    OrderQuestions[i] = rand.Next(0, 10);
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


            Answer[0, 0] = "1 Вилку в глаз или в жопу раз?";
            Answer[0, 1] = "Не знаю";
            Answer[0, 2] = "Знаю, но не скажу";
            Answer[0, 3] = "Моя твоя не понимать";
            Answer[0, 4] = "изи, изи, рил толк";
            RightAnswer[0] = 2;

            Answer[1, 0] = "2 дин раз не пидорас?";
            Answer[1, 1] = "Согласен";
            Answer[1, 2] = "Не согласен";
            Answer[1, 3] = "А ты один или не один?";
            Answer[1, 4] = "Пидоры!";
            RightAnswer[1] = 4;

            Answer[2, 0] = "3 илку в глаз или в жопу раз?";
            Answer[2, 1] = "Не знаю";
            Answer[2, 2] = "Знаю, но не скажу";
            Answer[2, 3] = "Моя твоя не понимать";
            Answer[2, 4] = "изи, изи, рил толк";
            RightAnswer[2] = 2;

            Answer[3, 0] = "4 дин раз не пидорас?";
            Answer[3, 1] = "Согласен";
            Answer[3, 2] = "Не согласен";
            Answer[3, 3] = "А ты один или не один?";
            Answer[3, 4] = "Пидоры!";
            RightAnswer[3] = 4;

            Answer[4, 0] = "5 илку в глаз или в жопу раз?";
            Answer[4, 1] = "Не знаю";
            Answer[4, 2] = "Знаю, но не скажу";
            Answer[4, 3] = "Моя твоя не понимать";
            Answer[4, 4] = "изи, изи, рил толк";
            RightAnswer[4] = 2;

            Answer[5, 0] = "6 дин раз не пидорас?";
            Answer[5, 1] = "Согласен";
            Answer[5, 2] = "Не согласен";
            Answer[5, 3] = "А ты один или не один?";
            Answer[5, 4] = "Пидоры!";
            RightAnswer[5] = 4;

            Answer[6, 0] = "7 илку в глаз или в жопу раз?";
            Answer[6, 1] = "Не знаю";
            Answer[6, 2] = "Знаю, но не скажу";
            Answer[6, 3] = "Моя твоя не понимать";
            Answer[6, 4] = "изи, изи, рил толк";
            RightAnswer[6] = 2;

            Answer[7, 0] = "8 Один раз не пидорас?";
            Answer[7, 1] = "Согласен";
            Answer[7, 2] = "Не согласен";
            Answer[7, 3] = "А ты один или не один?";
            Answer[7, 4] = "Пидоры!";
            RightAnswer[7] = 4;

            Answer[8, 0] = "9 Один раз не пидорас?";
            Answer[8, 1] = "Согласен";
            Answer[8, 2] = "Не согласен";
            Answer[8, 3] = "А ты один или не один?";
            Answer[8, 4] = "Пидоры!";
            RightAnswer[8] = 4;

            Answer[9, 0] = "10 Один раз не пидорас?";
            Answer[9, 1] = "Согласен";
            Answer[9, 2] = "Не согласен";
            Answer[9, 3] = "А ты один или не один?";
            Answer[9, 4] = "Пидоры!";
            RightAnswer[9] = 4;

            StartQuestion(OrderQuestions[0]);
        }
    }
}
