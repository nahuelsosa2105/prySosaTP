using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySosaTP
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        clsRegistro objBase;

        private void registroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistro frnprincipal = new frmRegistro();
            frnprincipal.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListado frmprincipal = new frmListado();
            frmprincipal.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            objBase = new clsRegistro();
            objBase.ConectarBD();

            lblEstado.Text = objBase.estadoConexion.ToString();
        }
    }
}
