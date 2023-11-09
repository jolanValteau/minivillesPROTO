using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minivillesPROTO
{
    internal class Paquet
    {
        private Carte[] cartes = new Carte[48];

        public static List<(int, int, string, string, string, int)> modelesCartes = new List<(int, int, string, string, string, int)>();

        public Carte this[int i]
        {
            get { return cartes[i]; }
            set { cartes[i] = value; }
        }

        public Paquet()
        {
            int indexPaquet = 0;
            foreach (var carteInfo in modelesCartes)
            {
                for (int i = 0; i < 6; i++)
                {
                    this.cartes[indexPaquet] = new Carte(carteInfo);
                    indexPaquet++;
                }
            }
        }

        public Carte GetRandomCard()
        {
            return this.cartes[new Random().Next(0, this.cartes.Length)];
        }

        public void Debug()
        {
            foreach (Carte carte in cartes)
            {
                Console.WriteLine(carte.ToString());
            }
        }
    }
}
