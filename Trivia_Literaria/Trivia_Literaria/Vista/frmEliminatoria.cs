using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Trivia_Literaria.Vista
{
    public partial class frmEliminatoria : Form
    {
        public frmEliminatoria()
        {
            InitializeComponent();
        }

        // i = Ronda actual, j = Equipo actual, p = Pregunta seleccionada, seg = segundo, indexRobo = quién robó, puntosRobo = Cuántos puntos hay involucrados (1 o -1)
        public int i=0, j=0, p, seg=0, indexRobo, puntosRobo,empatados,scoreMaximo,rondas=10;
        
        SoundPlayer sonido = new SoundPlayer(@"Speech Off.wav");

        public string[] equipos;
        public string[] preguntas = new string[8];
        public string[] respuestas = new string[8];
        public int[] score;
        private bool[] preguntasOrden=new bool[8];

        private void btnCorrecto_Click(object sender, EventArgs e)
        {
            Datos.clsDatos objDatos = new Datos.clsDatos();
            /*En caso de que el nombre del botón Incorrecto no sea el
               adecuado, lo regresamos*/
            if(btnIncorrecto.Text.Equals("Respuesta")){
                btnIncorrecto.Text = "Incorrecto";
            }
            //Usaremos este botón como 2: Correcto y siguiente
            if (btnCorrecto.Text.Equals("Correcto"))
            {
                btnAclaracion.Visible = false;
                //Mostramos un mensaje con la pregunta y la respuesta
                tmTemporizador.Enabled = false;
                btnIncorrecto.Visible = false;
                seg = 0;
                txtPregunta.Text = preguntas[p] + "\r\n\r\n" + respuestas[p];
                //Aumentamos el score del equipo j
                score[j]++;
                lblEquipo.Text = equipos[j];
                lblScore.Text = "" + score[j];
                btnCorrecto.Text = "Siguiente";
            }
            else {
                /*Siguiente: Aumentamos equipo, mostramos su nombre y score,
                  modificamos lo que dice el botón, lo ocultamos, borramos el textbox
                  y regresamos el tiempo (label) a 0*/
                if (btnIncorrecto.Visible)
                {
                    btnIncorrecto.Visible = false;
                }
                btnAclaracion.Visible = false;
                objDatos.ActualizarScore(equipos[j],score[j]);
                j++;
                if (j < equipos.Length)
                {
                    lblEquipo.Text = equipos[j];
                    lblScore.Text = "" + score[j];
                    btnCorrecto.Text = "Correcto";
                    btnCorrecto.Visible = false;
                    txtPregunta.Text = "";
                    lblTime.ForeColor = Color.White;
                    lblTime.Text = "0";
                    mtdActivarBotones();
                    //En caso de que esté visible, ocultamos el botón de robo
                    if(btnRobo.Visible){
                        btnRobo.Visible = false;
                    }
                }
                else {
                    i++;
                    /*Si ya acabó una vuelta (ronda) pasamos a la siguiente
                      Si la ronda es <= 9 (10 rondas) iniciamos los equipos a 0
                      Sino acabamos la trivia*/
                    if (i < rondas)
                    {
                        for (int o = 0; o < 8; o++)
                        {
                            preguntasOrden[o] = false;
                        }
                        char d = ';';
                        string extra;
                        string[] arr;
                        string[] substrings;
                        if (this.Text.Equals("Eliminatoria 1"))
                        {
                            equipos = objDatos.Equipos('A');
                            score = objDatos.Score('A');
                            arr = objDatos.Preguntas('A');
                            for (int h = 0; h < 7; h++)
                            {
                                substrings = arr[h].Split(d);
                                preguntas[h] = substrings[0];
                                respuestas[h] = substrings[1];
                            }
                            extra = objDatos.Extra('A');
                            substrings = extra.Split(d);
                            preguntas[7] = substrings[0];
                            respuestas[7] = substrings[1];
                        }
                        else if (this.Text.Equals("Eliminatoria 2"))
                        {
                            equipos = objDatos.Equipos('B');
                            score = objDatos.Score('B');
                            arr = objDatos.Preguntas('B');
                            for (int h = 0; h < 7; h++)
                            {
                                substrings = arr[h].Split(d);
                                preguntas[h] = substrings[0];
                                respuestas[h] = substrings[1];
                            }
                            extra = objDatos.Extra('B');
                            substrings = extra.Split(d);
                            preguntas[7] = substrings[0];
                            respuestas[7] = substrings[1];
                        }
                        else
                        {
                            arr = objDatos.Preguntas(this.Text.ElementAt(this.Text.Length - 1));
                            for (int h = 0; h < 7; h++)
                            {
                                substrings = arr[h].Split(d);
                                preguntas[h] = substrings[0];
                                respuestas[h] = substrings[1];
                            }
                            extra = objDatos.Extra('B');
                            substrings = extra.Split(d);
                            preguntas[7] = substrings[0];
                            respuestas[7] = substrings[1];
                        }
                        MessageBox.Show("Ronda " + (i+1));
                        j = 0;
                        mtdVerBotones();
                        mtdActivarBotones();
                        lblEquipo.Text = equipos[j];
                        lblScore.Text = "" + score[j];
                        btnCorrecto.Text = "Correcto";
                        btnCorrecto.Visible = false;
                        lblTime.ForeColor = Color.White;
                        if (btnRobo.Visible)
                        {
                            btnRobo.Visible = false;
                        }
                        txtPregunta.Text = "";
                        lblTime.Text = "0";
                        if(i==3 | i==6 | i==8){
                            Vista.frmScore objS = new frmScore(equipos, score);
                            this.Hide();
                            objS.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        if (mtdVerificarGanador())
                        {
                            mtdFinTrivia();
                        }
                        else
                        {
                            MessageBox.Show("Empate... Muerte Súbita");
                            if (this.Text.Equals("Eliminatoria 1"))
                            {
                                this.Text = "Muerte Súbita A";
                            }
                            else
                            {
                                this.Text = "Muerte Súbita B";
                            }
                            mtdArmarMuerteSubita();
                            rondas = 5;
                            i = 0;
                            j = 0;
                            mtdVerBotones();
                            mtdActivarBotones();
                            lblEquipo.Text = equipos[j];
                            lblScore.Text = "" + score[j];
                            btnCorrecto.Text = "Correcto";
                            btnCorrecto.Visible = false;
                            lblTime.ForeColor = Color.White;
                            txtPregunta.Text = "";
                            lblTime.Text = "0";
                            btnAclaracion.Visible = false;
                        }
                    }
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //P = Posición del arreglo, donde está la pregunta correspondiente a este botón
            Random rnd = new Random();
            p = rnd.Next(0,7);
            while (preguntasOrden[p])
            {
                p = rnd.Next(0, 7);
            }
            preguntasOrden[p] = true;
            Datos.clsDatos objDatos = new Datos.clsDatos();
            objDatos.Usada(respuestas[p]);
            //Evitamos que el texto esté seleccionado
            txtPregunta.Focus();
            //Mostramos la pregunta correspondiente
            txtPregunta.Text = preguntas[p];
            btn1.Visible = false;
            mtdDesactivarBotones();
            tmTemporizador.Enabled = true;
            btnAclaracion.Visible = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //P = Posición del arreglo, donde está la pregunta correspondiente a este botón
            Random rnd = new Random();
            p = rnd.Next(0, 7);
            while (preguntasOrden[p])
            {
                p = rnd.Next(0, 7);
            }
            preguntasOrden[p] = true;
            Datos.clsDatos objDatos = new Datos.clsDatos();
            objDatos.Usada(respuestas[p]);
            //Evitamos que el texto esté seleccionado
            txtPregunta.Focus();
            //Mostramos la pregunta correspondiente
            txtPregunta.Text = preguntas[p];
            btn2.Visible = false;
            mtdDesactivarBotones();
            tmTemporizador.Enabled = true;
            btnAclaracion.Visible = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //P = Posición del arreglo, donde está la pregunta correspondiente a este botón
            Random rnd = new Random();
            p = rnd.Next(0, 7);
            while (preguntasOrden[p])
            {
                p = rnd.Next(0, 7);
            }
            preguntasOrden[p] = true;
            Datos.clsDatos objDatos = new Datos.clsDatos();
            objDatos.Usada(respuestas[p]);
            //Evitamos que el texto esté seleccionado
            txtPregunta.Focus();
            //Mostramos la pregunta correspondiente
            txtPregunta.Text = preguntas[p];
            btn3.Visible = false;
            mtdDesactivarBotones();
            tmTemporizador.Enabled = true;
            btnAclaracion.Visible = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //P = Posición del arreglo, donde está la pregunta correspondiente a este botón
            Random rnd = new Random();
            p = rnd.Next(0, 7);
            while (preguntasOrden[p])
            {
                p = rnd.Next(0, 7);
            }
            preguntasOrden[p] = true;
            Datos.clsDatos objDatos = new Datos.clsDatos();
            objDatos.Usada(respuestas[p]);
            //Evitamos que el texto esté seleccionado
            txtPregunta.Focus();
            //Mostramos la pregunta correspondiente
            txtPregunta.Text = preguntas[p];
            btn4.Visible = false;
            mtdDesactivarBotones();
            tmTemporizador.Enabled = true;
            btnAclaracion.Visible = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //P = Posición del arreglo, donde está la pregunta correspondiente a este botón
            Random rnd = new Random();
            p = rnd.Next(0, 7);
            while (preguntasOrden[p])
            {
                p = rnd.Next(0, 7);
            }
            preguntasOrden[p] = true;
            Datos.clsDatos objDatos = new Datos.clsDatos();
            objDatos.Usada(respuestas[p]);
            //Evitamos que el texto esté seleccionado
            txtPregunta.Focus();
            //Mostramos la pregunta correspondiente
            txtPregunta.Text = preguntas[p];
            btn5.Visible = false;
            mtdDesactivarBotones();
            tmTemporizador.Enabled = true;
            btnAclaracion.Visible = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //P = Posición del arreglo, donde está la pregunta correspondiente a este botón
            Random rnd = new Random();
            p = rnd.Next(0, 7);
            while (preguntasOrden[p])
            {
                p = rnd.Next(0, 7);
            }
            preguntasOrden[p] = true;
            Datos.clsDatos objDatos = new Datos.clsDatos();
            objDatos.Usada(respuestas[p]);
            //Evitamos que el texto esté seleccionado
            txtPregunta.Focus();
            //Mostramos la pregunta correspondiente
            txtPregunta.Text = preguntas[p];
            btn6.Visible = false;
            mtdDesactivarBotones();
            tmTemporizador.Enabled = true;
            btnAclaracion.Visible = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //P = Posición del arreglo, donde está la pregunta correspondiente a este botón
            Random rnd = new Random();
            p = rnd.Next(0, 7);
            while (preguntasOrden[p])
            {
                p = rnd.Next(0, 7);
            }
            preguntasOrden[p] = true;
            Datos.clsDatos objDatos = new Datos.clsDatos();
            objDatos.Usada(respuestas[p]);
            //Evitamos que el texto esté seleccionado
            txtPregunta.Focus();
            //Mostramos la pregunta correspondiente
            txtPregunta.Text = preguntas[p];
            btn7.Visible = false;
            mtdDesactivarBotones();
            tmTemporizador.Enabled = true;
            btnAclaracion.Visible = true;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //P = Posición del arreglo, donde está la pregunta correspondiente a este botón
            Random rnd = new Random();
            p = rnd.Next(0, 7);
            while (preguntasOrden[p])
            {
                p = rnd.Next(0, 7);
            }
            preguntasOrden[p] = true;
            Datos.clsDatos objDatos = new Datos.clsDatos();
            objDatos.Usada(respuestas[p]);
            //Evitamos que el texto esté seleccionado
            txtPregunta.Focus();
            //Mostramos la pregunta correspondiente
            txtPregunta.Text = preguntas[p];
            btn8.Visible = false;
            mtdDesactivarBotones();
            tmTemporizador.Enabled = true;
            btnAclaracion.Visible = true;
        }

        private void frmEliminatoria_Load(object sender, EventArgs e)
        {
            Datos.clsDatos objDatos = new Datos.clsDatos();
            char d=';';
            string extra;
            string[] arr;
            string[] substrings;
            if (this.Text.Equals("Eliminatoria 1"))
            {
                equipos=objDatos.Equipos('A');
                score = objDatos.Score('A');
                arr = objDatos.Preguntas('A');
                for (int i = 0; i < 7;i++ )
                {
                    substrings = arr[i].Split(d);
                    preguntas[i]=substrings[0];
                    respuestas[i] = substrings[1];
                }
                extra=objDatos.Extra('A');
                substrings = extra.Split(d);
                preguntas[7] = substrings[0];
                respuestas[7] = substrings[1];
            }
            else {
                equipos = objDatos.Equipos('B');
                score = objDatos.Score('B');
                arr = objDatos.Preguntas('B');
                for (int i = 0; i < 7; i++)
                {
                    substrings = arr[i].Split(d);
                    preguntas[i] = substrings[0];
                    respuestas[i] = substrings[1];
                }
                extra = objDatos.Extra('B');
                substrings = extra.Split(d);
                preguntas[7] = substrings[0];
                respuestas[7] = substrings[1];
            }
            /*Cargamos inmediatamente el primer equipo (nombre y score)*/
            lblEquipo.Text = equipos[j];
            lblScore.Text = ""+score[j];
            //Bloquemos el textbox
            txtPregunta.ReadOnly = true;
            btn1.Focus();
        }

        #region Método que nos servirá para desactivar los botones depués de haber seleccionado uno
        private void mtdDesactivarBotones() {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
        }
        #endregion

        #region Método que nos servirá para activar todos los botones depués de haber seleccionado correcto o incorrecto
        private void mtdActivarBotones()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
        }
        #endregion

        #region Método que nos servirá para hacer visibles todos los botones después de una ronda
        private void mtdVerBotones()
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
        }
        #endregion

        #region Método que nos mostrará quién ganó y finalizará la trivia
        private void mtdFinTrivia()
        {
            int max = 0,aux=0;
            for (int o = 0; o < equipos.Length; o++)
            {
                if (score[o] > max)
                {
                    max = score[o];
                    aux = o;
                }
            }
            frmGanadores objG = new frmGanadores(equipos[aux]);
            this.Hide();
            objG.ShowDialog();
            this.Close();
        }
        #endregion

        #region BASURA
        private void txtPregunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPregunta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPregunta_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Aumenta el segundero
            seg++;
            //Los primeros 15 segundos solo aumenta y muestra
            if (seg < 15)
            {
                lblTime.Text = "" + seg;
            }
            else {
                //Quita la pregunta y sigue mostrando el segundero
                txtPregunta.Text = "";
                if (!(seg == 25))
                {
                    //Activamos los botones de correcto e incorrecto (entra solo si aún no están activos)
                    if (!btnCorrecto.Visible | !btnCorrecto.Visible)
                    {
                        btnCorrecto.Visible = true;
                        btnIncorrecto.Visible = true;
                    }
                    //Los últimos 5 segundos se muestra el segundero en rojo y suena
                    if(seg >= 20){
                        //Suena
                        sonido.Play();
                        lblTime.ForeColor = Color.Red;
                    }
                    lblTime.Text = "" + seg;
                }
                else {
                    /*Al terminar los 25 segundos se desactiva el timer,
                      Muestra el mensaje de tiempo terminado y el segundero regresa a 0*/
                    tmTemporizador.Enabled = false;
                    lblTime.Text = "OVER";
                    //Cambia texto del botón correcto
                    btnCorrecto.Text="Siguiente";
                    btnIncorrecto.Text = "Respuesta";
                    //Se muestra el botón de robo
                    btnRobo.Visible = true;
                    seg = 0;
                    btnAclaracion.Visible = false;
                }
            }
        }

        private void btnIncorrecto_Click(object sender, EventArgs e)
        {
            if (btnIncorrecto.Text.Equals("Incorrecto"))
            {
                btnAclaracion.Visible = false;
                //Se detiene el tiempo. Sí, así de hardcore
                tmTemporizador.Enabled = false;
                //Lo regresamos a 0
                seg = 0;
                //Cambiamos el "nombre" del botón
                btnIncorrecto.Text = "Respuesta";
                //Cambiamos el texto del botón correcto
                btnCorrecto.Text = "Siguiente";
                //En caso de que se haya ocultado el botón (time over) lo mostramos
                if (!btnCorrecto.Visible)
                {
                    btnCorrecto.Visible = true;
                }
                //Mostramos el botón de robo
                btnRobo.Visible = true;
            }
            else {
                btnIncorrecto.Visible = false;
                btnIncorrecto.Text = "Incorrecto";
                btnRobo.Visible = false;
                txtPregunta.Text = preguntas[p] + "\r\n\r\n" + respuestas[p];
                btnCorrecto.Focus();
            }
        }

        private void btnRobo_Click(object sender, EventArgs e)
        {
            Datos.clsDatos objDatos = new Datos.clsDatos();
            string equipo = equipos[j];
            Vista.frmRobo objR = new frmRobo(preguntas[p],respuestas[p],equipos,equipo);
            this.Hide();
            objR.ShowDialog();
            score[objR.index] += objR.puntos;
            objDatos.ActualizarScore(equipos[objR.index], score[objR.index]);
            this.Show();
            btnRobo.Visible = false;
            btnIncorrecto.Visible = false;
            btnIncorrecto.Text = "Incorrecto";
            /*Siguiente: Aumentamos equipo, mostramos su nombre y score,
                  modificamos lo que dice el botón, lo ocultamos, borramos el textbox
                  y regresamos el tiempo (label) a 0*/
            j++;
            if (j < equipos.Length)
            {
                lblEquipo.Text = equipos[j];
                lblScore.Text = "" + score[j];
                btnCorrecto.Text = "Correcto";
                btnCorrecto.Visible = false;
                txtPregunta.Text = "";
                lblTime.ForeColor = Color.White;
                lblTime.Text = "0";
                mtdActivarBotones();
                //En caso de que esté visible, ocultamos el botón de robo
                if (btnRobo.Visible)
                {
                    btnRobo.Visible = false;
                }
                btnAclaracion.Visible = false;
            }
            else
            {
                /*Si ya acabó una vuelta (ronda) pasamos a la siguiente
                  Si la ronda es <= 9 (10 rondas) iniciamos los equipos a 0
                  Sino acabamos la trivia*/
                i++;
                if (i < rondas)
                {
                    for (int o = 0; o < 8; o++)
                    {
                        preguntasOrden[o] = false;
                    }
                    char d = ';';
                    string extra;
                    string[] arr;
                    string[] substrings;
                    if (this.Text.Equals("Eliminatoria 1"))
                    {
                        equipos = objDatos.Equipos('A');
                        score = objDatos.Score('A');
                        arr = objDatos.Preguntas('A');
                        for (int h = 0; h < 7; h++)
                        {
                            substrings = arr[h].Split(d);
                            preguntas[h] = substrings[0];
                            respuestas[h] = substrings[1];
                        }
                        extra = objDatos.Extra('A');
                        substrings = extra.Split(d);
                        preguntas[7] = substrings[0];
                        respuestas[7] = substrings[1];
                    }
                    else if (this.Text.Equals("Eliminatoria 2"))
                    {
                        equipos = objDatos.Equipos('B');
                        score = objDatos.Score('B');
                        arr = objDatos.Preguntas('B');
                        for (int h = 0; h < 7; h++)
                        {
                            substrings = arr[h].Split(d);
                            preguntas[h] = substrings[0];
                            respuestas[h] = substrings[1];
                        }
                        extra = objDatos.Extra('B');
                        substrings = extra.Split(d);
                        preguntas[7] = substrings[0];
                        respuestas[7] = substrings[1];
                    }
                    else
                    {
                        arr = objDatos.Preguntas(this.Text.ElementAt(this.Text.Length - 1));
                        for (int h = 0; h < 7; h++)
                        {
                            substrings = arr[h].Split(d);
                            preguntas[h] = substrings[0];
                            respuestas[h] = substrings[1];
                        }
                        extra = objDatos.Extra('B');
                        substrings = extra.Split(d);
                        preguntas[7] = substrings[0];
                        respuestas[7] = substrings[1];
                    }
                    MessageBox.Show("Ronda " + (i+1));
                    j = 0;
                    mtdVerBotones();
                    mtdActivarBotones();
                    lblEquipo.Text = equipos[j];
                    lblScore.Text = "" + score[j];
                    btnCorrecto.Text = "Correcto";
                    btnCorrecto.Visible = false;
                    lblTime.ForeColor = Color.White;
                    txtPregunta.Text = "";
                    lblTime.Text = "0";
                    btnAclaracion.Visible = false;
                    if (i == 3 | i == 6 | i == 8)
                    {
                        Vista.frmScore objS = new frmScore(equipos, score);
                        this.Hide();
                        objS.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    if (mtdVerificarGanador())
                    {
                        mtdFinTrivia();
                    }
                    else {
                        MessageBox.Show("Empate... Muerte Súbita");
                        if (this.Text.Equals("Eliminatoria 1"))
                        {
                            this.Text = "Muerte Súbita A";
                        }
                        else {
                            this.Text = "Muerte Súbita B";
                        }
                        mtdArmarMuerteSubita();
                        rondas = 5;
                        i = 0;
                        j = 0;
                        mtdVerBotones();
                        mtdActivarBotones();
                        lblEquipo.Text = equipos[j];
                        lblScore.Text = "" + score[j];
                        btnCorrecto.Text = "Correcto";
                        btnCorrecto.Visible = false;
                        lblTime.ForeColor = Color.White;
                        txtPregunta.Text = "";
                        lblTime.Text = "0";
                        btnAclaracion.Visible = false;
                    }
                }
            }
        }

        private void mtdArmarMuerteSubita() {
            int aux = 0;
            int[]sc=new int[equipos.Length];
            string[] eq=new string[equipos.Length];
            for(int o=0;o<equipos.Length;o++){
                sc[o]=score[o];
                eq[o]=equipos[o];
            }
            equipos = new string[empatados];
            score = new int[empatados];
            for (int o = 0; o < eq.Length;o++ )
            {
                if(sc[o]==scoreMaximo){
                    equipos[aux] = eq[o];
                    score[aux] = sc[o];
                    aux++;
                }
            }
        }

        private bool mtdVerificarGanador(){
            int max=0,cant=0;
            for (int o = 0; o < equipos.Length;o++ )
            {
                if(score[o]>max){
                    max = score[o];
                }
            }
            for (int o = 0; o < equipos.Length; o++)
            {
                if(score[o]==max){
                    cant++;
                }
            }
            empatados = cant;
            scoreMaximo = max;
            return (cant==1);
        }

        private void btnAclaracion_Click(object sender, EventArgs e)
        {
            tmTemporizador.Enabled = !tmTemporizador.Enabled;
        }

        private void frmEliminatoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmTemporizador.Enabled = false;
        }

        private void txtPregunta_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}