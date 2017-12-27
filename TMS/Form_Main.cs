using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySQLDriverCS;

namespace TMS
{
    public partial class Form_Main : Form
    {
        MySQLConnection DBConn;

        public Form_Main()
        {
            InitializeComponent();

            //this.Load += new EventHandler(Form_Main_Load);

            DBConn = new MySQLConnection(new MySQLConnectionString("140.134.208.84", "RFID_Project", "root", "FCUIECS", 3306).AsString); //連資料庫  

            /*置入偵測體溫使用者控制項*/
            UserControl_Monitor monitor = new UserControl_Monitor();
            panel1.Controls.Clear();
            panel1.Controls.Add(monitor);

        }

        public void Form_Main_Load(object sender, EventArgs e)
        {
            Form_Login form_login = new Form_Login();
            form_login.ShowDialog();
            if (form_login.DialogResult == DialogResult.OK)
            {
                this.Visible = true;
            }
            else
            {
                this.Close();
            }
        }

        #region "系統功能"

        //登入系統
        /*
        private void TSMI_Login_Click(object sender, EventArgs e)
        {
            Form_Login F = new Form_Login();
            F.StartPosition = FormStartPosition.CenterScreen;
            F.Show();
            timer2.Enabled = true;
        }
        */
        //登出系統
        private void TSMI_Logout_Click(object sender, EventArgs e)
        {
            /*重新load*/
            this.Visible = false;
            Form_Main_Load(this, EventArgs.Empty);
        }

        //離開系統
        private void TSMI_ExitSystem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        //密碼變更
        private void TSMI_ChangePassword_Click(object sender, EventArgs e)
        {
            Form_ChangePassword FCP = new Form_ChangePassword();
            FCP.StartPosition = FormStartPosition.CenterScreen;
            FCP.Show();
        }

        #endregion


        #region "timer"

        private void timer1_Tick(object sender, EventArgs e) //顯示目前時間
        {
            tSSL_Now.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
            if (Global.state_flag == true)
            {
                tSSL_State.Text = "開啟";
            }
            else
            {
                tSSL_State.Text = "關閉";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)   //開啟功能
        {
            DBConn.Open();
            MySQLCommand DBComm = new MySQLCommand("select * from `RFID_Project`.`login_record`", DBConn);
            MySQLCommand firstCmd = new MySQLCommand("set names big5", DBConn);
            firstCmd.ExecuteNonQuery();
            MySQLDataReader DBReader = DBComm.ExecuteReaderEx();
            DBReader.Read();
            do
            {
                if (DBReader.GetString(2) == "success")
                {
                    MySQLCommand DBCom = new MySQLCommand("UPDATE `RFID_Project`.`login_record` SET `result` = 'login' WHERE CONVERT( `login_record`.`date` USING utf8 ) = '" + DBReader.GetString(0) + "' LIMIT 1 ;", DBConn);
                    MySQLDataReader DBReader1 = DBCom.ExecuteReaderEx();
                    timer2.Enabled = false;
                    break;
                }
            } while (DBReader.Read());
            DBConn.Close();
        }

        #endregion

        //關於體溫控管系統
        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_About FA = new Form_About();
            FA.StartPosition = FormStartPosition.CenterScreen;
            FA.Show();

        }

        private void 查詢硬體設備ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SearchT FST = new Form_SearchT();
            FST.StartPosition = FormStartPosition.CenterScreen;
            FST.Show();

        }
 
    }
}