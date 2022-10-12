using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatas_Compilador
{
    /// <CLASE LEXICO>
    /// Esta clase es la que contiene el lexico del compilador
    /// contiene las palabras reservadas, separadores, comentarios, operadores
    /// y cuenta con las funciones para identificar cada token
    /// </CLASE LEXICO>
    /// <Autor>
    /// EQUIPO 1
    /// HECTOR, FRANCISCO, MAURICIO, NESIM, SERGIO
    /// </Autor>
    /// <Fecha>
    /// 3 de octubre del 2022
    /// </Fecha>
    class Lexico
    {
        string[] keywords = { "inicio", "final", "si", "entonces", "para",
                                "mientras", "hacer", "leer", "escribir" };

        string[] keywordsC = { "Auto", "Break", "Swicth", "Case", "Char",
                                "Continue", " Default", "do", "while", "if",
                                "else", "Return" };

        string[] separator = { ";", "{", "}", "\r", "\n", "\r\n" };

        string[] comments = { "//", "/*", "*/" };

        string[] operators = { "+", "-", "*", "/", "%", "&","(",")","[","]",
            "|", "^", "!", "~", "&&", "||",",",
            "++", "--", "<<", ">>", "==", "!=", "<", ">", "<=",
            ">=", "=", "+=", "-=", "*=", "/=", "%=", "&=", "|=",
            "^=", "<<=", ">>=", ".", "[]", "()", "?:", "=>", "??" };

        //El metodo parse determina el valor del token identificado
        //para mostrarlo en la tabla de simbolos
        public string Parse(string item, bool lenguaje)
        {
            StringBuilder str = new StringBuilder();
            int ok;

            if (Int32.TryParse(item, out ok))
            {
                str.Append("numerical constant");
                return str.ToString();
            }

            if (item.Equals("\r\n"))
            {
                return "\r\n";

            }

            if (CheckOperatorJama(item) == true)
            {
                str.Append("operador");
                return str.ToString();
            }
            if (CheckDelimiterJama(item) == true)
            {
                str.Append("separador");
                return str.ToString();
            }

            if (lenguaje == true)
            {
                if (CheckKeywordJama(item) == true)
                {
                    str.Append("palabra reservada");
                    return str.ToString();
                }
            }
            else
            {
                if (CheckKeywordC(item) == true)
                {
                    str.Append("palabra reservada");
                    return str.ToString();
                }
            }
            str.Append("identificador");
            return str.ToString();

        }



        //los siguientes metodos buscan si existen en los arreglos declarados
        //al inicio la palabra identificada
        //CHECK EN LENGUAJE JAMA
        private bool CheckOperatorJama(string str)
        {
            if (Array.IndexOf(operators, str) > -1)
                return true;
            return false;
        }

        private bool CheckDelimiterJama(string str)
        {
            if (Array.IndexOf(separator, str) > -1)
                return true;
            return false;
        }
        private bool CheckKeywordJama(string str)
        {
            if (Array.IndexOf(keywords, str) > -1)
                return true;
            return false;
        }
        private bool CheckCommentsJama(string str)
        {
            if (Array.IndexOf(comments, str) > -1)
                return true;
            return false;
        }


        //CHECK EN LENGUAJE C
        private bool CheckKeywordC(string str)
        {
            if (Array.IndexOf(keywordsC, str) > -1)
                return true;
            return false;
        }
    }
}
