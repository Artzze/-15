using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class bibl
    {
        public static void Sum(int chislo, int B)
        {
            int ProverkaKratnosti = 1, Proverka4 = 0, ProverkaB = 0;
            int[] MasChisla = new int[4];
            for (int i = 0; i < MasChisla.Length; i++)
            {
                MasChisla[i] = chislo % 10;
                chislo /= 10;
                ProverkaKratnosti *= MasChisla[i]; 
            }
            for (int i = 0; i < MasChisla.Length; i++)
            {
                if (MasChisla[i] == 4 && Proverka4 == 0)
                {
                    Console.WriteLine("Число имеет цифру 4");
                    Proverka4++;
                }
                if (MasChisla[i] == B && ProverkaB == 0)
                {
                    Console.WriteLine("Число имеет значение B");
                    ProverkaB++;
                }
            }
            if (ProverkaKratnosti % 4 == 0)
                Console.WriteLine("Число кратно 4");
            else
                Console.WriteLine("Число не кратно 4");
        }
    }
}
