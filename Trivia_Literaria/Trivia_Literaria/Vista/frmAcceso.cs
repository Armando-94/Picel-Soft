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
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            #region Llamado a Autenticación
                frmLogin objAcceso = new frmLogin();
                this.Hide();
                objAcceso.ShowDialog();
                this.Show();
            #endregion
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            #region Salir
                Application.Exit();
            #endregion
        }

        private void btnEliminatoriaUno_Click(object sender, EventArgs e)
        {
            #region Llamada a la ventana de eliminatoria 1
            /*Para realizar la instancia de la clase frmEliminatoria es necesario
                  colocar Vista.frmEliminatoria*/
            Vista.frmEliminatoria objE = new Vista.frmEliminatoria();
            this.Hide();
            objE.Text = "Eliminatoria 1";
            objE.ShowDialog();
            this.Show();
            #endregion
        }

        private void btnEliminatoriaDos_Click(object sender, EventArgs e)
        {
            #region Llamada a la ventana de eliminatoria 2
            /*Para realizar la instancia de la clase frmEliminatoria es necesario
                  colocar Vista.frmEliminatoria*/
            Vista.frmEliminatoria objE = new Vista.frmEliminatoria();
            this.Hide();
            objE.Text = "Eliminatoria 2";
            objE.ShowDialog();
            this.Show();
            #endregion
        }
    }
}
