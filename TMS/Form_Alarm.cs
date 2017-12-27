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
    public partial class Form_Alarm : Form
    {
        MySQLConnection DBConn;
        string Time;
        public Form_Alarm()
        {
            InitializeComponent();
            DBConn = new MySQLConnection(new MySQLConnectionString("140.134.208.84", "RFID_Project", "root", "FCUIECS", 3306).AsString); //連資料庫
            Find();
        }

        public void Find()
        {
            //在異常事件記錄抓未處理資料出來
            DBConn.Open();
            MySQLCommand DBComm = new MySQLCommand("select * from `RFID_Project`.`event_record`", DBConn);
            MySQLCommand firstCmd = new MySQLCommand("set names big5", DBConn);
            firstCmd.ExecuteNonQuery();
            MySQLDataReader DBReader = DBComm.ExecuteReaderEx();

            while (DBReader.Read())
            {
                if (DBReader.GetString(5) == Global.event_place && DBReader.GetString(3) == Global.event_stu && DBReader.GetString(7) == "n")  //依位置判斷未處理的異常事件
                {
                    tB_place.Text = DBReader.GetString(5);
                    tB_temp.Text = DBReader.GetString(6);
                    tB_date.Text = DBReader.GetString(1);
                    tB_time.Text = DBReader.GetString(2);

                    Time = DBReader.GetString(2);
                    //抓學生資料
                    string stu_id = DBReader.GetString(3);
                    MySQLCommand DBCom = new MySQLCommand("select * from `RFID_Project`.`student`", DBConn);
                    MySQLDataReader DBReader_stu = DBCom.ExecuteReaderEx();
                    DBReader_stu.Read();
                    do
                    {
                        if (DBReader_stu.GetString(0) == stu_id)
                        {
                            tB_id.Text = DBReader_stu.GetString(0);
                            tB_name.Text = DBReader_stu.GetString(2);
                            tB_sex.Text = DBReader_stu.GetString(5);
                            tB_tagId.Text = DBReader_stu.GetString(1);
                            tB_class.Text = DBReader_stu.GetString(6);
                            tB_CWHO.Text = DBReader_stu.GetString(8);
                            tB_CTEL.Text = DBReader_stu.GetString(9);
                            tB_address.Text = DBReader_stu.GetString(7);
                            pB_photo.ImageLocation = DBReader_stu.GetString(4); //圖片

                            //抓老師資料
                            MySQLCommand DBComT = new MySQLCommand("select * from `RFID_Project`.`teacher`", DBConn);
                            MySQLDataReader DBReader_teacher = DBComT.ExecuteReaderEx();
                            DBReader_teacher.Read();
                            do
                            {
                                if (DBReader_teacher.GetString(2) == DBReader_stu.GetString(6))
                                {
                                    tB_teacher.Text = DBReader_teacher.GetString(1);
                                    tB_tTEL.Text = DBReader_teacher.GetString(4);
                                }
                            } while (DBReader_teacher.Read());

                        }
                    } while (DBReader_stu.Read());
                    break;
                }
            }                                                 
        }

        private void button1_Click(object sender, EventArgs e)   //處理鍵
        {
            //更新異常事件為已處理
            MySQLCommand DBComm = new MySQLCommand("UPDATE `RFID_Project`.`event_record` SET `result` = 'y' WHERE CONVERT( `event_record`.`no` USING utf8 ) = '" + Global.no + "' LIMIT 1 ;", DBConn);
            MySQLDataReader DBReader = DBComm.ExecuteReaderEx();
        
            //關閉視窗  
            this.Close();
        }
    }
}