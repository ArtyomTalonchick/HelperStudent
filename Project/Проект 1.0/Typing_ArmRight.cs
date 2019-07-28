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
    public partial class ArmRight : Form
    {
        private List<Image> armRight = new List<Image>();
        private int[] arrayOfMatchingSheets = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7,
            0, 0, 0, 0, 0, 8, 9, 10, 11, 12, 13, 13, 14, 14,
            0, 0, 0, 0, 0, 15, 0, 0, 0, 0, 0, 16, 16, 17, 17,
            0, 0, 0, 0, 0, 18, 19, 20, 20, 21, 21, 22, 22};

        //коснтруктор
        public ArmRight()
        {
            InitializeComponent();
            this.AllowTransparency = true;
            this.TransparencyKey = this.BackColor;
            this.Opacity = 0.7;
            this.ShowInTaskbar = false;
            InitializeListImage();
            this.BackgroundImage = armRight[15];
        }

        //метод создания списка armLeft
        private void InitializeListImage()
        {

            armRight.Add(Properties.Resources.ArmRight);  //0
            armRight.Add(Properties.Resources.ArmRight07);//1
            armRight.Add(Properties.Resources.ArmRight08);//2
            armRight.Add(Properties.Resources.ArmRight09);//3
            armRight.Add(Properties.Resources.ArmRight10);//4
            armRight.Add(Properties.Resources.ArmRight11);//5
            armRight.Add(Properties.Resources.ArmRight12);//6
            armRight.Add(Properties.Resources.ArmRight13);//7
            armRight.Add(Properties.Resources.ArmRight19);//8
            armRight.Add(Properties.Resources.ArmRight20);//9
            armRight.Add(Properties.Resources.ArmRight21);//10
            armRight.Add(Properties.Resources.ArmRight22);//11
            armRight.Add(Properties.Resources.ArmRight23);//12
            armRight.Add(Properties.Resources.ArmRight24);//13
            armRight.Add(Properties.Resources.ArmRight25);//14
            armRight.Add(Properties.Resources.ArmRight31);//15
            armRight.Add(Properties.Resources.ArmRight36);//16
            armRight.Add(Properties.Resources.ArmRight37);//17
            armRight.Add(Properties.Resources.ArmRight43);//18
            armRight.Add(Properties.Resources.ArmRight44);//19
            armRight.Add(Properties.Resources.ArmRight45);//20
            armRight.Add(Properties.Resources.ArmRight46);//21
            armRight.Add(Properties.Resources.ArmRight47);//22
            armRight.Add(Properties.Resources.ArmRightShift);//23
        }

        // Отображение рисунка правой руки
        public void ShowArm(int j, bool isShift)
        {
            if (isShift && arrayOfMatchingSheets[j] == 0 && (j < 46 || j > 50))
                this.BackgroundImage = armRight[23];
            else
                this.BackgroundImage = armRight[arrayOfMatchingSheets[j]];
        }
    }
}
