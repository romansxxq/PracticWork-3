using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть суму для x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Введіть суму для y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Введіть суму для z: ");
            z = int.Parse(Console.ReadLine());

            double res = (y + Math.Cos(z))/(4*y+2*x*Math.Sqrt(x+2));
            Console.WriteLine("При x={0,10:F3}, y={1,5:N2}, z={2,7:N3}" +
                "значення виразу рівне {3,8:F4}", x,y,z,res);
            Console.ReadKey();
        }
    }
}
