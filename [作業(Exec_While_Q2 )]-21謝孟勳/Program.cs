using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_While_Q2____21謝孟勳
{
    //使用 while , 在畫面顯示所有可以整除 300 的整數
    //例如: 1, 2, 3, 4, 5, 6, 10, ...., 300
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int number = 1;
            string answer = "";

            while (number <= input)
            {
                if (input % number == 0)
                {
                    answer = answer + number.ToString() + ",";
                }
                number++;
            }
            Console.WriteLine(answer);
        }
    }
}
