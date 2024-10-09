using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork_3
{
    internal class Task3_option8
    {
        static void Main(string[] args)
        {
            double sumaPrybutku, dokhody, vytraty;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть ваш дохід: ");
            dokhody = int.Parse(Console.ReadLine());
            Console.Write("Введіть ваші витрати: ");
            vytraty = int.Parse(Console.ReadLine());
            sumaPrybutku = dokhody - vytraty;
            Console.WriteLine($"При доході: {dokhody} грн. та при витраті: {vytraty} грн. Сума прибутку становитиме: {sumaPrybutku} грн.");
            Console.ReadKey();
        }
    }
}
