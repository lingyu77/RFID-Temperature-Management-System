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
   
        public partial class Form_SearchT : Form
        {
            MySQLConnection DBConn = new MySQLConnection(new MySQLConnectionString("140.134.208.84", "RFID_Project", "root", "FCUIECS", 3306).AsString); //連資料庫;
 
            public Form_SearchT()
            {
                InitializeComponent(); 
                DBConn.Open();
            }

            private void bt_Search_Click(object sender, EventArgs e)
            {
 
                if (cB_condition.Text.Equals("Reader") && tB_find.Text != null) //reader
                {
                    MySQLCommand DBComm1 = new MySQLCommand("select * from `RFID_Project`.`reader`", DBConn);
                    MySQLCommand firstCmd = new MySQLCommand("set names big5", DBConn);
                    firstCmd.ExecuteNonQuery();
                    MySQLDataReader DBReader1 = DBComm1.ExecuteReaderEx();

                    while (DBReader1.Read())
                    {
                        if (tB_find.Text == DBReader1.GetString(0))//查單一個設備                           
                        {                       
                            tB_id.Text = DBReader1.GetString(0);
                            tB_buy_date.Text = DBReader1.GetString(2);
                            tB_buy_money.Text = DBReader1.GetString(3);
                            tB_manager.Text = DBReader1.GetString(4);
                            tB_type.Text = DBReader1.GetString(5);
                            tB_meno.Text = "架設地點:" + DBReader1.GetString(1);
                            break;
                        }                     
                    }
                 }

                 if (cB_condition.Text.Equals("Tag") && tB_find.Text != null) //tag
                 {
                    MySQLCommand DBComm = new MySQLCommand("select * from `RFID_Project`.`tag`", DBConn);
                    MySQLCommand firstCmd = new MySQLCommand("set names big5", DBConn);
                    firstCmd.ExecuteNonQuery();
                    MySQLDataReader DBReader = DBComm.ExecuteReaderEx();

                    while (DBReader.Read())
                    {
                        if (tB_find.Text == DBReader.GetString(0))//查單一個設備
                        {     
                                tB_id.Text = DBReader.GetString(0);
                                tB_buy_date.Text = DBReader.GetString(1);
                                tB_buy_money.Text = DBReader.GetString(2);
                                tB_manager.Text = DBReader.GetString(3);
                                tB_type.Text = DBReader.GetString(4);
                                tB_meno.Text = "目前所屬學生:" + DBReader.GetString(5);
                                break;
                        }                        
                    }
                }
            } 

        }
}