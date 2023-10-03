using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShunanovKE.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.ShunanovKE.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;
            int z = 2;
            Console.WriteLine("Переменные x, y и z равны: " + x + ", " + y + ", " + z);
            Console.WriteLine("Значение выражения (x + y + z) * 5 = " + DataService.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
