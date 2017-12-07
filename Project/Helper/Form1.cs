using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper._0
{ 
    public partial class Helper : Form
    {
        private void Helper_Load(object sender, EventArgs e)
        {
        }
        public Helper()
        {
            InitializeComponent();           
                Keyboard.Show();
                Keyboard.Visible = false;
        }

        
    }

}

