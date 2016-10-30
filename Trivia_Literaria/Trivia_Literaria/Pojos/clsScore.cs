using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Literaria.Pojos
{
    public class clsScore
    {
        private string equipo;
        private int score;

        public clsScore(string equipo,int score) {
            Equipo = equipo;
            Score = score;
        }

        public string Equipo {
            get 
            {
                return equipo;
            }
            set 
            {
                equipo = value;
            }
        }

        public int Score {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }
    }
}
