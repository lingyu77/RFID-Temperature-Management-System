using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading; //�[�JSystem.Threading�R�W�Ŷ�
using MySQLDriverCS;

namespace TMS
{
    public partial class UserControl_Monitor : UserControl
    {
        public Int32 port;
        public TcpClient client;
        public NetworkStream stream;
        public Thread recThread; //�إ߱����ʥ]�������
        delegate void UpdateMessage(string msg);
        delegate void UpdateCount();
        delegate void UpdateDatagridview(string date, string time, string temp, string stu_id, string stu_name, string place, string stu_teacher);
        MySQLConnection DBConn;
        public string record;
        public int event_no;

        public UserControl_Monitor()
        {
            InitializeComponent();
            DBConn = new MySQLConnection(new MySQLConnectionString("140.134.208.84", "RFID_Project", "root", "FCUIECS", 3306).AsString); //�s��Ʈw
            DBConn.Open();
            Global.database = true;
            dataGridView1.AllowUserToAddRows = false;
            close.Enabled = false; //�@�}�l"����"�����s�O�������
            tSB_On.Enabled = false; //�@�}�l"�}�l����"�����s�O�������
            tSB_Off.Enabled = false; //�@�}�l"��������"�����s�O�������

            try
            {
                MySQLCommand DBComm = new MySQLCommand("select no from `RFID_Project`.`event_record` order by no desc", DBConn);
                MySQLDataReader DBReader = DBComm.ExecuteReaderEx();
                DBReader.Read();
                event_no = Convert.ToInt32(DBReader.GetValue(0)) + 1;
            }
            catch
            {
                event_no = 1;
            }
        }

        #region Reader connect
        ReaderConnect rA;
        ReaderConnect rB;
        ReaderConnect rC;
        Boolean rA_bt = false; //�s�u�O�_���}��
        Boolean rB_bt = false;
        Boolean rC_bt = false;
        Boolean rA_monitor = false; //�����O�_���}��
        Boolean rB_monitor = false;
        Boolean rC_monitor = false;
        private void open_Click(object sender, EventArgs e)
        {
            if (rA_bt == true || rB_bt == true || rC_bt == true) //�N��䤤�@��Reader���s�u��Ʈw�N�n�s�u
            {
                if (Global.database == false) DBConn.Open();
                timer1.Enabled = true;
            }

            string key = Reader_list.SelectedItem as string;

            if (key == "�����Q����")
            {
                rA = new ReaderConnect("140.134.208.81", 4000);
                this.Invoke(new UpdateMessage(printMessage), new object[] { "�����Q���� Reader �w�}" + "\x0d\x0a" });
                rA_bt = true; //reader A �s�u�w�}
                open.Enabled = false;
                close.Enabled = true;
                tSB_On.Enabled = true;
                tSB_Off.Enabled = false;
            }
            else if (key == "208�Ы�")
            {
                rB = new ReaderConnect("127.0.0.1", 4000);
                this.Invoke(new UpdateMessage(printMessage), new object[] { "208�Ы� Reader �w�}" + "\x0d\x0a" });
                rB_bt = true; //reader B �s�u�w�}
                open.Enabled = false;
                close.Enabled = true;
                tSB_On.Enabled = true;
                tSB_Off.Enabled = false;
            }
            else if (key == "������")
            {
                rC = new ReaderConnect("127.0.0.1", 3000);
                this.Invoke(new UpdateMessage(printMessage), new object[] { "������ Reader �w�}" + "\x0d\x0a" });
                rC_bt = true; //reader C �s�u�w�}
                open.Enabled = false;
                close.Enabled = true;
                tSB_On.Enabled = true;
                tSB_Off.Enabled = false;
            }
            else if (key == "����")
            {
                MessageBox.Show("�٨S��@");
            }
            else
                MessageBox.Show("�п��Reader!");
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (rA_bt == false && rB_bt == false && rC_bt == false) //�N�����Reader��������Ʈw�N�n�����s�u
            {
                if (Global.database == false) DBConn.Close();
            }

            string key = Reader_list.SelectedItem as string;

            if (key == "�����Q����")
            {
                rA.disconnect(); //�N�s�u����
                this.Invoke(new UpdateMessage(printMessage), new object[] { "�����Q���� Reader �w��" + "\x0d\x0a" });
                rA_bt = false; //reader A �s�u�w��
                open.Enabled = true;
                close.Enabled = false;
                tSB_On.Enabled = false;
                tSB_Off.Enabled = false;
            }
            else if (key == "208�Ы�")
            {
                rB.disconnect(); //�N�s�u����
                this.Invoke(new UpdateMessage(printMessage), new object[] { "208�Ы� Reader �w��" + "\x0d\x0a" });
                rB_bt = false; //reader B �s�u�w��
                open.Enabled = true;
                close.Enabled = false;
                tSB_On.Enabled = false;
                tSB_Off.Enabled = false;
            }
            else if (key == "������")
            {
                rC.disconnect();//�N�s�u����
                this.Invoke(new UpdateMessage(printMessage), new object[] { "������ Reader �w��" + "\x0d\x0a" });
                rC_bt = false; //reader C �s�u�w��
                open.Enabled = true;
                close.Enabled = false;
                tSB_On.Enabled = false;
                tSB_Off.Enabled = false;
            }
            else if (key == "����")
            {
                MessageBox.Show("�٨S��@");
            }
            else
                MessageBox.Show("�п��Reader!");
        }

