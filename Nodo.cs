using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolExpresionesAritmeticas
{
    /// <summary>
    /// La clase nodo proporciona los constructores de los objetos de tipo nodo
    /// Cuenta con las propiedades del nodo izquierdo y derecho
    /// </summary>
    public class Nodo
    {
        #region Campos de clase
        private Object datos;
        private Nodo nodoIzquierdo;
        private Nodo nodoDerecho;
        #endregion

        #region Constructores
        public Nodo()
        {
            nodoDerecho = nodoIzquierdo = null;
        }

        public Nodo(Object datos)
        {
            this.datos = datos;
            nodoDerecho = nodoIzquierdo = null;
        }

        public Nodo(Nodo derecho, Nodo izquierdo, Object valor)
        {
            this.nodoDerecho = derecho;
            this.nodoIzquierdo = izquierdo;
            this.datos = valor;
        }
        #endregion

        #region Propiedades de la clase Nodo
        //nodo izquierdo
        public Nodo NodoIzquierdo { get => nodoIzquierdo; set => nodoIzquierdo = value; }
        public Nodo NodoDerecho { get => nodoDerecho; set => nodoDerecho = value; }
        public Object Datos { get => datos; set => datos = value; }
        #endregion  
    }
}