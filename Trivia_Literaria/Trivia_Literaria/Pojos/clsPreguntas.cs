using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Literaria.Pojos
{
    class clsPreguntas
    {
        private int cIdPreguntas;
        private int cUtilizada;
        private char cCombo;
        private string cRespuesta;
        private string cPregunta;
        private int cLibros_idLibros;

        public int idPreguntas {
            get {
                return cIdPreguntas;
            }
            set {
                cIdPreguntas = value;
            }
        }

        public int Utilizada
        {
            get
            {
                return cUtilizada;
            }
            set
            {
                cUtilizada = value;
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

        public string Respuesta {
            get {
                return cRespuesta;
            }
            set {
                cRespuesta = value;
            }
        }

        public string Pregunta
        {
            get
            {
                return cPregunta;
            }
            set
            {
                cPregunta = value;
            }
        }

        public int Libros_idLibros {
            get {
                return cLibros_idLibros;
            }
            set {
                cLibros_idLibros = value;
            }
        }
    }
}
