using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TpCalculadora
{
    class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)
        {
            this.SetNumero(strNumero);
        }
        private double ValidarNumero(string strNumero)
        {
            double num;
            bool isValidate = double.TryParse(strNumero, out num);
            if (!isValidate)
                num = 0;
            return num;
        }

        private void SetNumero(string numero)
        {
            double aux;
            aux = ValidarNumero(numero);
            this.numero = aux;
        }

        public string BinarioDecimal(string binario)
        {
            string value;
            
            if(EsBinario(binario))
            {
                value = Convert.ToInt32(binario, 2).ToString();
            }
            else
            {
                value = "Valor inválido";
            }

            return value;
        }

        public string DecimalBinario(double numero)
        {

            string num = numero.ToString();
            string value = DecimalBinario(num);

            return value;
        }

        public string DecimalBinario(string numero)
        {
            int num;
            bool isValidate = int.TryParse(numero, out num);
            string binary;

            if (isValidate)
                binary = Convert.ToString(num, 2);
            else
                binary = "Valor inválido";
            return binary;
        }

        private bool EsBinario(string binario)
        {
            bool isBin = true;
            foreach (var c in binario.ToCharArray())
            {
                if (c != '0' && c != '1')
                {
                    isBin = false;
                    break;
                }
            }
            return isBin;
        }

        public static double operator +(Numero num1, Numero num2)
        {
            double resultado;
            resultado = num1.numero + num2.numero;
            return resultado;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            double resultado;
            resultado = num1.numero - num2.numero;
            return resultado;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            double resultado;
            resultado = num1.numero * num2.numero;
            return resultado;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            double resultado;
            resultado = num1.numero / num2.numero;
            return resultado;
        }
    }
}
