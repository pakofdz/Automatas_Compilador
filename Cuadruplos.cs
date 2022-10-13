using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatas_Compilador
{
    public class Cuadruplos
    {
        private String name,operador, firstOperand, secondOperand,
        firstOperandValue, secondOperandValue;


        public Cuadruplos(String n, String op, String opn1, String opn2)
        {
            name = n;
		    operador = op;
            firstOperand = opn1;
            secondOperand = opn2;
        }

        public Cuadruplos(String n, String op, String opn1, String opn2, String opn1v, String opn2v)
        {
            name = n;
		    operador = op;
            firstOperand = opn1;
            secondOperand = opn2;
            firstOperandValue = opn1v;
            secondOperandValue = opn2v;
        }

        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getOperator()
        {
            return operador;
        }
        public void setOperator(String operador)
        {
            this.operador = operador;
        }
        public String getFirstOperand()
        {
            return firstOperand;
        }
        public void setFirstOperand(String firstOperand)
        {
            this.firstOperand = firstOperand;
        }
        public String getSecondOperand()
        {
            return secondOperand;
        }
        public void setSecondOperand(String secondOperand)
        {
            this.secondOperand = secondOperand;
        }
        public String getFirstOperandValue()
        {
            return firstOperandValue;
        }
        public void setFirstOperandValue(String firstOperandValue)
        {
            this.firstOperandValue = firstOperandValue;
        }
        public String getSecondOperandValue()
        {
            return secondOperandValue;
        }
        public void setSecondOperandValue(String secondOperandValue)
        {
            this.secondOperandValue = secondOperandValue;
        }
    }
}
