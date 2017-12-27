using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.IO.Ports;
using System.Net.Sockets;
using System.Threading;

namespace TMS
{
    public class ReaderConnect
    {
        public Int32 port;
        public TcpClient client;
        public NetworkStream stream;
        public string ip;
        public Boolean state = false; //±±¨î°»´úª¬ºA

        public ReaderConnect(string newip, Int32 newport)
        {
            this.ip = newip;
            this.port = newport;
            try
            {
                client = new TcpClient(this.ip, this.port);
                stream = client.GetStream();
            }
            catch (Exception e)
            {
                e.ToString();
            }

        }

        public void disconnect()
        {
            stream.Close();
            client.Close();
        }

        public void request(String message)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        public String response()
        {
            Byte[] data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            String responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            return responseData;
        }
    }
}
