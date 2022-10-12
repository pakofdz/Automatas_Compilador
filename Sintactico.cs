using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatas_Compilador
{
    class Sintactico
    {
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
        /// 3 de octubre del 2022
        /// </Fecha>
        public string checkBalanced(string s)//el parametro "s" se refiera a la expresion 
        {

            string result = "YES"; //la variable result se utiliza para llevar un control de cuando los parentesis estan balanceados
            Stack stack = new Stack(); //la pila llamada stack es donde se van guardando los caracteres de la expresion para ser recorrida
            string error = "PARENTESIS NO BALANCEADOS", descripcion = "";
            int abierto = 0; //lleva el conteo de los parentesis que abren
            int cerrado = 0; //lleva el conteo de los parentesis que cierran

            for (int i = 0; i < s.Length; i++) //en este for se recorre todo el texto del codigo de nuestro compilador
            {

                if (s[i].ToString() == "{"
                   || s[i].ToString() == "("
                   || s[i].ToString() == "[")
                {

                    stack.Push(s[i].ToString()); //si se encuentra un parentesis abierto se hara un push a la pila
                }
                else if (stack.Count > 0) //verifica si la pila esta llena o no
                {

                    if (s[i].ToString() == "}")
                    {

                        if (stack.Peek().ToString() == "{")
                        {
                            stack.Pop(); //si encuentra un bracket cerrado hara un pop en la pila hasta que quede vacia 
                            result = "YES";
                        }
                        else
                        {
                            //MessageBox.Show("PARENTESIS NO BALANCEADOS");
                            result = "NO";
                        }
                    }
                    else if (s[i].ToString() == "]")
                    {

                        if (stack.Peek().ToString() == "[")
                        {
                            stack.Pop();
                            result = "YES";
                        }
                        else
                        {
                            //MessageBox.Show("PARENTESIS NO BALANCEADOS");
                            result = "NO";
                        }
                    }
                    else if (s[i].ToString() == ")")
                    {

                        if (stack.Peek().ToString() == "(")
                        {
                            stack.Pop();
                            result = "YES";
                        }
                        else
                        {
                            //MessageBox.Show("PARENTESIS NO BALANCEADOS");
                            result = "NO";
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("PARENTESIS NO BALANCEADOS");
                    result = "NO";
                }
            }
           
            //vuelve a recorrer el texto para verificar si hay mas parentesis abiertos que cerrados
            //o viceversa
            for (int i = 0; i < s.Length; i++)
                {
                    if (s[i].ToString() == "{"
                   || s[i].ToString() == "("
                   || s[i].ToString() == "[")
                    {
                        abierto += 1;
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
                    //MessageBox.Show("La expresión tiene mas paréntesis que abren que los que se cierran");
                    descripcion = "La expresión tiene mas paréntesis que abren que los que se cierran";
                    return descripcion;
                }
                if (abierto < cerrado)
                {
                    //MessageBox.Show("La expresión tiene mas paréntesis que cierran que los que se abren");
                    descripcion = "La expresión tiene mas paréntesis que cierran que los que se abren";
                    return descripcion;
                }
                if (abierto == cerrado)
                {
                    //MessageBox.Show("PARENTESIS BALANCEADOS");
                }
            
            return descripcion;
        }


        public string checkOperators(string s)//el parametro "s" se refiera a la expresion 
        {
            string result = "YES"; //la variable result se utiliza para llevar un control de cuando los parentesis estan balanceados
            Stack stack = new Stack(); //la pila llamada stack es donde se van guardando los caracteres de la expresion para ser recorrida
            string error = "Error Sintactico", descripcion = "";
            int abierto = 0; //lleva el conteo de los parentesis que abren
            int cerrado = 0; //lleva el conteo de los parentesis que cierran

            string[] operators = { "+", "-", "*", "/" };
            int[] numeros = { 0,1,2,3,4,5,6,7,8,9 };

            for (int i = 0; i < s.Length; i++) //en este for se recorre todo el texto del codigo de nuestro compilador
            {

                if (s[i].ToString() == "+")
                {
                    stack.Push(s[i].ToString()); //si se encuentra un parentesis abierto se hara un push a la pila
                    if (s[i-1].ToString() == "1")
                    {
                        stack.Push(s[i].ToString());
                    }
                }
                else if (s[i].ToString() == "1") //verifica si la pila esta llena o no
                {
                    stack.Push(s[i].ToString());
                }
                else
                {
                    //MessageBox.Show("PARENTESIS NO BALANCEADOS");
                    result = "NO";
                }
            }
            //if (result == "NO" || stack.Count > 0)
            //return descripcion;
            //MessageBox.Show("PARENTESIS NO BALANCEADOS");
            //else
            //MessageBox.Show("PARENTESIS BALANCEADOS");

            /*/if (stack.Count > 0)
            {
                MessageBox.Show("PARENTESIS NO BALANCEADOS");
            }*/

            /*if (result == "YES")
            {
                //MessageBox.Show("PARENTESIS BALANCEADOS");
            }
            else
            {*/
            for (int i = 0;     i < s.Length; i++)
            {
                if (s[i].ToString() == "{"
               || s[i].ToString() == "("
               || s[i].ToString() == "[")
                {
                    abierto += 1;
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
                //MessageBox.Show("La expresión tiene mas paréntesis que abren que los que se cierran");
                descripcion = "La expresión tiene mas paréntesis que abren que los que se cierran";
                return descripcion;
            }
            if (abierto < cerrado)
            {
                //MessageBox.Show("La expresión tiene mas paréntesis que cierran que los que se abren");
                descripcion = "La expresión tiene mas paréntesis que cierran que los que se abren";
                return descripcion;
            }
            if (abierto == cerrado)
            {
                //MessageBox.Show("PARENTESIS BALANCEADOS");
            }

            return descripcion;
            //return result;
        }
    }
}
