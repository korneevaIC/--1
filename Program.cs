using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Критерии_оценивания
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            string res = a >= 80 && a <= 100 ? "Отлично" : a >= 60 ? "Хорошо" :
                a >= 40 ? "Удовлетворительно" : "Неудовлетворительно";
            Console.WriteLine(res);
            Console.ReadLine();
        }
    } 
}
