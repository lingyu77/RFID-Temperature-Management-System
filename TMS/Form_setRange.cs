using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TMS
{
    public partial class Form_setRange : Form
    {
        public Form_setRange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                setRange.range = Range.Text;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Range³]©w¿ù»~!");
            }
        }
    }
}