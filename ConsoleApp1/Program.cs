using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        

        //static string[] Yotei;

        static void Main(string[] args)
     {
            Random ransu = new Random();
            int random = ransu.Next(1, 21);
            int[] number = new int[random];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = i + 1;
            }
            for (int i = 0; i < number.Length; i++)
            {
                int temp = number[i];
                number[i] = number[random];
                number[random] = temp;
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.ReadLine();

            //   Random You = new Random();
            //  int PC = You.Next(1, 43);
            //   Console.WriteLine(PC);
            //   //     int[] ar1 = new int[4] { 0, 1, 2, 3 };
            //   //int[] ar2 = new int[] { 10, 11, 12, 13 };
            //   //int[] ar3 = { 20, 21, 2, 3 };
            //   //for(int i=0; i<4; i++ )
            //   {
            ////Console.WriteLine( "{0},{1},{2}", ar1[i], ar2[i], ar3[i] );

                  


            //Yotei = new string[11];
            //int hi;

            //Yotei[2] = "散歩に行く";
            //Yotei[3] = "映画を見る";
            //Yotei[5] = "ドライビング";
            //Yotei[8] = "梅田へ";
            //Yotei[9] = "コーヒーを飲む";

            //for (hi = 1; hi <= 10; hi = hi + 1)
            //{
            //    Console.WriteLine("{0}日:{1}", hi, Yotei[hi]);
            //}
            //Console.ReadLine();
        }
    }
}


//array1[2] =[0][2];


//for (int i = 0; i < array1.Length; i++)
//{
//    Console.WriteLine(array1[i]);
//}

//    int[] array3 = { 1, 3, 5, 6 };
//    for (int i = 0; i < array3.Length; i++)
//    {
//        Console.WriteLine(array3[i]);
//    }
//if (array1 == array3)
//{
//    Console.WriteLine(20);

//}


//int PC;
//Random You = new Random();
//PC = You.Next(1, 43);
//Console.WriteLine(PC);
//Console.ReadLine();

//PC = You.Next(1, 43);
//Console.WriteLine(PC);
//Console.ReadLine();

//PC = You.Next(1, 43);
//Console.WriteLine(PC);
//Console.ReadLine();

//PC = You.Next(1, 43);
//Console.WriteLine(PC);
//Console.ReadLine();




//static void Main(string[] args)
//{
//    int set;
//    Random You = new Random();
//    set = You.Next(1, 43);

//}
//Console.ReadLine();



//Random ransu = new Random();
//int random = ransu.Next(1, 11);
//int[] number = new int[10];
//for (int i = 0; i < number.Length; i++)
//{
//    number[i] = i + 1;
//}
//for (int i = 0; i < number.Length; i++)
//{
//    int temp = number[i];
//    number[i] = number[random];
//    number[random] = temp;
//}
//for (int i = 0; i < number.Length; i++)
//{
//    Console.Write(number[i] + " ");
//}
//Console.ReadLine();


//int[] array12 = { 1, 2, 3, 4, 5, 6 };
//for (int i = 0; i < array12.Length; i++)
//{
//    System.Console.WriteLine(array12[i]);
//}


//Console.ReadLine();