using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TMS
{
    public class Global
    {
        public static int temp_up = 370; //��ŤW��
        public static int temp_down = 300; //��ŤU��

        public static int event_count = 0; //���`�ƥ��
        public static string event_stu ; //���`�ƥ�ǥ�
        public static string event_place; //���`�ƥ�a�I

        public static Boolean BeepOn = true; //�����n
        public static Boolean state_flag = false; //�������A
        public static Boolean database = false; //��Ʈw�s�u���p
        public static string no;

        public static void alarm_voice(Boolean BeepOn)
        {

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.SoundLocation = Directory.GetCurrentDirectory() + @"\music\alarm.wav";  //��e�ؿ����|�A����a���i�I�s          

            if (BeepOn) sp.PlayLooping(); //�`������
            else sp.Stop();
        }
    }

    public class getData
    {
        public static string ID;
    }

    public class setReaderID
    {
        public static string reader_id;
    }

    public class setRange
    {
        public static string range;
    }
}