        private void Reader_list_SelectedIndexChanged(object sender, EventArgs e) //����s�u�������s
        {
            string key = Reader_list.SelectedItem as string;

            if (key == "�����Q����")
            {
                if (rA_bt == false)
                {
                    open.Enabled = true;
                    close.Enabled = false;
                    tSB_On.Enabled = false;
                    tSB_Off.Enabled = false;
                }
                else
                {
                    open.Enabled = false;
                    close.Enabled = true;
                    tSB_On.Enabled = true;
                    tSB_Off.Enabled = false;
                }
                if (rA_bt == true && rA_monitor == false)
                {
                    tSB_On.Enabled = true;
                    tSB_Off.Enabled = false;
                }
                else if (rA_bt == true && rA_monitor == true)
                {
                    tSB_On.Enabled = false;
                    tSB_Off.Enabled = true;
                }
            }
            else if (key == "208�Ы�")
            {
                if (rB_bt == false)
                {
                    open.Enabled = true;
                    close.Enabled = false;
                    tSB_On.Enabled = false;
                    tSB_Off.Enabled = false;
                }
                else
                {
                    open.Enabled = false;
                    close.Enabled = true;
                    tSB_On.Enabled = true;
                    tSB_Off.Enabled = false;
                }
                if (rB_bt == true && rB_monitor == false)
                {
                    tSB_On.Enabled = true;
                    tSB_Off.Enabled = false;
                }
                else if (rB_bt == true && rB_monitor == true)
                {
                    tSB_On.Enabled = false;
                    tSB_Off.Enabled = true;
                }
            }
            else if (key == "������")
            {
                if (rC_bt == false)
                {
                    open.Enabled = true;
                    close.Enabled = false;
                    tSB_On.Enabled = false;
                    tSB_Off.Enabled = false;
                }
                else
                {
                    open.Enabled = false;
                    close.Enabled = true;
                    tSB_On.Enabled = true;
                    tSB_Off.Enabled = false;
                }
                if (rC_bt == true && rC_monitor == false)
                {
                    tSB_On.Enabled = true;
                    tSB_Off.Enabled = false;
                }
                else if (rC_bt == true && rC_monitor == true)
                {
                    tSB_On.Enabled = false;
                    tSB_Off.Enabled = true;
                }
            }
            else if (key == "����")
            {
                MessageBox.Show("�٨S��@");
            }
            else
                MessageBox.Show("�п��Reader!");
        }
        #endregion

        #region ToolStrip
        //�n�X�t��
        private void tSB_Logout_Click(object sender, EventArgs e)
        {
            /*���sload*/
            //this.Visible = false;
            //Form_Main_Load(this, EventArgs.Empty);        
        }

