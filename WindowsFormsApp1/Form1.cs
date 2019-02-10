using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0
{
    public partial class Form1 : Form
    {
        //int random;
        //int number;

        public Form1()
        {
            InitializeComponent();
        }

        ///ランダム入力で、同じ数値が入力された場合に「エラー文」を表示する
        ///確率の問題なのか、テキストボックスごとにバラけた数字が出る…どうして？
        private void Tyuusen_button_Click_1(object sender, EventArgs e)
        {
            //一列に10個の数字が重複ナシで表示される
            Random ransu = new Random();
            int random = ransu.Next(1, 11);
            int[] number = new int[10];
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
                txt0_out.Text = number[i].ToString();

            }
            for (int i = 0; i < number.Length; i++)
            {
                txt2_out.Text = number[i].ToString();
                Console.ReadLine();
            }
        }

        //抽選ボタン押すと実行
        //private void Tyuusen_button_Click_1(object sender, EventArgs e)
        //{
        //    
        //    }

        //Random ransu = new Random();
        //int random = ransu.Next(1, 21);
        //int random1 = ransu.Next(1, 21);
        //int random2 = ransu.Next(1, 21);
        //int random3 = ransu.Next(1, 21);
        //int random4 = ransu.Next(1, 21);
        //int random5 = ransu.Next(1, 21);
        //int[] number = new int[20];
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
        //    txt0_out.Text = number[i].ToString();

        //}
        //for (int i = 0; i < number.Length; i++)
        //{
        //    txt2_out.Text = number[i].ToString();
        //    Console.ReadLine();
        //}


        private void txt0_out_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;

        }

        


        //TextBox[] txtArray = new TextBox[3];
        //txtArray[0] = txt0_out;

        //for(int i=0; i<3; i++)
        //{
        //    txtArray[i].Text;
        //}
    }
}

///ランダム入力で、同じ数値が入力された場合に「エラー文」を表示する
///確率の問題なのか、テキストボックスごとにバラけた数字が出る…どうして？
//private void Tyuusen_button_Click(object sender, EventArgs e)
//{
//    Random Computer = new Random();
//    txt0_out.Text = Computer.Next(1, 5).ToString();
//    txt1_out.Text = Computer.Next(1, 5).ToString();
//    txt2_out.Text = Computer.Next(1, 5).ToString();

//    if (txt0_out.Text == txt1_out.Text)
//    {
//       //MessageBox.Show("同じ数値です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
//　　　　 OKボタン押した後、テキストボックス1を空白にする
//    　 　txt1_out.Text = "";
//    }
//}

//一列に10個の数字が重複ナシで表示される
//Random ransu = new Random();
//int random = ransu.Next(1, 11);
//int[] number = new int[6];
//for (int i = 0; i < number.Length; i++)
//{
//    number[i] = i + 1;
//}
//for (int i = 0; i < number.Length; i++)
//{
//   tempで記憶する場所を確保している。
//    int temp = number[i];
//    number[i] = number[random];
//    number[random] = temp;
//}
//for (int i = 0; i < number.Length; i++)
//{
//    Console.Write(number[i] + " ");
//}

//int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int[] a2 = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int[] a3 = { 3, 4, 5, 6, 7, 8, 9, 10, 11 };

//for(int i=0; i<4; i++)
//{
//    Console.WriteLine("{0},{1},{2}", a1[i], a2[i], a3[i]);
//}

//Random Computer = new Random();
//txt0_out.Text = Computer.Next(1, 10).ToString();
//txt1_out.Text = Computer.Next(1, 10).ToString();
//txt2_out.Text = Computer.Next(1, 10).ToString();

//if (txt0_out.Text == txt1_out.Text)
//{
//    MessageBox.Show("同じ数値です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    //OKボタン押した後、テキストボックス1を空白にする
//    txt1_out.Text = "";
//}
