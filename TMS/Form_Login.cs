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
    public partial class Form_Login : Form
    {
        MySQLConnection DBConn;
        
        public Form_Login()
        {
            
            InitializeComponent();
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            DBConn = new MySQLConnection(new MySQLConnectionString("140.134.208.84", "RFID_Project", "root", "FCUIECS", 3306).AsString); //連資料庫 
        }

        private void bt_Sure_Click(object sender, EventArgs e)
        {
            CheckPassword();
        }
        
        private void Form_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) CheckPassword(); 
        }


        private void forget_pw_Click(object sender, EventArgs e)  //忘記密碼
        {
            //還沒寫
            MessageBox.Show("還沒寫!請自己想辦法");
        }

        

        public void CheckPassword() 
        {
            // 檢查帳密正確性
            // 權限設定還沒寫
            DBConn.Open();
            MySQLCommand DBComm = new MySQLCommand("select * from `RFID_Project`.`user`", DBConn);
            MySQLCommand firstCmd = new MySQLCommand("set names big5", DBConn);
            firstCmd.ExecuteNonQuery();
            MySQLDataReader DBReader = DBComm.ExecuteReaderEx();
            bool error = true;

            DBReader.Read();
            do
            {
                string id = ("" + DBReader.GetValue(0));  //id 
                string passoord = ("" + DBReader.GetValue(1));  //password                             

                string enter = System.DateTime.Now.ToString("yyyy/MM/dd/ HH:mm:ss");
                if (tB_Id.Text == id && tB_Password.Text == passoord)
                {
                    error = false;
                    MySQLCommand DBCom = new MySQLCommand("INSERT INTO `RFID_Project`.`login_record` (`date`,`id`,`result`)VALUES ('" + enter + "','" + tB_Id.Text + "','" + "success" + "');", DBConn); //登錄記錄
                    MySQLDataReader DBReader1 = DBCom.ExecuteReaderEx();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            } while (DBReader.Read());
            if (error) MessageBox.Show("登錄檔作業失敗!! " + "\r\n" + "帳號或密碼有錯!請再確認");
            DBConn.Close();       
        }
    }
}