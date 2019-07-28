using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OurProject._0
{ 
    public partial class Helper : Form
    {
        public Helper()
        {
            InitializeComponent();           
            keyboard.Show();
            keyboard.Visible = false;      
        }

        private void TypingButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 1;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 2;
        }

        private void MathLogicButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 4;
        }

        private void MGIAButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 5;
        }

        private void PolygonButton_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 6;
        }
        
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex != 1)
            {
                keyboard.Visible = false;
                armLeft.Visible = false;
                armRight.Visible = false;
            }
        }

    }
}