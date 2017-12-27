using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TMS
{
    public partial class Form_setTemp : Form
    {
        public Form_setTemp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (temp_up.Text.Length > 2)
            {
                MessageBox.Show("放叫2计ず");
            }
            else
            {
                if (temp_down.Text.Length > 2)
                {
                    MessageBox.Show("放叫2计ず");
                }
                else
                {
                    if (up_point.Text.Length > 1 || down_point.Text.Length > 1)
                    {
                        MessageBox.Show("计翴1");
                    }
                    else
                    {
                        if (temp_up.Text.Length != 0 && up_point.Text.Length != 0)
                        {
                            string temp1 = temp_up.Text + up_point.Text;
                            Global.temp_up = Convert.ToInt32(temp1);
                        }
                        else if (temp_up.Text.Length != 0 && up_point.Text.Length == 0)
                        {
                            string temp1 = temp_up.Text + "0";
                            Global.temp_up = Convert.ToInt32(temp1);
                        }

                        if (temp_down.Text.Length != 0 && down_point.Text.Length != 0)
                        {
                            string temp2 = temp_down.Text + down_point.Text;
                            Global.temp_down = Convert.ToInt32(temp2);
                        }
                        else if (temp_down.Text.Length != 0 && down_point.Text.Length == 0)
                        {
                            string temp2 = temp_down.Text + "0";
                            Global.temp_down = Convert.ToInt32(temp2);
                        }
                        this.Close();
                    }
                }
            }
        }

        private void temp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}