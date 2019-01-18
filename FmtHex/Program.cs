using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FmtHex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入十六进制字符串，例如：68 0d 0d 68 87 00 00 19 01 18 16 22 16 64 05 00 00 70 16");
            Console.ForegroundColor = ConsoleColor.Blue;
            var s = Console.ReadLine();
            var arr = s.Split(' ');
            var sb = new StringBuilder();
            foreach(var item in arr)
            {
                if (item.Trim() == string.Empty) continue;
                sb.Append("0x" + item + ", ");
            }
            if (sb.Length > 2) sb.Length -= 2;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(sb.ToString());

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
