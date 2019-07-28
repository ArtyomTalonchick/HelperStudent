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
    public partial class Typing_ResultStoryForm : Form
    {
        private string[] mass = new string[100];
        private string[] delete = new string[100];
        private bool isRussianLanguages = true;
        //конструктор
        public Typing_ResultStoryForm()
        {
            InitializeComponent();
            ResultStoryBox.Items.Clear();
            mass = File.ReadAllLines(@"ResultStoryRussia.txt");
            for (int i = 0; i < 100; i++)
            {
               ResultStoryBox.Items.Add(mass[i]);
            }
            for (int i = 0; i < 100; i++)
                delete[i] = "";
        }

        //метод оброботки события нажатия на кнопку "Закрыть" - возвращает пользователя из окна результатов в окно с тренажером
        private void CloseButtom_Click(object sender, EventArgs e)
        {
            ((Helper)(Application.OpenForms[1])).Enabled = true;
            ((Keyboard)(Application.OpenForms[0])).Enabled = true;
            this.Close();
        }

        //метод оброботки события нажатия на кнопку "Отчистить" - удаляет всё историю тренировок (английский и русский отдельно)
        private void ClearAllResult_Click(object sender, EventArgs e)
        {
            if (isRussianLanguages == true)
            {
                File.WriteAllText(@"ResultStoryRussiaIndex.txt", Convert.ToString(-1));
                File.WriteAllLines(@"ResultStoryRussia.txt", delete);
            }
            else
            {
                File.WriteAllText(@"ResultStoryEnglishIndex.txt", Convert.ToString(-1));
                File.WriteAllLines(@"ResultStoryEnglish.txt", delete);
            }

            ResultStoryBox.Items.Clear();
        }

        //метод оброботки события нажатия на кнопку "Язык" - меняет историю тренировок на английском и русском языках
        private void Languages_Click(object sender, EventArgs e)
        {
            ResultStoryBox.Items.Clear();
            isRussianLanguages = !isRussianLanguages;
            if (isRussianLanguages == true)
            {
                Languages.Text = "Английский";
                mass = File.ReadAllLines(@"ResultStoryRussia.txt");
                for (int i = 0; i < 100; i++)
                {
                    ResultStoryBox.Items.Add(mass[i]);
                }
            }   
            else
            {
                Languages.Text = "Русский";
                mass = File.ReadAllLines(@"ResultStoryEnglish.txt");
                for (int i = 0; i < 100; i++)
                {
                    ResultStoryBox.Items.Add(mass[i]);
                }
            }
        }
    }
}
