using System;
using System.IO.Pipes;

namespace Quan_BTL_LTHDH_InOut.Controller
{
    class PipeManage
    {
        /// <summary>
        /// Kết nối với máy chủ
        /// </summary>
        /// <param name="ServerName"></param>
        /// <param name="msgForData"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static string ConnectToServer(string ServerName, string msgForData = "",string msg="")
        {
            using (var stream = new NamedPipeClientStream(ServerName))
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
        /// <summary>
        /// Tạo Máy Chủ
        /// </summary>
        /// <param name="ServerName"></param>
        /// <param name="DataToSend"></param>
        /// <param name="msgBefore"></param>
        /// <param name="msgAfter"></param>
        public static void CreateServer(string ServerName,string DataToSend,string msgBefore="",string msgAfter="")
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
