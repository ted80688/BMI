using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Beep(1000,20000);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔════════════════════════╗");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("║                   BMI計算機                    ║");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("╚════════════════════════╝");
            // 輸入           
            Console.Write("請輸入身高:");
            string height = Console.ReadLine();
            Console.Write("請輸入體重:");
            string weight = Console.ReadLine();
            // 計算   
            double BMI = double.Parse(weight) / ((double.Parse(height) / 100) * (double.Parse(height) / 100));
            // 輸出
            Console.WriteLine("你的BMI為:" + BMI);
            if (BMI > 31.5 || BMI < 16.5)
            {
                Console.WriteLine("╔════════════════════════╗");
                Console.WriteLine("║                                                ║");
                Console.WriteLine("║                這樣不用當兵呦<3                ║");
                Console.WriteLine("║                                                ║");
                Console.WriteLine("╚════════════════════════╝");
            }
            else
            {
                Console.WriteLine("╔════════════════════════╗");
                Console.WriteLine("║                                                ║");
                Console.WriteLine("║                還是乖乖當兵吧!                 ║");
                Console.WriteLine("║                                                ║");
                Console.WriteLine("╚════════════════════════╝");
            }
            // System.Threading.Thread.Sleep(1000);
            // double rate = 28.885;
            // double total = 20000;
            // Console.WriteLine("目前美金匯率:" + rate);
            // Console.WriteLine("請輸入金額:");
            // string input = Console.ReadLine();
            // Console.WriteLine(input + "台幣 = " + (double.Parse(input)/rate) + "美金");
            Console.ReadLine();
        }
    }
}
