using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto33CasosTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite=9;
            for (int i = 1; i <= 9; i++)
            {
                for (int x = 1; x <=limite; x++) {

                            Console.Write("*");
                        }
                limite = limite - 1;
                Console.WriteLine();
            }

           
            Console.ReadKey();
        }
    }
}
