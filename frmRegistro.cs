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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }
        clsArchivo grabar = new clsArchivo();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Focus();
                MessageBox.Show("Campo Nombre vacio");
            }
            else
            {
                if (txtApellido.Text == "")
                {
                    txtApellido.Focus();
                    MessageBox.Show("Campo Apellido Vacio");
                }
                else
                {
                    if (dtpFechaNacimiento == null)
                    {
                        dtpFechaNacimiento.Focus();
                        MessageBox.Show("Seleccione una fecha valida");
                    }
                    else
                    {
                        if (txtDireccion.Text == "")
                        {
                            txtDireccion.Focus();
                            MessageBox.Show("Campo Direccion vacio");
                        }
                        else
                        {
                            if (txtCiudad.Text == "")
                            {
                                txtCiudad.Focus();
                                MessageBox.Show("Campo Ciudad Vacio");
                            }
                            else
                            {
                                if (txtNumero.Text == "")
                                {
                                    txtNumero.Focus();
                                    MessageBox.Show("Campo Numero Vacio");
                                }
                                else
                                {
                                    string[] datosEmpleado = new string[] { txtNombre.Text, txtApellido.Text, dtpFechaNacimiento.Value.Date.ToString("dd-MM-yyyy"), txtDireccion.Text, txtCiudad.Text, txtNumero.Text };
                                    string datosConcatenados = string.Join(";", datosEmpleado);
                                    grabar.Grabar(datosConcatenados);

                                    txtNombre.Clear();
                                    txtApellido.Clear();
                                    txtDireccion.Clear();
                                    txtCiudad.Clear();
                                    txtNumero.Clear();
                                    MessageBox.Show("Empleado cargado correctamente");

                                }
                            }
                        }
                    }
                }
            }
        }
    }

}
