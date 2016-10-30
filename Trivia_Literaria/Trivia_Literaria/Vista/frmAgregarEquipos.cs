using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_Literaria
{
    public partial class frmAgregarEquipos : Form
    {
        public frmAgregarEquipos()
        {
            InitializeComponent();
        }

        #region Basura ¡NO BORRAR!
        private void frmAgregarEquipos_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtIntegrantes_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            //Salir
            this.Close();
        }

        /*Aquí se controla el tamaño y posición de los elementos de la ventana dependiendo del
        número de integrantes*/
        private void mtdEquipo() {
            int numEquipos=Int32.Parse(txtIntegrantes.Text);
            if (numEquipos >= 2 && numEquipos <= 5)
            {
                switch (Int32.Parse(txtIntegrantes.Text))
                {
                    case 2:
                        gbEquipo.Height = 117;
                        btnAceptar.Location = new Point(32,257);
                        btnCancelar.Location = new Point(249, 257);
                        this.Height= 338;
                        break;
                    case 3:
                        gbEquipo.Height = 167;
                        btnAceptar.Location = new Point(32,307);
                        btnCancelar.Location = new Point(249, 307);
                        this.Height= 388;
                        break;
                    case 4:
                        gbEquipo.Height = 217;
                        btnAceptar.Location = new Point(32,357);
                        btnCancelar.Location = new Point(249, 357);
                        this.Height= 438;
                        break;
                    case 5:
                        gbEquipo.Height = 267;
                        btnAceptar.Location = new Point(32,407);
                        btnCancelar.Location = new Point(249, 407);
                        this.Height= 488;
                        break;
                }
            }
            else {
                MessageBox.Show("El número de integrantes debe ser entre 2-5");
                txtIntegrantes.Text = "";
                this.Height = 154;
            }
        }

        private void txtIntegrantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Número de Equipos
            if ((int)e.KeyChar == 13)
            {
                gbEquipo.Text = "Nombre de los integrantes del equipo: " + txtEquipo.Text;
                mtdEquipo();
            }
            #endregion
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pojos.clsAgregarEquipo objAgEq = new Pojos.clsAgregarEquipo();
            Datos.clsDatos objDatos = new Datos.clsDatos();
            objAgEq.Nombre = txtEquipo.Text;
            objAgEq.ScoreFinal = 0;
            objAgEq.NoParticipantes = Int16.Parse(txtIntegrantes.Text);
            try { 
                objDatos.AgregarEquipo(objAgEq);
                MessageBox.Show("Listo");
                this.Close();
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbTrivia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}