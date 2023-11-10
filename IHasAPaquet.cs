using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minivillesPROTO
{
    internal interface IHasAPaquet
    {
        void ClearPaquet()
        {

        }

        void ResetPaquet()
        {
        }

        void AddCard(Carte card)
        {
        }

        void RemoveCard(Carte card) { }

        void TakeRandomCard()
        {
        }

        void TakeCardWithIdOrNull(int id)
        {
        }

        void GetNbCards() { }

        void AddAllCards()
        {
        }

        void DisplayCards()
        {
        }
    }
}
