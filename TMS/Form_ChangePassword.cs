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
            DBConn = new MySQLConnection(new MySQLConnectionString("140.134.208.84", "RFID_Project", "root", "FCUIECS", 3306).AsString); //�s��Ʈw 
        }

        private void bt_Sure_Click(object sender, EventArgs e)
        {
            if (Check())  
            {
                MessageBox.Show("��s���\");
                this.Close();
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region "�ˬd���"

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
                   if (tB_OldPW.Text == passoord) // �ˬd�±K�X
                   {
                       if (tB_NewPW.Text == tB_NewRPW.Text && tB_NewPW.Text != "" && tB_NewRPW.Text != "")  // �s�K�X�����O�_�ۦP 
                       {                         
                           //��s��Ʈw
                           MySQLCommand DBCom = new MySQLCommand("UPDATE `RFID_Project`.`user` SET `password` = '" + tB_NewPW.Text + "' WHERE CONVERT( `user`.`id` USING utf8 ) = '" + DBReader.GetString(0) + "' LIMIT 1 ;", DBConn);
                           MySQLDataReader DBReader1 = DBCom.ExecuteReaderEx();
                          
                           return true;
                       }
                   }
               }     
            }while (DBReader.Read());

            if (tB_NewPW.Text.Length <= 4)
            {
                MessageBox.Show("�K�X���׻ݤj��4�Ӧr��");
                return false;
            }
            else
            {
                MessageBox.Show("��즳�� ! �ЦA�ˬd�@��");
            }
            return false;
        }
        #endregion

        #region "�K�X�w���j��"

        //�ѦҺ��� http://www.refly.net/passwordchecker/

        private void tB_NewPW_KeyDown(object sender, KeyEventArgs e)
        {
            int length = tB_NewPW.Text.Length;//��K�X����
            int score = 0, record = 0, result = 0, diff = 0;
            int rUpper = 0, rLower = 0, rSym = 0, rNum = 0;
            char[] c = new char[30];

            for (int i = 0; i < length; i++)  //���r��
            {
                string test;
                test = tB_NewPW.Text.Substring(i, 1);
                c[i] = System.Convert.ToChar(test);

                if (char.IsUpper(c[i])) rUpper++;           //�j�g�r��
                else if (char.IsLower(c[i])) rLower++;       //�p�g�r��
                else if (char.IsNumber(c[i]))                //�Ʀr
                {
                    rNum++;
                    if (length > 3 && i != (length - 1) && i != 0) record++;   //�K�X���������X�{�Ʀr
                    else if (length == 3 && i == 1) record++;
                }
                else
                {                                     //�S��Ÿ�                                                                       
                    rSym++;
                    if (length > 3 && i != (length - 1) && i != 0) record++;    //�K�X���������X�{�Ÿ�
                    else if (length == 3 && i == 1) record++;
                }
            }

            if (rNum != 0) result++;
            if (rUpper != 0) result++;
            if (rLower != 0) result++;
            if (rSym != 0) result++;
            if (length >= 8 && result > 2) score += ((result + 1) * 2);   //�F��̧C�ݨD

            score += (length * 4) + (rNum * 4) + (rSym * 6) + (record * 2);  //�p��[��  
            if (rUpper != 0) score += ((length - rUpper) * 2);
            if (rLower != 0) score += ((length - rLower) * 2);
            if (rNum != 0 && rUpper == 0 && rLower == 0 && rSym == 0) //�u���Ʀr                         
            {
                score -= rNum;
            }
            else if ((rNum == 0 && rUpper != 0 && rLower == 0 && rSym == 0) || //�u���j�g�r��
                     (rNum == 0 && rUpper == 0 && rLower != 0 && rSym == 0) || //�u���p�g�r��
                     (rNum == 0 && rUpper != 0 && rLower != 0 && rSym == 0)) //�u���r��
            {
                score -= (rUpper + rLower);
            }

            //�j�g�r���s��]�ҦpAD�^
            result = 0;
            for (int i = 0; i < length; i++)
            {
                if (i >= 1 && c[i] <= 90 && c[i] >= 65 && c[i - 1] <= 90 && c[i - 1] >= 65)
                {
                    result++;
                    if (i > 2 && (c[i] - c[i - 1]) == 1 && c[i - 1] - c[i - 2] == 1) diff++; //�r���̶��ǥX�{ (�T�ӥH�W�A�ҦpABC�^               
                }
            }

            score -= ((result * 2) + (diff * 3));

            //�p�g�r���s��]�Ҧpae�^
            result = 0;
            for (int i = 0; i < length; i++)
            {
                if (i >= 1 && c[i] <= 122 && c[i] >= 97 && c[i - 1] <= 122 && c[i - 1] >= 97)
                {
                    result++;
                    if (i > 2 && (c[i] - c[i - 1]) == 1 && c[i - 1] - c[i - 2] == 1) diff++; //�r���̶��ǥX�{ (�T�ӥH�W�A�Ҧpabc�^
                }
            }

            score -= ((result * 2) + (diff * 3));

            //�Ʀr�̧ǥX�{�]�Ҧp13�^
            result = 0;
            for (int i = 0; i < length; i++)
            {
                if (i >= 1 && c[i] <= 57 && c[i] >= 48 && c[i - 1] <= 57 && c[i - 1] >= 48)
                {
                    result++;
                    if (i > 2 && (c[i] - c[i - 1]) == 1 && c[i - 1] - c[i - 2] == 1) diff++; //�Ʀr�̶��ǥX�{ (�T�ӥH�W�A�Ҧp123�^
                }
            }

            score -= (result * 2);

            //���ƥX�{�r��(�����j�p�g) 
            int[] repeat = new int[129];

            for (int i = 0; i < length; i++) if (char.IsLetter(c[i])) char.ToLower(c[i]);  //�ର�p�g
            for (int i = 0; i < length; i++)             //�ˬd���L���Ʀr��
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