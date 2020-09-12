using System;
using System.IO.Pipes;

namespace Quan_BTL_LTHDH_Calculate.Controller
{
    class PipeManage
    {
        public static string ConnectToServer(string ClientName, string msgForData = "",string msg="")
        {
            using (var stream = new NamedPipeClientStream(ClientName))
            {
                stream.Connect();
                var buffer = new byte[1000];
                stream.Read(buffer, 0, 1000);
                string ret = GetString(buffer);
                Console.WriteLine(msgForData + ret);
                Console.WriteLine(msg);
                return ret;
            }
        }
        public static void CreateServer(string ServerName,string DataToSend,string msgBefore="",
            string msgAfter="")
        {
            Console.WriteLine(msgBefore);
            using (var s = new NamedPipeServerStream(ServerName, PipeDirection.InOut))
            {
                s.WaitForConnection();
                var data = GetBytes(DataToSend);
                s.Write(data, 0, data.Length);
            }
            Console.WriteLine(msgAfter);
        }
        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return (new string(chars)).Trim('\0');
        }
    }
}
