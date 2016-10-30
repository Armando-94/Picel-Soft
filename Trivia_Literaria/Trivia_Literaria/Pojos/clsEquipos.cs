using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Literaria.Pojos
{
    class clsEquipos
    {
        private string cNombre;
        private int cScoreFinal;
        private int cNoparticipantes;

        public string Nombre {
            get {
                return cNombre;
            }
            set {
                cNombre = value;
            }
        }

        public int ScoreFinal {
            get {
                return cScoreFinal;
            }
            set {

                cScoreFinal = value;
            }
        }

        public int NoParticipantes{
            get {
                return cNoparticipantes;
            }
            set { 
                cNoparticipantes=value;
            }
        }
    }
}
