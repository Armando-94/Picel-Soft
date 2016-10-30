﻿using System;
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
            string[] arr=new string[5];
            MySqlCommand com;
            Conectar();
            com=new MySqlCommand();
            if (trivia == 'A')
            {
                for (int i = 1; i <= 5;i++ )
                {
                    sql = "SELECT NOMBRE FROM EQUIPOS WHERE ID_EQUIPO = " + i;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    arr[i-1] = com.ExecuteScalar().ToString();
                }
            }
            else
            {
                for (int i = 6; i <= 10;i++ )
                {
                    sql = "SELECT NOMBRE FROM EQUIPOS WHERE ID_EQUIPO = " + i;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    arr[i - 6] = com.ExecuteScalar().ToString();
                }
            }
            Cerrar();
            return arr;
        }

        public int[] Score(char trivia) {
            string sql;
            int[] arr = new int[5];
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            if (trivia == 'A')
            {
                for (int i = 1; i <= 5; i++)
                {
                    sql = "SELECT SCOREFINAL FROM EQUIPOS WHERE ID_EQUIPO = " + i;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    arr[i - 1] = Int16.Parse(com.ExecuteScalar().ToString());
                }
            }
            else
            {
                for (int i = 6; i <= 10; i++)
                {
                    sql = "SELECT SCOREFINAL FROM EQUIPOS WHERE ID_EQUIPO = " + i;
                    com.CommandText = sql;
                    com.CommandType = CommandType.Text;
                    com.Connection = cConexion;
                    arr[i - 6] = Int16.Parse(com.ExecuteScalar().ToString());
                }
            }
            Cerrar();
            return arr;
        }

        public string[] Preguntas(char trivia) {
            string sql,pregunta,respuesta;
            int min, max,id;
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
                    sql="SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = "+ id + " AND UTILIZADA = 0";
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
                        sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0";
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
                    arr[i - 1] = pregunta + ";" + respuesta;
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
                    sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0";
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
                        sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0";
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
                    arr[i - 1] = pregunta + ";" + respuesta;
                }
            }
            Cerrar();
            return arr;
        }

        public string Extra(char trivia) {
            string sql, pregunta, respuesta, ex;
            int min, max, id;
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
                sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0";
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
                    sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0";
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
                ex = pregunta + ";" + respuesta;
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
                sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0";
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
                    sql = "SELECT PREGUNTA FROM PREGUNTAS WHERE idpreguntas = " + id + " AND UTILIZADA = 0";
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
                ex = pregunta + ";" + respuesta;
            }
            Cerrar();
            return ex;
        }

        public void Usada(string pregunta) {
            string sql;
            MySqlCommand com;
            Conectar();
            com = new MySqlCommand();
            com.Parameters.AddWithValue("@pregunta", pregunta);
            sql = "UPDATE `triviaad2016`.`preguntas` SET `Utilizada`='1' WHERE pregunta = @pregunta";
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
    }
}