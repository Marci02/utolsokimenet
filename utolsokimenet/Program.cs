using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utolsokimenet
{
    class Program
    {
        static string SokszorVege(string szo, int szam)
        {
            foreach (var item in szo)
            {
                Console.Write(szo[szam]);
            } 

            
            

            
        }
        static void Main(string[] args)
        {
            Console.Write("Adjon meg egy szót: ");
            string szo = Console.ReadLine();

            Console.Write("Adjon meg egy számot: ");
            int szam = Int32.Parse(Console.ReadLine());

            Console.WriteLine(SokszorVege(szo, szam));

            Console.ReadKey();
        }
    }
}
