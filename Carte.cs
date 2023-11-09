using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minivillesPROTO
{
    internal class Carte : Paquet
    {
        private readonly int _id;
        public int Id { get { return _id; } }

        private readonly int _valeurActivation;
        public int ValeurActivation { get { return _valeurActivation; } }

        private readonly string _color;
        public string Color { get { return _color; } }

        private readonly string _name;
        public string Name { get { return _name; } }

        private readonly string _description;
        public string Description { get { return _description; } }

        private readonly int _prixCarte;
        public int Prixcarte { get { return _prixCarte; } }

        public Carte((int id, int valeurActivation, string color, string name, string description, int prixCarte) input)
        {
            this._id = input.id;
            this._valeurActivation = input.valeurActivation;
            this._color = input.color;
            this._name = input.name;
            this._description = input.description;
            this._prixCarte = input.prixCarte;
        }

        public override string ToString()
        {
            return String.Format("[{0}] {1} - {2} : {3} - {4}$", this._valeurActivation, this._color, this._name, this._description, this._prixCarte);
        }
    }
}
