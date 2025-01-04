using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Sistema_Bancário
{
    public partial class TRANSACOES : Form
    {
        string Transacao;
        Contas Conta = new Contas();
        public TRANSACOES()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Transacao = "Transferência";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Transacao = "Levantamento";
            txtIBAN.Enabled = !txtIBAN.Enabled;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Transacao = "Depósito";
            txtIBAN.Enabled = !txtIBAN.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Transacao == radioButton1.Text)
            {

                Conta.Deposito(Convert.ToInt64(txtNConta.Text), Convert.ToDecimal(txtQuantia.Text));


            }


            else if (Transacao == radioButton2.Text)
            {
               

                Conta.Levantamento(Convert.ToInt64( txtNConta.Text), Convert.ToDecimal( txtQuantia.Text));

                
            }
            else
            {
                Conta.Transferias(Convert.ToInt64(txtNConta.Text), Convert.ToInt64(txtIBAN.Text), Convert.ToDecimal(txtQuantia.Text));
            }
        }

        private void TRANSACOES_Load(object sender, EventArgs e)
        {

        }
    }
}
