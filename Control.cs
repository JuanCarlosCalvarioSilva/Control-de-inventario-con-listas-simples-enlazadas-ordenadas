using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_inventario
{
    class Producto
    {
        private int _codigo;
        public int codigo
        {
            set { _codigo = value; }
            get { return _codigo; }
        }

        private string _nombre;
        public string nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }

        private int _cantidad;
        public int cantidad
        {
            set { _cantidad = value; }
            get { return _cantidad; }
        }

        private int _costo;
        public int costo
        {
            set { _costo = value; }
            get { return _costo; }
        }

        private Producto _siguiente;
        public Producto siguiente
        {
            set { _siguiente = value; }
            get { return _siguiente; }
        }

        public override string ToString()
        {
            return "Código: " + _codigo.ToString() + " |  Nombre: " + _nombre.ToString() + " |  Cantidad: " + _cantidad.ToString() + " |  $" + _costo.ToString() + " ";
        }
    }
}
