using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数を宣言し、値を設定する。
            double val1 = 3.14;
            int val2 = 123456;
            string val3 = "Hello";
            long val4 = 12345678901L;
            DateTime val5 = DateTime.Now;

            //定数を宣言し、値を設定する。
            const byte con1 = 5;

            //変数の値を表示する。
            Console.WriteLine("変数の値を表示します");
            Console.WriteLine(val1);
            Console.WriteLine(val2);
            Console.WriteLine(val3);
            Console.WriteLine(val4);
            Console.WriteLine(val5);

            //定数の値を表示する。
            Console.WriteLine("定数の値を表示します");
            Console.WriteLine(con1);

            System.Threading.Thread.Sleep(7000);
        }
    }


}
