using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCalculadora
{
    class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado;
            switch (ValidarOperador(char.Parse(operador)))
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = 0;
                    break;
            }
            return resultado;
        }

        private static string ValidarOperador(char operador)
        {
            string operadorReturn;
            switch (operador)
            {
                case '-':
                    operadorReturn = "-";
                    break;
                case '*':
                    operadorReturn = "*";
                    break;
                case '/':
                    operadorReturn = "/";
                    break;
                default:
                    operadorReturn = "+";
                    break;
            }
            return operadorReturn;
        }
    }
}
