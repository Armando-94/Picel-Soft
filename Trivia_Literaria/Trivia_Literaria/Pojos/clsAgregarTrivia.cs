using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Literaria.Pojos
{
    class clsAgregarTrivia
    {
        private int cLibros_idLibro;
        private int cTrivias_idTrivias;
        private char cCombo;

        public int Libros_idLibro {
            get {
                return cLibros_idLibro;
            }
            set {
                cLibros_idLibro = value;
            }
        }

        public int Trivias_idTrivias {
            get {
                return cTrivias_idTrivias;
            }
            set {
                cTrivias_idTrivias = value;
            }
        }

        public char Combo {
            get {
                return cCombo;
            }
            set {
                cCombo = value;
            }
        }
    }
}
