using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpCalculadora;

namespace TpCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.SelectedIndex = 0;
        }

        private static Double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            double resultado;

            resultado = Calculadora.Operar(num1, num2, operador);

            return resultado;
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {   
            double resultado = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, cmbOperador.Text);

            this.lblResultado.Text = resultado.ToString();
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.ResetText();
            this.lblResultado.Text = "Resultado";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro que desea salir?", "Atención",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.Yes)
            {
                e.Cancel = false;
            }else
            {
                e.Cancel = true;
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            string num = this.lblResultado.Text;
            string binario = numero.DecimalBinario(num);
            this.lblResultado.Text = binario;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            string num = this.lblResultado.Text;
            string binario = numero.BinarioDecimal(num);
            this.lblResultado.Text = binario;
        }
    }
}
