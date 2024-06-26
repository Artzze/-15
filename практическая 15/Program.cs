using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace практическая_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
            bool f = int.TryParse(Console.ReadLine(), out int chislo);
                if (chislo >= 1000 && chislo <= 9999 && f)
                {
                    Console.WriteLine("Введите B");
                    int B = Convert.ToInt32(Console.ReadLine());
                    bibl.Sum(chislo, B);
                    Console.ReadKey();
                }
            else
              Console.WriteLine("Необходимо ввести четырехзначное число");
            Console.ReadKey();
        }
    }
}
