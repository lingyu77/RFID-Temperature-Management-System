using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TMS
{
    public partial class Form_setReaderID : Form
    {
        public Form_setReaderID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                setReaderID.reader_id = setID.Text;
                this.Close();
            }
            catch
            {
                MessageBox.Show("reader id ³]©w¿ù»~!");
            }
        }
    }
}