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
            string uj = "";

            for (int i = 0; i < szam + 1; i++)
            {
                for (int j = szam; j > 0; j--)
                {
                    uj+=(szo[szo.Length - j]);
                }
            }

            return uj;
        }
        static void Main(string[] args)
        {
            Console.Write("Adjon meg egy szót: ");
            string szo = Console.ReadLine();

            Console.Write("Adjon meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SokszorVege(szo, szam));

            Console.ReadKey();
        }
    }
}
