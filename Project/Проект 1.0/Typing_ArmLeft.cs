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
    public partial class ArmLeft : Form
    {
        private List<Image> armLeft = new List<Image>();
        private int[] arrayOfMatchingSheets = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            7, 8, 9, 10, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            13, 14, 15, 16, 17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        //конструктор
        public ArmLeft()
        {
            InitializeComponent();
            this.AllowTransparency = true;
            this.TransparencyKey = this.BackColor;
            this.Opacity = 0.7;
            this.ShowInTaskbar = false;
            InitializeListImage();
            this.BackgroundImage = armLeft[11];
        }

        //метод создания списка armLeft
        private void InitializeListImage()
        {
            armLeft.Add(Properties.Resources.ArmLeft);  //0//
            armLeft.Add(Properties.Resources.ArmLeft01);//1
            armLeft.Add(Properties.Resources.ArmLeft02);//2
            armLeft.Add(Properties.Resources.ArmLeft03);//3
            armLeft.Add(Properties.Resources.ArmLeft04);//4
            armLeft.Add(Properties.Resources.ArmLeft05);//5
            armLeft.Add(Properties.Resources.ArmLeft06);//6
            armLeft.Add(Properties.Resources.ArmLeft14);//7
            armLeft.Add(Properties.Resources.ArmLeft15);//8
            armLeft.Add(Properties.Resources.ArmLeft16);//9
            armLeft.Add(Properties.Resources.ArmLeft17);//10
            armLeft.Add(Properties.Resources.ArmLeft18);//11
            armLeft.Add(Properties.Resources.ArmLeft30);//12
            armLeft.Add(Properties.Resources.ArmLeft38);//13
            armLeft.Add(Properties.Resources.ArmLeft39);//14
            armLeft.Add(Properties.Resources.ArmLeft40);//15
            armLeft.Add(Properties.Resources.ArmLeft41);//16
            armLeft.Add(Properties.Resources.ArmLeft42);//17
            armLeft.Add(Properties.Resources.ArmLeftShift);//18
        }
        
        // Отображение рисунка левой руки
        public void ShowArm(int j, bool isShift)
        {
            if(isShift && arrayOfMatchingSheets[j]==0 && (j<40 || j>43))
                this.BackgroundImage = armLeft[18];
            else
                this.BackgroundImage = armLeft[arrayOfMatchingSheets[j]];
        }

    }
}
