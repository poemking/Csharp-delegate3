using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinProj_delegate3
{
    public delegate string GetSecretIngredient(int amount);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Bruce 
        {
            public static string SecretMethod1(int amount) 
            {
                Console.WriteLine("Bruce's method " + amount);
                return "Down";
            }
            public static string SecretMethod2(int amount)
            {
                Console.WriteLine("Bruce's method " + (amount + 1));
                return "Down";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //單獨自己form.cs呼叫delegate
            //建立delegate實體並指向SecretMethod 兩個都可以
            //GetSecretIngredient MySecretMethod = new GetSecretIngredient(Bruce.SecretMethod1);
            GetSecretIngredient MySecretMethod = Bruce.SecretMethod1;
            MySecretMethod += Bruce.SecretMethod2;
            Console.WriteLine(MySecretMethod(5));
            /*Result
             Bruce's method 5
             Bruce's method 6
             Down
             */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassA a = new ClassA();
            a.DelegateObj = Class_Method;
            Console.WriteLine(a.DelegateObj("2"));
            
        }

        public int Class_Method(string Para) 
        {
            Console.WriteLine("call my creat delegate method " + Para);
            return 1;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            /*
             真正感受到delegate的厲害 
             * 用form1的按鈕開啟form2
             * 再利用form2.cs的按鈕來控制form1.cs的label1
             */
            Form2 My_form2 = new Form2();
            //委派與函式綁定
            //DelegateDemoObj.Invoke("Message from Form2")
            //內的傳參會傳到showmessage的方法內
            My_form2.DelegateDemoObj = showmessage;
            My_form2.Show();
        }
        public void showmessage(string aa)
        {
            label1.Text = aa;
        }
    }
}
