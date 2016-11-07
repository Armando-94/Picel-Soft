using System;
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
    public partial class frmRobo : Form
    {
        public frmRobo()
        {
            InitializeComponent();
        }

        public frmRobo(string pregunta,string respuesta,string[] equipos, string equipo) {
            InitializeComponent();
            this.pregunta = pregunta;
            this.respuesta = respuesta;
            this.equipos = equipos;
            this.equipo = equipo;
        }

        private string pregunta, respuesta,equipo;
        private string[] equipos;
        public int seg,index,puntos;
        public string equi;
        public bool bandera=true;

        SoundPlayer sonido = new SoundPlayer(@"Speech Off.wav");

        private void frmRobo_Load(object sender, EventArgs e)
        {
            txtPregunta.ReadOnly = true;
            //cmbEquipos.DataSource = equipos;
            for (int eq = 0; eq < equipos.Length;eq++ )
            {
                if(!equipos[eq].Equals(equipo)){
                    cmbEquipos.Items.Add(equipos[eq]);
                }
            }
            cmbEquipos.Text="Equipos";
            lblSegundos.ForeColor = Color.White;
            seg = 3;
        }

        //Incorrecto
        private void button2_Click(object sender, EventArgs e)
        {
            tmTemporizador.Enabled = false;
            txtPregunta.Text = pregunta + "\r\n\r\n" + respuesta;
            btnIncorrecto.Visible = false;
            btnCorrecto.Visible = false;
            btnRegresar.Visible = true;
            btnRegresar.Focus();
            equi = cmbEquipos.SelectedItem.ToString();
            for (int eq = 0; eq < equipos.Length; eq++)
            {
                if (equi.Equals(equipos[eq]))
                {
                    index = eq;
                    break;
                }
            }
            puntos = -1;
        }

        private void cmbEquipos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tmTemporizador_Tick(object sender, EventArgs e)
        {
            if(bandera){
                if (seg > 1)
                {
                    lblConteoRegresivo.Text = "" + seg;
                    seg--;
                    lblConteoRegresivo.Text = "" + seg;
                }
                else if (seg == 1)
                {
                    txtPregunta.Visible = true;
                    lblEquipo.Visible = true;
                    lblSegundos.Visible = true;
                    lblTime.Visible = true;
                    cmbEquipos.Visible = true;
                    lblConteoRegresivo.Visible = false;
                    tmTemporizador.Enabled = false;
                }
            }
            else {
                seg++;
                if (seg < 15)
                {
                    lblSegundos.Text = "" + seg;
                    if (seg == 10) sonido.Play();
                    if (seg > 10)
                    {
                        lblSegundos.ForeColor = Color.Red;
                        sonido.Play();
                    }
                }
                else
                {
                    tmTemporizador.Enabled = false;
                    lblSegundos.Text = "OVER";
                    btnCorrecto.Visible = false;
                    btnIncorrecto.Visible = false;
                    btnRegresar.Visible = true;
                    txtPregunta.Text = pregunta + "\r\n\r\n" + respuesta;
                    btnRegresar.Focus();
                    equi = cmbEquipos.SelectedItem.ToString();
                    for (int eq = 0; eq < equipos.Length; eq++)
                    {
                        if (equi.Equals(equipos[eq]))
                        {
                            index = eq;
                            break;
                        }
                    }
                    puntos = -1;
                }
            }
        }

        private void cmbEquipos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tmTemporizador.Enabled = true;
            seg = 0;
            bandera = false;
            btnCorrecto.Visible = true;
            btnIncorrecto.Visible = true;
            cmbEquipos.Enabled = false;
        }

        private void btnCorrecto_Click(object sender, EventArgs e)
        {
            tmTemporizador.Enabled = false;
            txtPregunta.Text = pregunta + "\r\n\r\n" + respuesta;
            btnIncorrecto.Visible = false;
            btnCorrecto.Visible = false;
            btnRegresar.Visible = true;
            btnRegresar.Focus();
            equi = cmbEquipos.SelectedItem.ToString();
            for (int eq = 0; eq < equipos.Length;eq++ )
            {
                if(equi.Equals(equipos[eq])){
                    index = eq;
                    break;
                }
            }
            puntos = 1;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
