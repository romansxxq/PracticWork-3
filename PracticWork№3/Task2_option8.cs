using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork_3
{
    internal class Task2_option8
    {
        static void Main(string[] args)
        {
            double t, v1, s,v2;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Вкажіть початковий відстань між пішоходами: ");
            s = int.Parse(Console.ReadLine());
            Console.Write("Вкажіть швидкість 1 пішохода: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Вкажіть швидкість 2 пішохода: ");
            v2 = int.Parse(Console.ReadLine());

            t = s / (v1+v2);
            Console.WriteLine($"Час руху між 1 пішоходом з відстаню {v1} та 2 пішоходом з відстаню {v2} дорівнює: {t}");
            Console.ReadKey();

        }
    }
}
