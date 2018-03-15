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
            Console.WriteLine("體重:");
            string weight =Console.ReadLine();
            Console.WriteLine("身高");
            string height = Console.ReadLine();
            double BMI;
            BMI = double.Parse(weight) / double.Parse(height) / double.Parse(height) * 10000;
            if (BMI > 31.5)
                Console.WriteLine("你免役");
            else
                Console.WriteLine("去當兵");
            Console.WriteLine("你的BMI是:{0}",BMI);
            Console.ReadLine();
        }
    }
}
