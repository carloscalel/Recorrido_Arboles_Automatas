using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesNodos
{
    public class Nodo
    {
        #region campos de clase
        private object datos;
        private Nodo nodoIzquierdo;
        private Nodo nodoDerecho;

        #endregion campos de clase

        #region constructores
        public Nodo()
        {
            nodoDerecho = nodoIzquierdo = null;
        }

        public Nodo(object datos)
        {
            this.datos = datos;
            nodoDerecho = nodoIzquierdo = null;
        }

        public Nodo(Nodo derecho, Nodo izquierdo, object valor)
        {
            this.nodoDerecho = derecho;
            this.nodoIzquierdo = izquierdo;
            this.datos = valor;
        }
        #endregion constructores

        #region propiedades clase nodo
        //nodo Izquierdo
        public Nodo NodoIzquierdo { get => nodoIzquierdo; set => nodoIzquierdo = value; }

        //nodo derecho
        public Nodo NodoDerecho { get => nodoDerecho; set => nodoDerecho = value; }

        //datos
        public object Datos { get => datos; set => datos = value; }

        #endregion propiedades clase nodo
    }
}
