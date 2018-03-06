using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Net;
using System.Globalization; 

namespace Ftp
{
    class Program
    {
        static void Main(string[] args)
        {
            FtpHelper ftp = new FtpHelper("地址", "默认根目录", "用户名", "密码");
            var list = ftp.GetAllList("");
            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
            ftp.Download("D:/","test1.txt");

        }

    }
}
