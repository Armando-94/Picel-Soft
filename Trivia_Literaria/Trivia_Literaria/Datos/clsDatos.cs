using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Trivia_Literaria.Datos
{
    class clsDatos
    {
        private MySqlConnection cConexion = new MySqlConnection();

        public void Conectar()
        {
            string strCadenaConexion;
            strCadenaConexion = "SERVER=" + "localhost" + ";PORT=3306" + ";DATABASE=" + "TriviaAD2016" + ";UID=" + "root" + ";PWD=" + "root";
            cConexion.ConnectionString = strCadenaConexion;
            cConexion.Open();
        }

        public void Cerrar()
        {
            cConexion.Close();
        }

        public void AgregarEquipo(Pojos.clsAgregarEquipo objAgEq) {
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@NOMBRE",objAgEq.Nombre);
            com.Parameters.AddWithValue("@SCORE", objAgEq.ScoreFinal);
            com.Parameters.AddWithValue("@NOPARTICIPANTES", objAgEq.NoParticipantes);
            sql = "INSERT INTO Equipos (Nombre,ScoreFinal,NoParticipantes) VALUES(@NOMBRE,@SCORE,@NOPARTICIPANTES)";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            Cerrar();
        }

        public bool VerificarTriviaExistente(char trivia) {
            int n;
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@TRIVIA",trivia);
            sql = "select count(Libros_idLibro) from Libros_Trivias where combo = '@TRIVIA' ";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            n=Int16.Parse(com.ExecuteScalar().ToString());
            Cerrar();
            return n!=0;
        }

        public int VerificarLibrosRegistrados(char trivia)
        {
            int n;
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@TRIVIA", trivia);
            sql = "select count(Libros_idLibro) from Libros_Trivias where combo = '@TRIVIA' ";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            n = Int16.Parse(com.ExecuteScalar().ToString());
            Cerrar();
            return n;
        }

        public string[] Equipos(char trivia) {
            string sql;
            int tri,n;
            MySqlCommand com;
            Conectar();
            com=new MySqlCommand();
            if (trivia == 'A')
            {
                tri = 1;
            }
            else {
                tri = 2;
            }
            com.Parameters.AddWithValue("@TRIVIA", tri);
            sql = "SELECT COUNT(Equipos_Id_equipo) FROM equipos_trivias WHERE Trivias_idTrivias = @TRIVIA";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            n = int.Parse(com.ExecuteScalar().ToString());
            string[] arr = new string[n];
            int aux = 0;
            MySqlDataReader dr;
            sql = "SELECT Equipos_Id_equipo FROM equipos_trivias WHERE Trivias_idTrivias = @TRIVIA";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            dr = com.ExecuteReader();
            while(dr.Read()){
                arr[aux] = dr.GetString("Equipos_Id_equipo");
                aux++;
            }
            Cerrar();
            Conectar();
            for (int o = 0; o < arr.Length;o++ )
            {
                sql = "SELECT NOMBRE FROM EQUIPOS WHERE Id_equipo = "+arr[o];
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                arr[o] = com.ExecuteScalar().ToString();
            }
            Cerrar();
            return arr;
        }

        public int[] Score(char trivia) {
            string sql;
            int tri, n;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            if (trivia == 'A')
            {
                tri = 1;
            }
            else
            {
                tri = 2;
            }
            com.Parameters.AddWithValue("@TRIVIA", tri);
            sql = "SELECT COUNT(Equipos_Id_equipo) FROM equipos_trivias WHERE Trivias_idTrivias = @TRIVIA";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            n = int.Parse(com.ExecuteScalar().ToString());
            int[] arr = new int[n];
            int aux = 0;
            MySqlDataReader dr;
            sql = "SELECT Equipos_Id_equipo FROM equipos_trivias WHERE Trivias_idTrivias = @TRIVIA";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                arr[aux] = dr.GetInt16("Equipos_Id_equipo");
                aux++;
            }
            Cerrar();
            Conectar();
            for (int o = 0; o < arr.Length; o++)
            {
                sql = "SELECT ScoreFinal FROM EQUIPOS WHERE Id_equipo = " + arr[o];
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                arr[o] = int.Parse(com.ExecuteScalar().ToString());
            }
            Cerrar();
            return arr;
        }

        public string[] Preguntas(char trivia) {
            string sql,pregunta,respuesta,libro;
            int min, max,id,id_Libro;
            Random rnd = new Random();
            string[] arr= new string[8];
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            if (trivia == 'A')
            {
                for (int i = 1; i <= 7; i++)
                {
                    sql = "SELECT min(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = "+ i +" AND UTILIZADA = 0 AND COMBO = 'A'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    min = Int16.Parse(com.ExecuteScalar().ToString());
                    sql = "SELECT max(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + i + " AND UTILIZADA = 0 AND COMBO = 'A'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    max = Int16.Parse(com.ExecuteScalar().ToString());
                    id = rnd.Next(min,max);
                    sql="SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = "+ id + " AND UTILIZADA = 0 AND COMBO = 'A'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    try
                    {
                        pregunta = com.ExecuteScalar().ToString();
                    }
                    catch (Exception exe)
                    {
                        pregunta = "";
                    }
                    while(pregunta.Equals("")){
                        id = rnd.Next(min, max);
                        sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0  AND COMBO = 'A'";
                        com.CommandText = sql;
                        com.CommandType = CommandType.Text;
                        com.Connection = cConexion;
                        try
                        {
                            pregunta = com.ExecuteScalar().ToString();
                        }
                        catch (Exception exe)
                        {
                            pregunta = "";
                        }
                    }
                    sql = "SELECT RESPUESTA FROM PREGUNTAS WHERE idpreguntas = " + id;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    respuesta = com.ExecuteScalar().ToString();
                    sql = "SELECT Libros_idLibros FROM PREGUNTAS WHERE idpreguntas = " + id;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    id_Libro = Int16.Parse(com.ExecuteScalar().ToString());
                    sql = "select nombre from libros where idlibro = " + id_Libro;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    libro = com.ExecuteScalar().ToString();
                    arr[i - 1] = "Libro: " + libro + "\t" + "Id: " + id + "\r\n\r\n" + pregunta + ";" + respuesta;
                }
            }
            else
            {
                for (int i = 1; i <= 7; i++)
                {
                    sql = "SELECT min(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + i + " AND UTILIZADA = 0 AND COMBO = 'B'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    min = Int16.Parse(com.ExecuteScalar().ToString());
                    sql = "SELECT max(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + i + " AND UTILIZADA = 0 AND COMBO = 'B'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    max = Int16.Parse(com.ExecuteScalar().ToString());
                    id = rnd.Next(min, max);
                    sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'B'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    try
                    {
                        pregunta = com.ExecuteScalar().ToString();
                    }
                    catch(Exception exe)
                    {
                        pregunta = "";
                    }
                    while (pregunta.Equals(""))
                    {
                        id = rnd.Next(min, max);
                        sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'B'";
                        com.CommandText = sql;
                        com.CommandType = CommandType.Text;
                        com.Connection = cConexion;
                        try
                        {
                            pregunta = com.ExecuteScalar().ToString();
                        }
                        catch (Exception exe)
                        {
                            pregunta = "";
                        }
                    }
                    sql = "SELECT RESPUESTA FROM PREGUNTAS WHERE idpreguntas = " + id;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    respuesta = com.ExecuteScalar().ToString();
                    sql = "SELECT Libros_idLibros FROM PREGUNTAS WHERE idpreguntas = " + id;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    id_Libro = Int16.Parse(com.ExecuteScalar().ToString());
                    sql = "select nombre from libros where idlibro = " + id_Libro;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    libro = com.ExecuteScalar().ToString();
                    arr[i - 1] = "Libro: " + libro + "\t" + "Id: " + id + "\r\n\r\n" + pregunta + ";" + respuesta;
                }
            }
            Cerrar();
            return arr;
        }

        public string Extra(char trivia) {
            string sql, pregunta, respuesta, ex,libr;
            int min, max, id, id_Libro;
            Random rnd = new Random();
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            int libro = rnd.Next(1, 7);
            if (trivia == 'A')
            {
                sql = "SELECT min(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + libro + " AND UTILIZADA = 0 AND COMBO = 'A'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                min = Int16.Parse(com.ExecuteScalar().ToString());
                sql = "SELECT max(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + libro + " AND UTILIZADA = 0 AND COMBO = 'A'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                max = Int16.Parse(com.ExecuteScalar().ToString());
                id = rnd.Next(min, max);
                sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'A'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                try
                {
                    pregunta = com.ExecuteScalar().ToString();
                }
                catch (Exception exe)
                {
                    pregunta = "";
                }
                while (pregunta.Equals(""))
                {
                    id = rnd.Next(min, max);
                    sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'A'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    try
                    {
                        pregunta = com.ExecuteScalar().ToString();
                    }
                    catch (Exception exe)
                    {
                        pregunta = "";
                    }
                }
                sql = "SELECT RESPUESTA FROM PREGUNTAS WHERE idpreguntas = " + id;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                respuesta = com.ExecuteScalar().ToString();
                sql = "SELECT Libros_idLibros FROM PREGUNTAS WHERE idpreguntas = " + id;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                id_Libro = Int16.Parse(com.ExecuteScalar().ToString());
                sql = "select nombre from libros where idlibro = " + id_Libro;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                libr = com.ExecuteScalar().ToString();
                ex = "Libro: " + libr + "\t" + "Id: " + id + "\r\n\r\n" + pregunta + ";" + respuesta;
            }
            else
            {
                sql = "SELECT min(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + libro + " AND UTILIZADA = 0 AND COMBO = 'B'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                min = Int16.Parse(com.ExecuteScalar().ToString());
                sql = "SELECT max(IDPREGUNTAS) FROM PREGUNTAS WHERE LIBROS_IDLIBROS = " + libro + " AND UTILIZADA = 0 AND COMBO = 'B'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                max = Int16.Parse(com.ExecuteScalar().ToString());
                id = rnd.Next(min, max);
                sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'B'";
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                try
                {
                    pregunta = com.ExecuteScalar().ToString();
                }
                catch (Exception exe)
                {
                    pregunta = "";
                }
                while (pregunta.Equals(""))
                {
                    id = rnd.Next(min, max);
                    sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0 AND COMBO = 'B'";
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    try
                    {
                        pregunta = com.ExecuteScalar().ToString();
                    }
                    catch (Exception exe)
                    {
                        pregunta = "";
                    }
                }
                sql = "SELECT RESPUESTA FROM PREGUNTAS WHERE idpreguntas = " + id;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                respuesta = com.ExecuteScalar().ToString();
                sql = "SELECT Libros_idLibros FROM PREGUNTAS WHERE idpreguntas = " + id;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                id_Libro = Int16.Parse(com.ExecuteScalar().ToString());
                sql = "select nombre from libros where idlibro = " + id_Libro;
                com.CommandText = sql;
                com.CommandType = CommandType.Text;
                com.Connection = cConexion;
                libr = com.ExecuteScalar().ToString();
                ex = "Libro: " + libr + "\t" + "Id: " + id + "\r\n\r\n" + pregunta + ";" + respuesta;
            }
            Cerrar();
            return ex;
        }

        public void Usada(string respuesta) {
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@respuesta", respuesta);
            sql = "UPDATE `triviaad2016`.`preguntas` SET `Utilizada`='1' WHERE respuesta = @respuesta";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            Cerrar();
        }

        public void ActualizarScore(string equipo,int score){
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@EQUIPO",equipo);
            sql = "UPDATE `triviaad2016`.`equipos` SET `ScoreFinal`= " + "'" + score + "'" +" WHERE Nombre = @EQUIPO";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            Cerrar();
        }

        public void AgregarEquipo_Trivia(string trivia,string equipo) {
            string sql;
            int tri,equi;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            if (trivia.Equals("Trivia A"))
            {
                tri = 1;
            }
            else {
                tri = 2;
            }
            com.Parameters.AddWithValue("@EQUIPO", equipo);
            sql = "SELECT ID_EQUIPO FROM EQUIPOS WHERE NOMBRE = @EQUIPO";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            equi = int.Parse(com.ExecuteScalar().ToString());
            com.Parameters.AddWithValue("@TRIVIA", tri);
            com.Parameters.AddWithValue("@EQUI", equi);
            sql = "INSERT INTO equipos_trivias VALUES (@EQUI,@TRIVIA)";
            com.CommandText = sql;
            com.CommandType = CommandType.Text;
            com.Connection = cConexion;
            com.ExecuteNonQuery();
            Cerrar();
        }
    }
}