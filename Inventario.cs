using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_inventario
{
    class Inventario
    {        
        Producto inicio, ultimo;         

        public void agregar(Producto producto)
        {
            Producto anteriorPadre, actual;
            actual = inicio;
            anteriorPadre = null;

            if (inicio == null)
                inicio = producto;       
            else if (ultimo.codigo < producto.codigo)
            {
                ultimo.siguiente = producto;                
            }            
            else
            {                           
                while (actual != null) 
                {
                    anteriorPadre = actual;
                    actual = actual.siguiente;
                    if (producto.codigo < actual.codigo)
                    {
                        anteriorPadre.siguiente = producto;
                        producto.siguiente = actual;
                        break;
                    }                    
                }                
            }
            ultimo = producto;
        }

        public Producto buscar(int codigo)
        {    
            Producto actual = inicio;
            while (actual != null)
            {
                if (actual.codigo == codigo)
                    return actual;
                actual = actual.siguiente;
            }
            return null;
        }

        public void borrar(int codigo)
        {
            if (inicio != null)
            {
                Producto actual, anterior;
                anterior = buscarAnteriorPadre(codigo);

                if (anterior == null)
                {
                    actual = inicio;
                    inicio = inicio.siguiente;
                    anterior = inicio;
                }
                else
                {
                    actual = anterior.siguiente;
                    anterior.siguiente = actual.siguiente;
                }
                actual = null;

                if (anterior == null || anterior.siguiente == null)
                    ultimo = anterior;
            }        
        }

        private Producto buscarAnteriorPadre(int codigo)
        {
            Producto anteriorPadre, actual;
            actual = inicio;
            anteriorPadre = null;

            while (actual != null)
            {
                if (actual.codigo == codigo)
                    break;
                anteriorPadre = actual;
                actual = actual.siguiente;
            }
            return anteriorPadre;
        }

        public string reporte()
        {
            string cad = "";

            if (inicio != null)
            {
                Producto actual = inicio;
                while (actual != null)
                {
                    cad += actual.ToString()+ Environment.NewLine;
                    actual = actual.siguiente;
                }
            }
            return cad;
        }            
    }
}
