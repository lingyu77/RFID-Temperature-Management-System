using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TMS
{
    public class Global
    {
        public static int temp_up = 370; //體溫上限
        public static int temp_down = 300; //體溫下限

        public static int event_count = 0; //異常事件數
        public static string event_stu ; //異常事件學生
        public static string event_place; //異常事件地點

        public static Boolean BeepOn = true; //蜂鳴聲
        public static Boolean state_flag = false; //偵測狀態
        public static Boolean database = false; //資料庫連線狀況
        public static string no;

        public static void alarm_voice(Boolean BeepOn)
        {

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.SoundLocation = Directory.GetCurrentDirectory() + @"\music\alarm.wav";  //當前目錄路徑，任何地都可呼叫          

            if (BeepOn) sp.PlayLooping(); //循環播放
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
