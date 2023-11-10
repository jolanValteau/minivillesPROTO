using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minivillesPROTO
{
    internal class De
    {
        private readonly int _nbFaces;
        public int NbFaces { get { return _nbFaces; } }

        private int _currentFace;
        public int CurrentFace { get { return _currentFace; } }

        public static int nbDe = 0;

        public De(int nbFaces)
        {
            De.nbDe++;
            _nbFaces = nbFaces;
            this.Roll();
        }

        public virtual void Roll()
        {
            this._currentFace = new Random().Next(1, this.NbFaces + 1);
        }

        public override string ToString()
        {
            return String.Format("Le dé n°{0} à {1} faces montre {2}.", De.nbDe, this.NbFaces, this.CurrentFace);
        }
        public void Display() { Console.WriteLine(this.ToString()); }
    }
}
