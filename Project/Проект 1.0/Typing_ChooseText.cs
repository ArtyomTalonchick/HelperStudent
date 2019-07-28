using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace OurProject._0
{
    public partial class Helper
    {
        //метод выбора текста для тренировки
        private void ChooseText(string fileName, bool isRussianAlphabet)
        {
            StreamReader CheckText = new StreamReader(fileName, Encoding.Default);
            stringOfText = CheckText.ReadLine();
            CheckText.Close();

            this.isRussianAlphabet = isRussianAlphabet;
            StartTyping();
        }

        //методы обработки событий (выбор текста)
        private void English1_Click(object sender, EventArgs e) => ChooseText(@"Text\English1.txt", false);
        private void English2_Click(object sender, EventArgs e) => ChooseText(@"Text\English2.txt", false);
        private void English3_Click(object sender, EventArgs e) => ChooseText(@"Text\English3.txt", false);
        private void English4_Click(object sender, EventArgs e) => ChooseText(@"Text\English4.txt", false);
        private void English5_Click(object sender, EventArgs e) => ChooseText(@"Text\English5.txt", false);
        private void English6_Click(object sender, EventArgs e) => ChooseText(@"Text\English6.txt", false);

        private void IKG1_Click(object sender, EventArgs e) => ChooseText(@"Text\IKG1.txt", true);
        private void IKG2_Click(object sender, EventArgs e) => ChooseText(@"Text\IKG2.txt", true);
        private void IKG3_Click(object sender, EventArgs e) => ChooseText(@"Text\IKG3.txt", true);
        private void IKG4_Click(object sender, EventArgs e) => ChooseText(@"Text\IKG4.txt", true);
        private void IKG5_Click(object sender, EventArgs e) => ChooseText(@"Text\IKG5.txt", true);
        private void IKG6_Click(object sender, EventArgs e) => ChooseText(@"Text\IKG6.txt", true);

        private void History1_Click(object sender, EventArgs e) => ChooseText(@"Text\History1.txt", true);
        private void History2_Click(object sender, EventArgs e) => ChooseText(@"Text\History2.txt", true);
        private void History3_Click(object sender, EventArgs e) => ChooseText(@"Text\History3.txt", true);
        private void History4_Click(object sender, EventArgs e) => ChooseText(@"Text\History4.txt", true);
        private void History5_Click(object sender, EventArgs e) => ChooseText(@"Text\History5.txt", true);
        private void History6_Click(object sender, EventArgs e) => ChooseText(@"Text\History6.txt", true);
        private void History7_Click(object sender, EventArgs e) => ChooseText(@"Text\History7.txt", true);
        private void History8_Click(object sender, EventArgs e) => ChooseText(@"Text\History8.txt", true);
        private void History9_Click(object sender, EventArgs e) => ChooseText(@"Text\History9.txt", true);
        private void History10_Click(object sender, EventArgs e) => ChooseText(@"Text\History10.txt", true);
        private void History11_Click(object sender, EventArgs e) => ChooseText(@"Text\History11.txt", true);
        private void History12_Click(object sender, EventArgs e) => ChooseText(@"Text\History12.txt", true);
        private void History13_Click(object sender, EventArgs e) => ChooseText(@"Text\History13.txt", true);
        private void History14_Click(object sender, EventArgs e) => ChooseText(@"Text\History14.txt", true);
        private void History15_Click(object sender, EventArgs e) => ChooseText(@"Text\History15.txt", true);

        private void Politology1_Click(object sender, EventArgs e) => ChooseText(@"Text\Politology1.txt", true);
        private void Politology2_Click(object sender, EventArgs e) => ChooseText(@"Text\Politology2.txt", true);
        private void Politology3_Click(object sender, EventArgs e) => ChooseText(@"Text\Politology3.txt", true);
        private void Politology4_Click(object sender, EventArgs e) => ChooseText(@"Text\Politology4.txt", true);
        private void Politology5_Click(object sender, EventArgs e) => ChooseText(@"Text\Politology5.txt", true);
        private void Politology6_Click(object sender, EventArgs e) => ChooseText(@"Text\Politology6.txt", true);
        private void Politology7_Click(object sender, EventArgs e) => ChooseText(@"Text\Politology7.txt", true);

        private void Philosophy1_Click(object sender, EventArgs e) => ChooseText(@"Text\Philosophy1.txt", true);
        private void Philosophy2_Click(object sender, EventArgs e) => ChooseText(@"Text\Philosophy2.txt", true);
        private void Philosophy3_Click(object sender, EventArgs e) => ChooseText(@"Text\Philosophy3.txt", true);
        private void Philosophy4_Click(object sender, EventArgs e) => ChooseText(@"Text\Philosophy4.txt", true);
        private void Philosophy5_Click(object sender, EventArgs e) => ChooseText(@"Text\Philosophy5.txt", true);
        private void Philosophy6_Click(object sender, EventArgs e) => ChooseText(@"Text\Philosophy6.txt", true);
        private void Philosophy7_Click(object sender, EventArgs e) => ChooseText(@"Text\Philosophy7.txt", true);

        private void MGiA1_Click(object sender, EventArgs e) => ChooseText(@"Text\MGiA1.txt", true);
        private void MGiA2_Click(object sender, EventArgs e) => ChooseText(@"Text\MGiA2.txt", true);
        private void MGiA3_Click(object sender, EventArgs e) => ChooseText(@"Text\MGiA3.txt", true);
        private void MGiA4_Click(object sender, EventArgs e) => ChooseText(@"Text\MGiA4.txt", true);

        private void MMA1_Click(object sender, EventArgs e) => ChooseText(@"Text\MMA1.txt", true);
        private void MMA2_Click(object sender, EventArgs e) => ChooseText(@"Text\MMA2.txt", true);
        private void MMA3_Click(object sender, EventArgs e) => ChooseText(@"Text\MMA3.txt", true);

        private void OAiP1_Click(object sender, EventArgs e) => ChooseText(@"Text\OAiP1.txt", true);

    }
}