        //�}�Ұ����t��
        private void tSB_On_Click(object sender, EventArgs e)
        {
            /*
            Global.state_flag = true; //�N�D�e�����A�אּ�}��

            send_common(":START");
            printMessage("�}�l����");
            getMessage();


            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(receive));
             */
            
            if (rA_monitor == true || rB_monitor == true || rC_monitor == true)
            {
                Global.state_flag = true; //�N�D�e�����A�אּ�}��
            }
            
            string key = Reader_list.SelectedItem as string;

            if (key == "�����Q����")
            {
                rA_monitor = true;
                
                send_common(rA,":START");
                printMessage("�����Q���� Reader �}�l����");
                pB1.BackColor = Color.Green;  //���`
                getMessage(rA);

                ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(receive),rA);

                tSB_On.Enabled = false;
                tSB_Off.Enabled = true;
            }
            else if (key == "208�Ы�")
            {
                rB_monitor = true;

                send_common(rB, ":START");
                printMessage("208�Ы� Reader �}�l����");
                pB3.BackColor = Color.Green;
                getMessage(rB);

                ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(receive), rB);

                tSB_On.Enabled = false;
                tSB_Off.Enabled = true;
            }
            else if (key == "������")
            {
                rC_monitor = true;

                send_common(rC, ":START");
                printMessage("������ Reader �}�l����");
                pB10.BackColor = Color.Green;
                getMessage(rC);

                ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(receive), rC);

