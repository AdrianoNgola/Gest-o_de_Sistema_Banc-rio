using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
           //try
            {
              
                
                if (Transacao == radioButton1.Text)
                {

                    Conta.Deposito(Convert.ToInt64(txtNConta.Text), Convert.ToDecimal(txtQuantia.Text));

                    
                    Conta.Transacoes("Depósito", Convert.ToInt64(txtNConta.Text), Convert.ToDecimal(txtQuantia.Text));
                }


                else if (Transacao == radioButton2.Text)
                {


                    Conta.Levantamento(Convert.ToInt64(txtNConta.Text), Convert.ToDecimal(txtQuantia.Text));

                    Conta.Transacoes("Levantamento", Convert.ToInt64(txtNConta.Text), Convert.ToDecimal(txtQuantia.Text));
                }
                else
                {
                    Conta.Transferias(Convert.ToInt64(txtNConta.Text), Convert.ToInt64(txtIBAN.Text), Convert.ToDecimal(txtQuantia.Text));

                    Conta.Transacoes("Transferência", Convert.ToInt64(txtNConta.Text), Convert.ToDecimal(txtQuantia.Text));
                }


            }
           // catch (Exception Ex)
            {

               // MessageBox.Show($"Precisa preencher todos os campos!" + Ex);
            }


            // Informaçoes das Transacoes
            SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");

            SqlCommand Comando = new SqlCommand($"Select *from Transacoes", Conector);
            Conector.Open();
            SqlDataAdapter Adpatador = new SqlDataAdapter(Comando);
            DataTable Tabela = new DataTable();
            Adpatador.Fill(Tabela);

            dataGridView1.DataSource = Tabela;

        }

        private void TRANSACOES_Load(object sender, EventArgs e)
        {
            try
            {


                // Informaçoes das Transacoes
                SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");

                SqlCommand Comando = new SqlCommand($"Select *from Transacoes", Conector);
                Conector.Open();
                SqlDataAdapter Adpatador = new SqlDataAdapter(Comando);
                DataTable Tabela = new DataTable();
                Adpatador.Fill(Tabela);

                dataGridView1.DataSource = Tabela;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtIBAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (Transacao == radioButton1.Text)
                {
                    //Comandos para carregar os Gestores na combBox

                    // Objecto que leva os comando para base de dados
                    SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");
                    SqlCommand Comando = new SqlCommand($"select BI from Conta where Numero_Conta={Convert.ToInt64(txtNConta.Text)}", Conector);

                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable tabela = new DataTable();

                    // Linha de codigo que preenche objecto tabela1 com os dados da tabela Administrador
                    adaptador.Fill(tabela);
                    comboBox2.DataSource = tabela;
                    comboBox2.DisplayMember = "BI";



                    SqlCommand Comando1 = new SqlCommand($"select Nome from Clientes where BI={Convert.ToInt64(comboBox2.Text)}", Conector);

                    SqlDataAdapter adaptador1 = new SqlDataAdapter(Comando1);
                    DataTable tabela1 = new DataTable();

                    // Linha de codigo que preenche objecto tabela1 com os dados da tabela Administrador
                    adaptador1.Fill(tabela1);
                    comboBox1.DataSource = tabela1;
                    comboBox1.DisplayMember = "Nome";

                    textQuantia_2.Text = txtQuantia.Text;


                }
                else if (Transacao == radioButton2.Text)
                {

                    //Comandos para carregar os Gestores na combBox

                    // Objecto que leva os comando para base de dados
                    SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");
                    SqlCommand Comando = new SqlCommand($"select BI from Conta where Numero_Conta={Convert.ToInt64(txtNConta.Text)}", Conector);

                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable tabela = new DataTable();

                    // Linha de codigo que preenche objecto tabela1 com os dados da tabela Administrador
                    adaptador.Fill(tabela);
                    comboBox2.DataSource = tabela;
                    comboBox2.DisplayMember = "BI";



                    SqlCommand Comando1 = new SqlCommand($"select Nome from Clientes where BI={Convert.ToInt64(comboBox2.Text)}", Conector);

                    SqlDataAdapter adaptador1 = new SqlDataAdapter(Comando1);
                    DataTable tabela1 = new DataTable();

                    // Linha de codigo que preenche objecto tabela1 com os dados da tabela Administrador
                    adaptador1.Fill(tabela1);
                    comboBox1.DataSource = tabela1;
                    comboBox1.DisplayMember = "Nome";

                    textQuantia_2.Text = txtQuantia.Text;


                }
                else
                {

                    //Comandos para carregar os Gestores na combBox

                    // Objecto que leva os comando para base de dados
                    SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");
                    SqlCommand Comando = new SqlCommand($"select BI from Conta where IBAN={Convert.ToInt64(txtIBAN.Text)}", Conector);

                    SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                    DataTable tabela = new DataTable();

                    // Linha de codigo que preenche objecto tabela1 com os dados da tabela Administrador
                    adaptador.Fill(tabela);
                    comboBox2.DataSource = tabela;
                    comboBox2.DisplayMember = "BI";



                    SqlCommand Comando1 = new SqlCommand($"select Nome from Clientes where BI={Convert.ToInt64(comboBox2.Text)}", Conector);

                    SqlDataAdapter adaptador1 = new SqlDataAdapter(Comando1);
                    DataTable tabela1 = new DataTable();

                    // Linha de codigo que preenche objecto tabela1 com os dados da tabela Administrador
                    adaptador1.Fill(tabela1);
                    comboBox1.DataSource = tabela1;
                    comboBox1.DisplayMember = "Nome";

                    textQuantia_2.Text = txtQuantia.Text;

                }
            }
            catch (Exception)
            {

                MessageBox.Show($"Precisa preencher todos os campos!");
            }

           


            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtIBAN.Text = " ";
            txtQuantia.Text = " ";
            txtNConta.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textQuantia_2.Text = " ";
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");
                SqlCommand Comando_3 = new SqlCommand($"Select * from Transacoes where Numero_Conta ='{Convert.ToInt32(txtPesquisa.Text)}'", Conector);

                SqlDataAdapter Adpatador_3 = new SqlDataAdapter(Comando_3);
                DataTable Tabela_Cliente = new DataTable();
                Adpatador_3.Fill(Tabela_Cliente);

                dataGridView1.DataSource = Tabela_Cliente;
            }
            catch (Exception)
            {

                MessageBox.Show("Digite o número de conta");
            }


           
        }
    }
}
