using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form _frm;
        public Form2(Form frm)
        {
            _frm = frm;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1 objMain = (Form1)_frm;
            objMain.textBox1.Text = textBox2.Text;
        }
    }
}