                tSB_On.Enabled = false;
                tSB_Off.Enabled = true;
            }
            else if (key == "����")
            {
                MessageBox.Show("�٨S��@");
            }
            else
                MessageBox.Show("�п��Reader!");
        }

        //���������t��
        private void tSB_Off_Click(object sender, EventArgs e)
        {/*
            Global.state_flag = false; //�N�D�e�����A�אּ����

            this.Invoke(new UpdateMessage(printMessage), new object[] { "��������" });
            send_common(":STOP");
            recThread = new Thread(new ThreadStart(getMessage)); //�إ߰����
            recThread.Abort();*/
            
            if (rA_monitor == false && rB_monitor == false && rC_monitor == false)
            {
                Global.state_flag = false; //�N�D�e�����A�אּ����
            }
            
            string key = Reader_list.SelectedItem as string;

            if (key == "�����Q����")
            {
                rA_monitor = false;

                this.Invoke(new UpdateMessage(printMessage), new object[] { "�����Q���� Reader ��������" });
                send_common(rA,":STOP");
                ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage),rA);
                pB1.BackColor = Color.Yellow;  

                tSB_On.Enabled = true;
                tSB_Off.Enabled = false;
            }
            else if (key == "208�Ы�")
            {
                rB_monitor = false;

                this.Invoke(new UpdateMessage(printMessage), new object[] { "208�Ы� Reader ��������" });
                send_common(rB, ":STOP");
                ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rB);
                pB3.BackColor = Color.Yellow;  

                tSB_On.Enabled = true;
                tSB_Off.Enabled = false;
            }
            else if (key == "������")
            {
                rC_monitor = false;

                this.Invoke(new UpdateMessage(printMessage), new object[] { "������ Reader ��������" });
                send_common(rC, ":STOP");
                ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rC);
                pB10.BackColor = Color.Yellow;  

                tSB_On.Enabled = true;
                tSB_Off.Enabled = false;
            }
            else if (key == "����")
            {
                MessageBox.Show("�٨S��@");
            }
            else
                MessageBox.Show("�п��Reader!");
        }

        //���}�t��
        private void tSB_ExitSystem_Click(object sender, EventArgs e)
        {
            //Form.Close();
        }

        //�����n����
        //BeepOn = true; //�����n
        private void tSB_Alarm_Click(object sender, EventArgs e)
        {

            if (Global.BeepOn)
            {
                tSB_Alarm.Image = Properties.Resources.NoirglossClose;
                Global.BeepOn = false;
            }
            else
            {
                tSB_Alarm.Image = Properties.Resources.Noirgloss;
                Global.BeepOn = true;
            }        
        }
        #endregion

        #region ��Ű���
        public void receive(object o)
        {
            ReaderConnect r = o as ReaderConnect;
            String recData;
            Boolean repeat = false;
            while (r.client.Connected)
            {
                if (r.stream.CanRead)
                {
                    try
                    {
                        Byte[] data = new Byte[256];
                        Int32 bytes = r.stream.Read(data, 0, data.Length);
                        if (!r.stream.DataAvailable)
                        {
                            recData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                            if (recData.Length == 23)
                            {
                                this.Invoke(new UpdateMessage(printMessage), new object[] { recData });
                                
                                //string test = "�ū�: " + recData.Substring(18,3);
                                //this.Invoke(new UpdateMessage(printMessage), new object[] { test });
                                //this.Invoke(new UpdateMessage(printMessage), new object[] { "temp_up: " + Global.temp_up + "   temp_down: " + Global.temp_down }); //test��ŤW�U��
                                if (Convert.ToInt32(recData.Substring(18, 3)) > Global.temp_up || Convert.ToInt32(recData.Substring(18, 3)) < Global.temp_down)
                                {
                                    
                                    Global.BeepOn = true;
                                    Global.alarm_voice(Global.BeepOn); //�����n
                                    switch (recData.Substring(1, 6)) //�P�_����a�I
                                    {
                                        case "000011":  //�����Q����
                                            pB1.BackColor = Color.Red;
                                            happen[0] = true;
                                            break;
                                        case "000022":  //208�Ы�
                                            pB3.BackColor = Color.Red;
                                            happen[1] = true;
                                            break;
                                        case "000033":  //������
                                            pB10.BackColor = Color.Red;
                                            happen[2] = true;
                                            break;
                                    }

                                    //Ū����Ʈw����� ��ǥ�
                                    MySQLCommand DBComm = new MySQLCommand("select * from `RFID_Project`.`student`", DBConn);
                                    MySQLCommand firstCmd = new MySQLCommand("set names big5", DBConn);
                                    firstCmd.ExecuteNonQuery();
                                    MySQLDataReader DBReader = DBComm.ExecuteReaderEx();
                                    DBReader.Read();
                                    do
                                    {
                                        string id = DBReader.GetValue(1).ToString();
                                        //this.Invoke(new UpdateMessage(printMessage), new object[] { "  id= " + id });
                                        //this.Invoke(new UpdateMessage(printMessage), new object[] { "  recData.Substring(9, 6)= " + recData.Substring(9, 6) });
                                        if (recData.Substring(9, 6) == id)
                                        {
                                            record = recData; //map�M�ΰT��

                                            //Ū����Ʈw����� ��a�I
                                            MySQLCommand DBComm_reader = new MySQLCommand("select * from `RFID_Project`.`reader`", DBConn);
                                            MySQLDataReader DBReader_reader = DBComm_reader.ExecuteReaderEx();
                                            DBReader_reader.Read();
                                            do
                                            {
                                                string reader_id = DBReader_reader.GetValue(0).ToString();
                                                if (recData.Substring(1, 6) == reader_id)
                                                {
                                                    string date = System.DateTime.Now.ToString("yyyy/MM/dd");
                                                    string time = System.DateTime.Now.ToString("HH:mm:ss");
                                                    string temp = recData.Substring(18, 2) + "." + recData.Substring(20, 1);
                                                    string teacher = "";

                                                    //��Ѯv���
                                                    MySQLCommand DBComT = new MySQLCommand("select * from `RFID_Project`.`teacher`", DBConn);
                                                    MySQLDataReader DBReader_teacher = DBComT.ExecuteReaderEx();
                                                    DBReader_teacher.Read();
                                                    do
                                                    {
                                                        if (DBReader_teacher.GetString(0) == DBReader.GetString(3))
                                                        {
                                                            teacher = DBReader_teacher.GetString(1);
                                                        }
                                                    } while (DBReader_teacher.Read());

                                                    //�P�_�ƥ�O�_����
                                                    try
                                                    {
                                                        MySQLCommand DBComRecord = new MySQLCommand("select * from `RFID_Project`.`event_record`", DBConn);
                                                        MySQLDataReader DBReader_Record = DBComRecord.ExecuteReaderEx();
                                                        DBReader_Record.Read();
                                                        do
                                                        {
                                                            MessageBox.Show(DBReader.GetString(0) + " / " + DBReader_Record.GetString(3));
                                                            if (date == DBReader_Record.GetString(1) && DBReader.GetString(0) == DBReader_Record.GetString(3) && DBReader_reader.GetString(1) == DBReader_Record.GetString(5))
                                                            {
                                                                repeat = true;
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                repeat = false;
                                                            }
                                                        } while (DBReader_Record.Read());
                                                    }
                                                    catch
                                                    {
                                                        repeat = false;
                                                    }

                                                    if (repeat == false)
                                                    {
                                                        this.Invoke(new UpdateDatagridview(printDatagridview), new object[] { date, time, temp, DBReader.GetValue(0), DBReader.GetValue(2), DBReader_reader.GetValue(1), teacher });
                                                        Global.event_count++;
                                                        this.Invoke(new UpdateCount(printCount), new object[] { });

                                                        //�O���ܸ�Ʈw. �n���B�z��.���G�~�|�令y
                                                        MySQLCommand DBComm_DB = new MySQLCommand("INSERT INTO `RFID_Project`.`event_record` (`no`,`date`,`time`,`stu_id`,`stu_name`,`place`,`temp`,`result`)VALUES ('" + event_no + "','" + date + "','" + time + "','" + DBReader.GetValue(0) + "','" + DBReader.GetValue(2) + "','" + DBReader_reader.GetValue(1) + "','" + recData.Substring(18, 3) + "','" + "n" + "');", DBConn); //�n���O��
                                                        MySQLDataReader DBReader_DB = DBComm_DB.ExecuteReaderEx();
                                                        event_no++;
                                                    }
                                                    Thread.Sleep(0);
                                                    break;
                                                }
                                            } while (DBReader_reader.Read());
                                        }
                                    } while (DBReader.Read());
                                }
                            }
                            else
                                this.Invoke(new UpdateMessage(printMessage), new object[] { recData });
                        }
                        else
                        {
                            Thread.Sleep(0);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        break;
                    }
                }
            }
        }

        /*��ܰT��*/
        private void printMessage(string msg)
        {
            this.state.Text += msg;
            this.state.SelectionStart = state.Text.Length;
            this.state.ScrollToCaret();
        }

        /*��ܲ��`�ƥ��*/
        private void printCount()
        {
            this.count.Text = Global.event_count.ToString();
        }

        /*��ܲ��`�ǥͲM��*/
        private void printDatagridview(string date, string time, string temp, string stu_id, string stu_name, string place, string stu_teacher)
        {
            
            this.dataGridView1.Rows.Add(date, time, place, temp, stu_id, stu_name, stu_teacher);
            //this.dataGridView1.FirstDisplayedScrollingRowIndex = this.dataGridView1.DisplayedRowCount(false);
        }

        /*�����T��*/
        public void getMessage(ReaderConnect reader)
        {
            string rec_data = reader.response();
            this.Invoke(new UpdateMessage(printMessage), new object[] { rec_data });
        }

        public void getMessage(object o)
        {
            ReaderConnect reader = o as ReaderConnect;
            string rec_data = reader.response();
            this.Invoke(new UpdateMessage(printMessage), new object[] { rec_data });
        }

        /*�e���O��reader*/
        public void send_common(ReaderConnect reader,string common)
        {
            String msg = common + "\x0d\x0a";
            reader.request(msg);
        }

        #endregion

        #region �t�δ���Ĳ�o�ƥ�
        private void set_temp_Click_1(object sender, EventArgs e)
        {
            Form_setTemp form_temp = new Form_setTemp();
            form_temp.Show();
        }

        private void reset_reader_Click(object sender, EventArgs e)
        {
            send_common(rA, ":RST MCU");
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rA);
        }

        private void reset_TCPIP_Click(object sender, EventArgs e)
        {
            send_common(rA, ":RST TCP");
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rA);
        }

        private void get_reader_Click(object sender, EventArgs e)
        {
            send_common(rA,":ID?");
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rA);
        }

        private void set_reader_Click(object sender, EventArgs e)
        {
            Form_setReaderID fs = new Form_setReaderID();
            fs.ShowDialog();
            string comm = ":ID " + setReaderID.reader_id;
            send_common(rA, comm);
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rA);
        }

        private void get_range_Click(object sender, EventArgs e)
        {
            send_common(rA, ":RSSI:RANG");
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rA);
        }

        private void set_range_Click(object sender, EventArgs e)
        {
            Form_setRange fr = new Form_setRange();
            fr.ShowDialog();
            string comm = ":RSSI:RANG " + setRange.range;
            send_common(rA, comm);
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rA);
        }

        private void start_RSSI_Click(object sender, EventArgs e)
        {
            send_common(rA, ":RSSI:START");
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rA);
        }

        private void stop_RSSI_Click(object sender, EventArgs e)
        {
            send_common(rA, ":RSSI:STOP");
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rA);
        }

        private void Reader_FW_Click_1(object sender, EventArgs e)
        {
            send_common(rA,":FW?");
            printMessage("Inquire Reader FW version ");
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rA);
        }

        private void Reader_Status_Click_1(object sender, EventArgs e)
        {
            send_common(rA,":CK?");
            printMessage("Check Reader Status ");
            ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(getMessage), rA);
        }
        #endregion

        #region ��ƪ��
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 7:
                    getData.ID = dataGridView1[4, e.RowIndex].Value.ToString();
                    Form_stuData FS = new Form_stuData();
                    FS.StartPosition = FormStartPosition.CenterScreen;
                    FS.ShowDialog();
                    break;

                case 8:
                    /*
                    MySQLCommand DBComm_change = new MySQLCommand("select * from `RFID_Project`.`event_record`", DBConn);
                    MySQLDataReader DBReader_change = DBComm_change.ExecuteReaderEx();
                    while (DBReader_change.Read())
                    {
                        if (DBReader_change.GetString(6) == "n")
                        {
                            //��s���`�ƥ󬰤w�B�z
                            MySQLCommand DBComm = new MySQLCommand("UPDATE `RFID_Project`.`event_record` SET `result` = 'y' WHERE CONVERT( `event_record`.`time` USING utf8 ) = '" + Time + "' LIMIT 1 ;", DBConn);
                            MySQLDataReader DBReader = DBComm.ExecuteReaderEx();
                        }
                    }
                    */
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    break;

                default:
                    break;
            }
        }
        #endregion

        /***************************�Ӫ~���j�u**************************/

        Boolean[] happen = new Boolean[3];

        private void timer1_Tick(object sender, EventArgs e)  //�����I�C���ഫ
        {
            
            //if���I������A�P�_���`�O�_�B�z��                                  
            int count = 0;

            for (int i = 0; i < 3; i++)   // �ثe�]3�x
            {
                if (happen[i] == true)  // ���I������
                {
                    switch (i) //�P�_����a�I
                    {
                        case 0:  //�����Q����
                            Global.event_place = "�����Q����";
                            break;
                        case 1:  //208�Ы�
                            Global.event_place = "208�Ы�";
                            break;
                        case 2:  //������
                            Global.event_place = "������";
                            break;
                    }

                    MySQLCommand DBComm1 = new MySQLCommand("select * from `RFID_Project`.`event_record`", DBConn);
                    MySQLDataReader DBReader1 = DBComm1.ExecuteReaderEx();
                    while (DBReader1.Read())
                    {
                        if (DBReader1.GetString(5) == Global.event_place && DBReader1.GetString(7) == "n") //���B�z
                        {
                            happen[i] = true;
                            break;
                        }
                        else
                        {
                            happen[i] = false;
                        }
                    }

                    //�Ӧa�I�ƥ�ҳB�z��.�ܦ^���
                    if (happen[i] == false)
                    {
                        switch (i) //�P�_����a�I
                        {
                            case 0:  //�����Q����
                               //Global.p1 = true;
                                pB1.BackColor = Color.Green;
                                break;
                            case 1:  //208�Ы�
                               // Global.p2 = true;
                                pB3.BackColor = Color.Green;
                                break;
                            case 2:  //������
                                //Global.p3 = true;
                                pB10.BackColor = Color.Green;
                                break;
                        }
                    }
                }
                if (happen[i] == false) count++;

            } //for

            if (count == 3 || Global.BeepOn == false)   //�������B�z��.��������n
            {
                Global.BeepOn = false;
                Global.alarm_voice(Global.BeepOn);
            }
            
        }
        

        private void pB10_Click(object sender, EventArgs e)  //������ =>000033
        {
            if (pB10.BackColor == Color.Red)
            {
                Global.event_place = "������";

                MySQLCommand DBComm = new MySQLCommand("select * from `RFID_Project`.`event_record`", DBConn);
                MySQLCommand firstCmd = new MySQLCommand("set names big5", DBConn);
                firstCmd.ExecuteNonQuery();
                MySQLDataReader DBReader = DBComm.ExecuteReaderEx();

                while (DBReader.Read())
                {
                    if (DBReader.GetString(5) == Global.event_place && DBReader.GetString(7) == "n")  //�̦�m�P�_���B�z�����`�ƥ�
                    {
                        Global.event_stu = DBReader.GetString(3);
                        Global.no = DBReader.GetString(0);
                        Form_Alarm FA = new Form_Alarm();  //��ܾǥ͸ԲӸ�Ƴ�
                        FA.StartPosition = FormStartPosition.CenterScreen;
                        FA.Show();
                    }
                }
            }

        }

        private void pB1_Click(object sender, EventArgs e)   //�����Q���� =>000011
        {
            if (pB1.BackColor == Color.Red)
            {
                Global.event_place = "�����Q����";

                MySQLCommand DBComm = new MySQLCommand("select * from `RFID_Project`.`event_record`", DBConn);
                MySQLCommand firstCmd = new MySQLCommand("set names big5", DBConn);
                firstCmd.ExecuteNonQuery();
                MySQLDataReader DBReader = DBComm.ExecuteReaderEx();

                while (DBReader.Read())
                {
                    if (DBReader.GetString(5) == Global.event_place && DBReader.GetString(7) == "n")  //�̦�m�P�_���B�z�����`�ƥ�
                    {
                        Global.event_stu = DBReader.GetString(3);
                        Global.no = DBReader.GetString(0);
                        Form_Alarm FA = new Form_Alarm();  //��ܾǥ͸ԲӸ�Ƴ�
                        FA.StartPosition = FormStartPosition.CenterScreen;
                        FA.Show();
                    }
                }
            }
        }

        private void pB3_Click(object sender, EventArgs e)   //208�Ы� =>000022
        {
            if (pB3.BackColor == Color.Red)
            {
                Global.event_place = "208�Ы�";

                MySQLCommand DBComm = new MySQLCommand("select * from `RFID_Project`.`event_record`", DBConn);
                MySQLCommand firstCmd = new MySQLCommand("set names big5", DBConn);
                firstCmd.ExecuteNonQuery();
                MySQLDataReader DBReader = DBComm.ExecuteReaderEx();

                while (DBReader.Read())
                {
                    if (DBReader.GetString(5) == Global.event_place && DBReader.GetString(7) == "n")  //�̦�m�P�_���B�z�����`�ƥ�
                    {
                        Global.event_stu = DBReader.GetString(3);
                        Global.no = DBReader.GetString(0);
                        Form_Alarm FA = new Form_Alarm();  //��ܾǥ͸ԲӸ�Ƴ�
                        FA.StartPosition = FormStartPosition.CenterScreen;
                        FA.Show();
                    }
                }
            }

        }

    }

   
}