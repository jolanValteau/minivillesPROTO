using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace minivillesPROTO
{
    internal class Carte : Paquet
    {
        private readonly int _id;
        public int Id { get { return _id; } }

        private readonly int _valueActivation;
        public int ValueActivation { get { return _valueActivation; } }

        private readonly string _color;
        public string Color { get { return _color; } }

        private readonly string _name;
        public string Name { get { return _name; } }

        private readonly string _description;
        public string Description { get { return _description; } }

        private readonly int _priceCarte;
        public int Pricecarte { get { return _priceCarte; } }

        private readonly int _moneyGiving;
        public int MoneyGiving { get { return _moneyGiving; } }

        private readonly int _moneyTaking;
        public int MoneyTaking { get { return _moneyTaking; } }

        public Carte((int id, int valueActivation, string color, string name, string description, int priceCarte, int moneyGiving, int moneyTaking) input)
        {
            this._id = input.id;
            this._valueActivation = input.valueActivation;
            this._color = input.color;
            this._name = input.name;
            this._description = input.description;
            this._priceCarte = input.priceCarte;
            this._moneyGiving = input.moneyGiving;
            this._moneyTaking = input.moneyTaking;
        }

        public virtual void Activate(Jeu jeu)
        {
            foreach(Joueur player in jeu.Players)
            {
                if (player != jeu.PlayerPlaying)
                    player.AddOrRemoveMoney(this.MoneyTaking);
                else
                    player.AddOrRemoveMoney(this.MoneyGiving);
            }
        }

        public override string ToString()
        {
            return String.Format("[{0}] {1} - {2} : {3} - {4}$", this._valueActivation, this._color, this._name, this._description, this._priceCarte);
        }
    }
}
