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
    public partial class frmAgregarTrivia : Form
    {
        public frmAgregarTrivia()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            #region Cierra la ventana sin guardar lo realizado
                this.Close();
            #endregion
        }

        private void cmbTrivia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbLibros_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbTrivia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            Datos.clsDatos objDatos = new Datos.clsDatos();
            char c;
            cmbTrivia.Enabled = false;
            if (cmbTrivia.Text.Equals("Trivia A"))
            {
                c = 'A';
            }
            else
            {
                c = 'B';
            }
            if (objDatos.VerificarLibrosRegistrados(c) != 7)
            {
                MessageBox.Show("No se registraron TODOS los libros");
            }
        }

        private void cmbTrivia_TextChanged(object sender, EventArgs e)
        {
            Datos.clsDatos objDatos = new Datos.clsDatos();
            char c;
            cmbTrivia.Enabled = false;
            if (cmbTrivia.Text.Equals("Trivia A"))
            {
                c = 'A';
            }
            else
            {
                c = 'B';
            }
            if (objDatos.VerificarTriviaExistente(c))
            {
                MessageBox.Show("Existe");
            }
            else
            {
                MessageBox.Show("La trivia" + cmbTrivia.Text + " no ha sido agregada");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
