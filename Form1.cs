using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__First_Windows_Form_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My First Message", "Message",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
        }
    }
}
