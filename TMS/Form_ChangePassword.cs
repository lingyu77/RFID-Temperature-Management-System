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
    public partial class Form_ChangePassword : Form
    {
        MySQLConnection DBConn;
        public Form_ChangePassword()
        {
            InitializeComponent();
            this.KeyPreview = true;
            DBConn = new MySQLConnection(new MySQLConnectionString("140.134.208.84", "RFID_Project", "root", "FCUIECS", 3306).AsString); //連資料庫 
        }

        private void bt_Sure_Click(object sender, EventArgs e)
        {
            if (Check())  
            {
                MessageBox.Show("更新成功");
                this.Close();
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region "檢查欄位"

        public bool Check()
        {
            DBConn.Open();
            MySQLCommand DBComm = new MySQLCommand("select * from `RFID_Project`.`user`", DBConn);
            MySQLCommand firstCmd = new MySQLCommand("set names big5", DBConn);
            firstCmd.ExecuteNonQuery();
            MySQLDataReader DBReader = DBComm.ExecuteReaderEx();
           
            DBReader.Read();

            do
            {
               string id = ("" + DBReader.GetValue(0));  //id 
               string passoord = ("" + DBReader.GetValue(1));  //password 

               if (tB_Id.Text == id)
               {
                   if (tB_OldPW.Text == passoord) // 檢查舊密碼
                   {
                       if (tB_NewPW.Text == tB_NewRPW.Text && tB_NewPW.Text != "" && tB_NewRPW.Text != "")  // 新密碼兩欄位是否相同 
                       {                         
                           //更新資料庫
                           MySQLCommand DBCom = new MySQLCommand("UPDATE `RFID_Project`.`user` SET `password` = '" + tB_NewPW.Text + "' WHERE CONVERT( `user`.`id` USING utf8 ) = '" + DBReader.GetString(0) + "' LIMIT 1 ;", DBConn);
                           MySQLDataReader DBReader1 = DBCom.ExecuteReaderEx();
                          
                           return true;
                       }
                   }
               }     
            }while (DBReader.Read());

            if (tB_NewPW.Text.Length <= 4)
            {
                MessageBox.Show("密碼長度需大於4個字元");
                return false;
            }
            else
            {
                MessageBox.Show("欄位有錯 ! 請再檢查一次");
            }
            return false;
        }
        #endregion

        #region "密碼安全強度"

        //參考網站 http://www.refly.net/passwordchecker/

        private void tB_NewPW_KeyDown(object sender, KeyEventArgs e)
        {
            int length = tB_NewPW.Text.Length;//抓密碼長度
            int score = 0, record = 0, result = 0, diff = 0;
            int rUpper = 0, rLower = 0, rSym = 0, rNum = 0;
            char[] c = new char[30];

            for (int i = 0; i < length; i++)  //取字元
            {
                string test;
                test = tB_NewPW.Text.Substring(i, 1);
                c[i] = System.Convert.ToChar(test);

                if (char.IsUpper(c[i])) rUpper++;           //大寫字母
                else if (char.IsLower(c[i])) rLower++;       //小寫字母
                else if (char.IsNumber(c[i]))                //數字
                {
                    rNum++;
                    if (length > 3 && i != (length - 1) && i != 0) record++;   //密碼中間部份出現數字
                    else if (length == 3 && i == 1) record++;
                }
                else
                {                                     //特殊符號                                                                       
                    rSym++;
                    if (length > 3 && i != (length - 1) && i != 0) record++;    //密碼中間部份出現符號
                    else if (length == 3 && i == 1) record++;
                }
            }

            if (rNum != 0) result++;
            if (rUpper != 0) result++;
            if (rLower != 0) result++;
            if (rSym != 0) result++;
            if (length >= 8 && result > 2) score += ((result + 1) * 2);   //達到最低需求

            score += (length * 4) + (rNum * 4) + (rSym * 6) + (record * 2);  //計算加分  
            if (rUpper != 0) score += ((length - rUpper) * 2);
            if (rLower != 0) score += ((length - rLower) * 2);
            if (rNum != 0 && rUpper == 0 && rLower == 0 && rSym == 0) //只有數字                         
            {
                score -= rNum;
            }
            else if ((rNum == 0 && rUpper != 0 && rLower == 0 && rSym == 0) || //只有大寫字母
                     (rNum == 0 && rUpper == 0 && rLower != 0 && rSym == 0) || //只有小寫字母
                     (rNum == 0 && rUpper != 0 && rLower != 0 && rSym == 0)) //只有字母
            {
                score -= (rUpper + rLower);
            }

            //大寫字母連續（例如AD）
            result = 0;
            for (int i = 0; i < length; i++)
            {
                if (i >= 1 && c[i] <= 90 && c[i] >= 65 && c[i - 1] <= 90 && c[i - 1] >= 65)
                {
                    result++;
                    if (i > 2 && (c[i] - c[i - 1]) == 1 && c[i - 1] - c[i - 2] == 1) diff++; //字母依順序出現 (三個以上，例如ABC）               
                }
            }

            score -= ((result * 2) + (diff * 3));

            //小寫字母連續（例如ae）
            result = 0;
            for (int i = 0; i < length; i++)
            {
                if (i >= 1 && c[i] <= 122 && c[i] >= 97 && c[i - 1] <= 122 && c[i - 1] >= 97)
                {
                    result++;
                    if (i > 2 && (c[i] - c[i - 1]) == 1 && c[i - 1] - c[i - 2] == 1) diff++; //字母依順序出現 (三個以上，例如abc）
                }
            }

            score -= ((result * 2) + (diff * 3));

            //數字依序出現（例如13）
            result = 0;
            for (int i = 0; i < length; i++)
            {
                if (i >= 1 && c[i] <= 57 && c[i] >= 48 && c[i - 1] <= 57 && c[i - 1] >= 48)
                {
                    result++;
                    if (i > 2 && (c[i] - c[i - 1]) == 1 && c[i - 1] - c[i - 2] == 1) diff++; //數字依順序出現 (三個以上，例如123）
                }
            }

            score -= (result * 2);

            //重複出現字元(忽略大小寫) 
            int[] repeat = new int[129];

            for (int i = 0; i < length; i++) if (char.IsLetter(c[i])) char.ToLower(c[i]);  //轉為小寫
            for (int i = 0; i < length; i++)             //檢查有無重複字元
                repeat[c[i]]++;
            result = 0;
            for (int i = 0; i <= 128; i++) if (repeat[i] > 1) result += repeat[i];
            score -= (result * (result - 1));

            if (score >= 80)
            {
                p4.BackColor = Color.Beige;                
            }
            else if (score >= 60)
            {
                p4.BackColor = Color.Bisque;
                p3.BackColor = Color.Chocolate;               
            }
            else if (score >= 40)
            {
                p4.BackColor = Color.Bisque;
                p3.BackColor = Color.Bisque;
                p2.BackColor = Color.Chocolate;
            }
            else if (score >= 20)
            {
                p4.BackColor = Color.Bisque;
                p3.BackColor = Color.Bisque;
                p2.BackColor = Color.Bisque;
                p1.BackColor = Color.Chocolate;
            }
            else
            {
                p4.BackColor = Color.Bisque;
                p3.BackColor = Color.Bisque;
                p2.BackColor = Color.Bisque;
                p1.BackColor = Color.Bisque;
            }
        }

        #endregion      
    }
}