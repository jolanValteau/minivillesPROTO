using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minivillesPROTO
{
    internal class Paquet : IHasAPaquet
    {
        private List<Carte> _cards = new();

        public static List<(int, int, string, string, string, int, int, int)> templatesCards = new();

        public Carte this[int i]
        {
            get { return _cards[i]; }
            set { _cards[i] = value; }
        }

        public Paquet() { }

        public void ClearPaquet()
        {
            this._cards = new();
        }

        public void ResetPaquet()
        {
            this._cards = new();
            this.AddAllCards();
        }

        public void AddCard(Carte card)
        {
            this._cards.Add(card);
        }

        public void RemoveCard(Carte card) 
        {
            this._cards.Remove(card);
        }

        public Carte TakeRandomCard()
        {
            Carte chosen = this._cards[new Random().Next(0, this._cards.Count)];
            this._cards.Remove(chosen);
            return chosen;
        }

        public Carte? TakeCardWithIdOrNull(int id)
        {
            Carte? result = null;
            foreach (Carte card in this._cards)
            {
                if (card.Id == id)
                {
                    result = card;
                    break;
                }
            }
            return result;
        }

        public int GetNbCards() { return this._cards.Count; }

        public void AddAllCards()
        {
            foreach (var cardInfo in Paquet.templatesCards)
            {
                for (int loop = 0; loop < 6; loop++)
                {
                    this._cards.Add(new Carte(cardInfo));
                }
            }
        }

        public void DisplayCards()
        {
            foreach (Carte card in _cards)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
