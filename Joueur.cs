using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minivillesPROTO
{
    internal class Joueur : IHasAPaquet
    {
        private int _money = 0;
        public int Money { get { return _money;} }

        private readonly Paquet _cards = new();
        public Paquet Cards {  get { return _cards;} }

        private readonly string _name;
        public string Name { get { return _name; } }

        public Joueur (string name)
        {
            this._name = name;
        }


        public void ClearPaquet()
        {
            this._cards.ClearPaquet();
        }

        public void ResetPaquet()
        {
            this._cards.ResetPaquet();
        }

        public void AddCard(Carte card)
        {
            this._cards.AddCard(card);
        }

        public void RemoveCard(Carte card)
        {
            this._cards.RemoveCard(card);
        }

        public Carte TakeRandomCard()
        {
            return this._cards.TakeRandomCard();
        }

        public Carte? TakeCardWithIdOrNull(int id)
        {
            return this._cards.TakeCardWithIdOrNull(id);
        }

        public int GetNbCards()
        {
            return this._cards.GetNbCards();
        }

        public void AddAllCards()
        {
            this._cards.AddAllCards();
        }

        public void DisplayCards()
        {
            this._cards.DisplayCards();
        }



        public override string ToString()
        {
            return String.Format("Le {0} a {1} d'argent. Il a {2} cartes :", this._name, this._money, this._cards.GetNbCards());
        }

        public void ActivateCardsPlaying(int valueActivation, Jeu jeu)
        {
            Carte cardChecked;
            for (int iCard = 0; iCard < this._cards.GetNbCards(); iCard++)
            {
                cardChecked = this._cards[iCard];
                if (cardChecked.Color == "Bleu" ||
                    cardChecked.Color == "Vert")
                {
                    if (cardChecked.ValueActivation == valueActivation)
                    {
                        cardChecked.Activate(jeu);
                    }
                }
            }
        }

        public void ActivateCardsSpectating(int valueActivation, Jeu jeu)
        {
            Carte cardChecked;
            for (int iCard = 0; iCard < this._cards.GetNbCards(); iCard++)
            {
                cardChecked = this._cards[iCard];
                if (cardChecked.Color == "Bleu" ||
                    cardChecked.Color == "Rouge")
                {
                    if (cardChecked.ValueActivation == valueActivation)
                    {
                        cardChecked.Activate(jeu);
                    }
                }
            }
        }

        public void AddOrRemoveMoney(int nbMoneyAddOrTaken)
        {
            this._money += nbMoneyAddOrTaken;
        }

        public void Display()
        {
        Console.WriteLine(String.Format("{0}", this._money));
        }

    }
}
