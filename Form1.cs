using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_inventario
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        Inventario inventario = new Inventario();
        Producto nuevoProducto; 

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Busqueda por código
            Producto x = inventario.buscar(int.Parse(txtCodigo.Text));
            if (x == null)
            {
                MessageBox.Show("No se encontro ningun registro con ese código");
                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtCosto.Text = "";
            }                
            else
            {
                txtCodigo.Text = x.codigo.ToString();
                txtNombre.Text = x.nombre.ToString();
                txtCantidad.Text = x.cantidad.ToString();
                txtCosto.Text = x.costo.ToString();
            }                                    
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agrega producto
            nuevoProducto = new Producto();

            if (txtCodigo.Text == "" || txtNombre.Text ==""|| txtCantidad.Text ==""|| txtCosto.Text == "")
                MessageBox.Show("Llenar todos los campos");
            else
            {
                nuevoProducto.codigo = int.Parse(txtCodigo.Text);
                nuevoProducto.nombre = txtNombre.Text;
                nuevoProducto.cantidad = int.Parse(txtCantidad.Text);
                nuevoProducto.costo = int.Parse(txtCosto.Text);

                inventario.agregar(nuevoProducto);

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtCosto.Text = "";
            }                          
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Elimina producto
            inventario.borrar(int.Parse(txtCodigo.Text));
            txtCodigo.Text = "";
        }  

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //Reporte
            txtReporte.Text = inventario.reporte();
        }                
    }
}
