using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoWCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cliente = new ProductosServices.Service1Client())
                {
                    string resultado = cliente.AgregarProducto(Convert.ToInt32(txtId.Text),
                                                               txtNombre.Text,
                                                               Convert.ToDouble(txtPrecio.Text));
                    MessageBox.Show(resultado);
                    txtId.Clear();
                    txtNombre.Clear();
                    txtPrecio.Clear();
                    ListaResultados.Text = ""; 
                    string listado = cliente.ObtenerProductosConcatenado();
                    ListaResultados.Items.Add(listado);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message );
            }
        }
    }
}
