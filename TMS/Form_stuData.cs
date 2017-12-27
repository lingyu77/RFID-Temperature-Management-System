using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySQLDriverCS;

/*針對資料清單所設計的學生資料視窗*/
namespace TMS
{
    public partial class Form_stuData : Form
    {
        MySQLConnection DBConn;
        public Form_stuData()
        {
            InitializeComponent();
            DBConn = new MySQLConnection(new MySQLConnectionString("140.134.208.84", "RFID_Project", "root", "FCUIECS", 3306).AsString); //連資料庫
            Find();
        }

        public void Find()
        {
            DBConn.Open();
            MySQLCommand DBComm = new MySQLCommand("select * from `RFID_Project`.`student`", DBConn);            
            MySQLCommand firstCmd = new MySQLCommand("set names big5", DBConn);
            firstCmd.ExecuteNonQuery();
            MySQLDataReader DBReader = DBComm.ExecuteReaderEx();

            while (DBReader.Read())
            {               
                if (DBReader.GetString(0) == getData.ID)  //依學號判斷是哪個學生
                {
                    //抓學生資料
                    tB_id.Text = DBReader.GetString(0);
                    tB_name.Text = DBReader.GetString(2);
                    tB_sex.Text = DBReader.GetString(5);
                    tB_tagId.Text = DBReader.GetString(1);
                    tB_class.Text = DBReader.GetString(6);
                    tB_CWHO.Text = DBReader.GetString(8);
                    tB_CTEL.Text = DBReader.GetString(9);
                    tB_address.Text = DBReader.GetString(7);
                    pB_photo.ImageLocation = DBReader.GetString(4); //圖片

                    //抓老師資料
                    MySQLCommand DBComT = new MySQLCommand("select * from `RFID_Project`.`teacher`", DBConn);                  
                    MySQLDataReader DBReader_teacher = DBComT.ExecuteReaderEx();
                    DBReader_teacher.Read();
                    do
                    {
                        if (DBReader_teacher.GetString(2) == DBReader.GetString(6))
                        {
                            tB_teacher.Text = DBReader_teacher.GetString(1);
                            tB_tTEL.Text = DBReader_teacher.GetString(4);
                        }
                    } while (DBReader_teacher.Read());                            
                }
            }      
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}