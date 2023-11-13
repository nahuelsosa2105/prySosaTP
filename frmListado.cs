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
    public partial class frmListado : Form
    {
        clsRegistro objBaseDatos;
        public frmListado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarApellido(txtBuscarApellido.Text);
        }

       

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsRegistro();
            objBaseDatos.ConectarBD();
            objBaseDatos.TraerDatos(dgvGrilla);
        }

        public void TraerDatos(DataGridView grilla)
        {

        }
    }
}
