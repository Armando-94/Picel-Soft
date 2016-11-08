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
    public partial class frmGanadores : Form
    {
        public frmGanadores()
        {
            InitializeComponent();
        }

        public frmGanadores(string ganador)
        {
            InitializeComponent();
            lblFinalista.Text = ganador;
        }
    }
}
