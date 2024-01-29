using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_frazione
{
    internal class Frazione
    {
        public Frazione(int numeratore, int denominatore)
        {
            Numeratore = numeratore;
            Denominatore = denominatore;
        }

        public int Numeratore { get; set; }
        public int Denominatore { get; set; }

        private static int MCD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public int MassimoComunDivisore(int  Numeratore, int Denominatore)
        {
            int mcd = Frazione.MCD(Numeratore, Denominatore);
            Numeratore = Numeratore / mcd;
            Denominatore = Denominatore / mcd;    
        }

        public override string ToString()
        {
            return $"{Numeratore}/{Denominatore}";
        }

        public static Frazione Parse(string s)
        {
            var parts = s.Split('/');
            return new Frazione(int.Parse(parts[0]), int.Parse(parts[1]));
        }

    }
}
