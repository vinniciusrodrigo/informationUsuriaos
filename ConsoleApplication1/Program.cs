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
            int[] valores = new int[10];
            Console.WriteLine("Digite 10 valores:");
            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(Console.ReadLine());
                valores[i] = a; 
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
}
