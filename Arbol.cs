using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ArbolExpresionesAritmeticas
{
    public class Arbol
    {
        #region Campos de clase 
        //insercion de cola
        private string precedencia = "+-*/^";
        private string[] delimitadores = { "+", "-", "*", "/", "^" };
        private string[] operandosArray;
        private string[] operadoresArray;
        private Queue colaExpresion;

        //creacion del arbol
        private string token;
        private string operadorTemporal;
        private int i = 0;
        private Stack pilaOperandos;
        private Stack pilaOperadores;
        private Stack pilaDot;
        private Nodo raiz = null;

        public Nodo nodoDot { get; set; }

        //popiedades para el recorrido
        public string cadenaPreorden { get; set; }
        public string cadenaInorden { get; set; }
        public string cadenaPostorden { get; set; }

        #endregion

        /// <BALANCEO DE PARENTESIS>
        /// La funcion checkBalanced recorre el string y cuando encuentra un braket abierto hace un push dentro de la pila stack
        /// Cuando encuentra un braket de cierre hace un pop en dicha pila
        /// Al momento de que la pila queda vacia sin mas brakets queire decir que los brakets estan balancedos
        /// En la version actual no esta en uso esta funcion
        /// </BALANCEO DE PARENTESIS>
        /// <Autor>
        /// EQUIPO 1
        /// HECTOR, FRANCISCO, MAURICIO, NESIM, SERGIO
        /// </Autor>
        /// <Fecha>
        /// 18 de septiembre del 2022
        /// </Fecha>
        #region BALANCEO DE PARENTESIS
        public string checkBalanced(string s)//el parametro "s" se refiera a la expresion 
        {

            string result = "YES"; //la variable result se utiliza para llevar un control de cuando los parentesis estan balanceados
            Stack stack = new Stack(); //la pila llamada stack es donde se van guardando los caracteres de la expresion para ser recorrida
            int abierto = 0; //lleva el conteo de los parentesis que abren
            int cerrado = 0; //lleva el conteo de los parentesis que cierran

            for (int i = 0; i < s.Length; i++)
            {

                if (s[i].ToString() == "{"
                   || s[i].ToString() == "("
                   || s[i].ToString() == "[")
                {

                    stack.Push(s[i].ToString());
                }
                else if (stack.Count > 0)
                {

                    if (s[i].ToString() == "}")
                    {

                        if (stack.Peek().ToString() == "{")
                        {
                            stack.Pop();
                            result = "NO";
                        }
                        else
                        {
                            MessageBox.Show("PARENTESIS NO BALANCEADOS");
                            result = "NO";
                        }
                    }
                    else if (s[i].ToString() == "]")
                    {

                        if (stack.Peek().ToString() == "[")
                        {
                            stack.Pop();
                            result = "NO";
                        }
                        else
                        {
                            MessageBox.Show("PARENTESIS NO BALANCEADOS");
                            result = "NO";
                        }
                    }
                    else if (s[i].ToString() == ")")
                    {

                        if (stack.Peek().ToString() == "(")
                        {

                            stack.Pop();
                            result = "NO";
                        }
                        else
                        {
                            MessageBox.Show("PARENTESIS NO BALANCEADOS");
                            result = "NO";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("PARENTESIS NO BALANCEADOS");
                    result = "NO";
                }
            }

            if (stack.Count > 0)
            {
                MessageBox.Show("PARENTESIS NO BALANCEADOS");
            }

            if(result == "YES")
            {
                MessageBox.Show("PARENTESIS BALANCEADOS");
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if(s[i].ToString() == "{"
                   || s[i].ToString() == "("
                   || s[i].ToString() == "[")
                    {
                        abierto+=1;
                    }

                    if (s[i].ToString() == "}"
                   || s[i].ToString() == ")"
                   || s[i].ToString() == "]")
                    {
                        cerrado += 1;
                    }
                }
                //><
                if (abierto > cerrado)
                {
                    MessageBox.Show("La expresión tiene mas paréntesis que abren que los que se cierran");
                }
                if (abierto < cerrado)
                {
                    MessageBox.Show("La expresión tiene mas paréntesis que cierran que los que se abren");
                }
                if (abierto == cerrado)
                {
                    MessageBox.Show("PARENTESIS BALANCEADOS");
                }
            }
            return result;


        }
        #endregion



        /// <Arbol Constructores>
        /// inicializa el arbol (constructores)
        /// </Arbol Constructores>
        #region Constructores
        public Arbol()
        {
            pilaOperadores = new Stack();
            pilaOperandos = new Stack();
            pilaDot = new Stack();
            colaExpresion = new Queue();
        }
        #endregion

        public string fnQuitarParentesis(string s)
        {
            string aux = string.Empty;
            
            foreach (char item in s)
            {
                if(!item.Equals('(') || !item.Equals(')'))
                {
                    aux+=item;
                }
            }
            return aux;
        }

        /// <Insercion de la expresion en la cola>
        /// Se separa la expresion en caracteres y se agrega en sus respectivos arrays
        /// </Insercion de la expresion en la cola>
        #region insercion cola
        public void insertarCola(string expresion)
        {
            operandosArray = expresion.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries);
            operadoresArray = expresion.Split(operandosArray, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; colaExpresion.Count < operandosArray.Length + (operadoresArray.Length - 1); i++)
            {
                colaExpresion.Enqueue(operandosArray[i]);
                colaExpresion.Enqueue(operadoresArray[i]);

            }
            colaExpresion.Enqueue(operandosArray[operandosArray.Length - 1]);

        }
        #endregion

        #region Arbol
        public Nodo crearArbol()
        {
            while (colaExpresion.Count != 0)
            {
                token = (string)colaExpresion.Dequeue();
                if (precedencia.IndexOf(token) < 0)
                {
                    pilaOperandos.Push(new Nodo(token));
                    pilaDot.Push(new Nodo($"nodo{++i}[label=\"{token}\"]"));
                }
                else
                {
                    if (pilaOperadores.Count != 0)
                    {
                        operadorTemporal = (string)pilaOperadores.Peek();//lo que tiene arriba de la pila
                        while (pilaOperadores.Count != 0 && precedencia.IndexOf(operadorTemporal) >= precedencia.IndexOf(token))
                        {
                            GuardarSubArbol();
                            if (pilaOperadores.Count != 0)
                            {
                                operadorTemporal = (string)pilaOperadores.Peek();
                            }
                        }
                    }
                    pilaOperadores.Push(token);
                }
            }

            raiz = (Nodo)pilaOperandos.Peek();
            nodoDot = (Nodo)pilaDot.Peek();
            while (pilaOperadores.Count != 0)
            {
                GuardarSubArbol();
                raiz = (Nodo)pilaOperandos.Peek();
                nodoDot = (Nodo)pilaDot.Peek();
            }

            return raiz;
        }

        private void GuardarSubArbol()
        {
            Nodo derecho = (Nodo)pilaOperandos.Pop();
            Nodo izquierdo = (Nodo)pilaOperandos.Pop();
            pilaOperandos.Push(new Nodo(derecho, izquierdo, pilaOperadores.Peek()));

            Nodo derechoG = (Nodo)pilaDot.Pop();
            Nodo izquierdoG = (Nodo)pilaDot.Pop();
            pilaDot.Push(new Nodo(derechoG, izquierdoG, $"nodo{++i}[label=\"{pilaOperadores.Pop()}\"]"));
        }

        #endregion

        #region Recorridos
        //preorden
        public string insertarPre(Nodo tree)
        {
            if (tree != null)
            {
                cadenaPreorden += tree.Datos + " ";
                insertarPre(tree.NodoIzquierdo);
                insertarPre(tree.NodoDerecho);
            }
            return cadenaPreorden;

        }
        //inorden
        public string insertarIn(Nodo tree)
        {
            if (tree != null)
            {
                insertarIn(tree.NodoIzquierdo);
                cadenaInorden += tree.Datos + " ";
                insertarIn(tree.NodoDerecho);
            }
            return cadenaInorden;
        }

        //posorden
        public string insertarPost(Nodo tree)
        {
            if (tree != null)
            {
                insertarPost(tree.NodoIzquierdo);
                insertarPost(tree.NodoDerecho);
                cadenaPostorden += tree.Datos + " ";
            }
            return cadenaPostorden;
        }
        #endregion

        public void Limpiar()
        {
            cadenaInorden = "";
            cadenaPreorden = "";
            cadenaPostorden = "";
        }
    }
}
