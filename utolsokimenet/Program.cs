using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utolsokimenet
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Adjon meg egy szót: ");
            string szo = Console.ReadLine();

            Console.Write("Adjon meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < szam+1; i++)
            {
                for (int j = szam; j > 0; j--)
                {
                    Console.Write(szo[szo.Length-j]);
                }
            }


            Console.ReadKey();
        }
    }
}
