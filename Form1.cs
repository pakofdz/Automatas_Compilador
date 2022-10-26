using ArbolExpresionesAritmeticas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <FORM PRINCIPAL>
/// En la clase de Form1 encontraremos los metodos principales
/// los cuales ejecutan los procesos del compilador
/// </FORM PRINCIPAL>
/// <Autor>
/// EQUIPO 1
/// HECTOR, FRANCISCO, MAURICIO, NESIM, sergio
/// </Autor>
/// <Fecha>
/// 3 de octubre del 2022
/// </Fecha>

namespace Automatas_Compilador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Metodo que analiza el codigo y llena la tabla de simbolos
        private void tokens()
        {
            Lexico lex = new Lexico();
            string entrada = txtCode.Text;
            //int index = 0;
            char[] salto = { '\n' };
            char[] limitador = { ' ' };
            bool lenguaje;
            if (checkBoxLenguaje.Checked)
            {
                lenguaje = true;
            }
            else
            {
                lenguaje = false;
            }    
            

            string[] Rarray = entrada.Split(salto);

            for (int i = 0; i < Rarray.Length; i++)
            {
                string[] palabra = Rarray[i].Split(limitador);

                for (int j = 0; j < palabra.Length; j++)
                {
                    palabra[j] = palabra[j].Replace("\n", "");

                    if (palabra[j] != "")
                    {
                        DataGridViewRow row = (DataGridViewRow)gridTokens.Rows[0].Clone();
                        row.Cells[0].Value = lex.Parse(palabra[j], lenguaje); //analizar(palabra[j]);
                        row.Cells[1].Value = palabra[j];
                        row.Cells[2].Value = j + 1;
                        row.Cells[3].Value = i + 1;
                        gridTokens.Rows.Add(row);
                    }
                }
            }
        }


        public void limpiarTokens()
        {
            gridTokens.Rows.Clear();
        }
        public void limpiarErrores()
        {
            gridErrores.Rows.Clear();
        }


        //Busca errores en los brackets que se abren y cierran
        private void btnMenuCompilar_Click(object sender, EventArgs e)
        {
            limpiarErrores();
            Sintactico brackets = new Sintactico();
            brackets.checkBalanced(txtCode.Text);

            string entrada = txtCode.Text;
            char[] salto = { '\n' };
            char[] limitador = { ' ' };

            string error;

            string[] Rarray = entrada.Split(salto);

            for (int i = 0; i < Rarray.Length; i++)
            {
                string[] palabra = Rarray[i].Split(limitador);

                for (int j = 0; j < palabra.Length; j++)
                {
                    palabra[j] = palabra[j].Replace("\n", "");

                    if (palabra[j] != "")
                    {
                        if (brackets.checkOperators(txtCode.Text) != "")
                        {
                            DataGridViewRow err = (DataGridViewRow)gridErrores.Rows[0].Clone();
                            err.Cells[0].Value = "ERROR DE OPERADOR";
                            err.Cells[1].Value = brackets.checkOperators(txtCode.Text);
                            err.Cells[2].Value = j + 1;
                            err.Cells[3].Value = i + 1;
                            gridErrores.Rows.Add(err);
                        }
                        if (brackets.checkBalanced(txtCode.Text) != "")
                        {
                            DataGridViewRow err = (DataGridViewRow)gridErrores.Rows[0].Clone();
                            err.Cells[0].Value = "PARENTESIS NO BALANCEADOS";
                            err.Cells[1].Value = brackets.checkBalanced(txtCode.Text); 
                            err.Cells[2].Value = j + 1;
                            err.Cells[3].Value = i + 1;
                            gridErrores.Rows.Add(err);
                        }
                    }
                }
            }
        }


        private void btnMenuArbol_Click(object sender, EventArgs e)
        {
            FormArbol arbol = new FormArbol();
            arbol.Show();
        }

        private void checkBoxLenguaje_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLenguaje.Checked)
                lblLenguaje.Text = "Lenguaje Jama";
            else
                lblLenguaje.Text = "Lenguaje C";
        }


        //Muestra cuales son las palabras reservadas
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Palabras reservadas\nAuto\nBreak\nSwicth\nCase\nChar\nContinue\nDefault\ndo\nwhile\nif\nelse\nReturn";
            MessageBox.Show(text);
        }
        private void btnPalabrasResJava_Click(object sender, EventArgs e)
        {
            string text = "Palabras reservadas\ninicio\nfinal\nsi\nentonces\npara\nmientras\nhacer\nleer\nescribir";
            MessageBox.Show(text);
        }


        public void colores()
        {
            string pattern = "";
            string[] palabras1 = { "inicio", "final", "si", "entonces", "para", "mientras", "hacer", "leer", "escribir" };
            string[] palabras2 = { "Auto", "Break", "Swicth", "Case", "Char", "Continue", " Default", "do", "while", "if", "else", "Return" };

            if (checkBoxLenguaje.Checked)
            {
                foreach (var a in palabras1)
                {
                    pattern += a + "|";
                }
            }
            else
            {
                foreach (var a in palabras2)
                {
                    pattern += a + "|";
                }
            }



            Regex R = new Regex(pattern);
            int index = txtCode.SelectionStart;

            foreach (Match m in R.Matches(txtCode.Text))
            {
                txtCode.Select(m.Index, m.Value.Length);
                txtCode.SelectionColor = Color.Blue;
                txtCode.SelectionStart = index;
            }

            txtCode.SelectionColor = Color.White;
        }


        //Al modificar el codigo se llena automaticamente la tabla de simbolos
        private void txtCode_TextChanged_1(object sender, EventArgs e)
        {
            limpiarTokens();
            tokens();
            colores();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
