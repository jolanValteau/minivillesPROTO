using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace minivillesPROTO
{
    internal class Jeu : IHasAPaquet
    {
        private Paquet _pqt;
        public Paquet Pqt { get { return _pqt; } }

        private List<Joueur> _players;
        public List<Joueur> Players { get { return _players; } }

        private int _nbPlayers;
        public int NbPlayers { get { return _nbPlayers; } }

        private De _de = new(6);
        public De De { get { return _de; } }

        private int _currentTurn = 0;
        public int CurrentTurn { get { return _currentTurn; } }

        private Joueur? _playerPlaying = null;
        public Joueur? PlayerPlaying { get { return _playerPlaying; } }

        public Jeu(int nbPlayers)
        {
            this._nbPlayers = nbPlayers;
            this._pqt = new();
            this._players = new();
        }



        public void ClearPaquet()
        {
            this._pqt.ClearPaquet();
        }

        public void ResetPaquet()
        {
            this._pqt.ResetPaquet();
        }

        public void AddCard(Carte card)
        {
            this._pqt.AddCard(card);
        }

        public void RemoveCard(Carte card)
        {
            this._pqt.RemoveCard(card);
        }

        public Carte TakeRandomCard()
        {
            return this._pqt.TakeRandomCard();
        }

        public Carte? TakeCardWithIdOrNull(int id)
        {
            return this._pqt.TakeCardWithIdOrNull(id);
        }

        public int GetNbCards()
        {
            return this._pqt.GetNbCards();
        }

        public void AddAllCards()
        {
            this._pqt.AddAllCards();
        }

        public void DisplayCards()
        {
            this._pqt.DisplayCards();
        }



        public void ResetPlayers()
        {
            this._players = new();
            for (int iPlayer = 0; iPlayer < this._nbPlayers; iPlayer++)
            {
                this._players.Add(new Joueur("Joueur " + (iPlayer + 1)));
            }
        }

        public void GiveStartingCards()
        {
            foreach (Joueur player in this._players)
            {
                GiveCard(player, this._pqt.TakeCardWithIdOrNull(1));
                GiveCard(player, this._pqt.TakeCardWithIdOrNull(3));
            }
        }

        public void SetupGame()
        {
            this.ResetPlayers();
            this.ResetPaquet();
            this.GiveStartingCards();
        }

        public void Turn() // 2 players
        {
            this._currentTurn++;
            this._playerPlaying = this._players[this._currentTurn % this._players.Count];

            this._de.Roll();
            this._de.Display();

            this._playerPlaying.ActivateCardsPlaying(this._de.CurrentFace, this);
            foreach (Joueur player in this._players)
            {
                if (player != this._playerPlaying)
                    player.ActivateCardsSpectating(this._de.CurrentFace, this);
            }
        }

        public static void GiveCard(Joueur player, Carte? card)
        {
            if (card == null) CardNotFoundException();
            else player.AddCard(card);
        }

        public static void CardNotFoundException()
        {
            Console.WriteLine("Card missing / not Found.");
        }

        public void Display()
        {
            foreach (var player in this._players)
            {
                player.Display();
            }
        }
    }
}
