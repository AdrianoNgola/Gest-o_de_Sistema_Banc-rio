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
   
    public partial class Form1 : Form
    {
        public string Sexo ="Masculino";
        string Tipo_Conta;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Comandos para carregar as pronvicas na combBox

                // Objecto de conexao da base de dados
                SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");

                // Objecto que leva os comando para base de dados
                SqlCommand Comando = new SqlCommand($"select *from Provincia", Conector);

                // Objecto que traz os dados da tabela Provincia
                SqlDataAdapter adaptador = new SqlDataAdapter(Comando);

                // Objecto que recebe os dados da tabela Provincia
                DataTable tabela = new DataTable();

                // Linha de codigo que preenche objecto tabela1 com os dados da tabela Provincia
                adaptador.Fill(tabela);
                cbxProvincia.DataSource = tabela;
                cbxProvincia.DisplayMember = "Nome";
                cbxProvincia.ValueMember = "Id_Provincia";


                //Comandos para carregar os Gestores na combBox

                // Objecto que leva os comando para base de dados
                SqlCommand Comando1 = new SqlCommand($"select *from Administrador", Conector);

                SqlDataAdapter adaptador1 = new SqlDataAdapter(Comando1);
                DataTable tabela1 = new DataTable();

                // Linha de codigo que preenche objecto tabela1 com os dados da tabela Administrador
                adaptador1.Fill(tabela1);
                cbxGestor.DataSource = tabela1;
                cbxGestor.DisplayMember = "Nome";
                cbxGestor.ValueMember = "Cod_Admin";



                //Estrutura de repiticao para gerar o numero de conta
                Random numero = new Random();
                for (int i = 0; i < 10; i++)
                {
                    txtNConta.Text += numero.Next(1, 10);
                }

                //Estrutura de repiticao para gerar o IBAN de conta
                for (int i = 0; i < 10; i++)
                {
                    txtIban.Text += numero.Next(1, 10);
                }
            }
           catch (Exception Ex)
            {

               MessageBox.Show($"{Ex}");
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            {
                //Botao para cadastrar cliente

                //Instancia do objecto cliente
                Clientes Cliente1 = new Clientes(Convert.ToInt32(txtBI.Text), txtNome.Text, txtSobrenome.Text,Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(txtBI.Text), Sexo, Convert.ToInt64(txtNTelefone.Text), Convert.ToInt32(cbxMunicipio.SelectedValue));

                //Instancia do objecto Conta
                Contas Conta = new Contas(Cliente1, Convert.ToInt16(cbxGestor.SelectedValue), Convert.ToInt64(txtNConta.Text), Convert.ToInt64(txtIban.Text), Tipo_Conta, Convert.ToDecimal(txtSaldo.Text), Convert.ToDateTime(dateTimePicker3.Text));

                //Metodo Abrir conta do objecto conta
                Conta.AbrirConta();

                MessageBox.Show("CLiente cadastrado com sucesso");

                Reservada RA = new Reservada();
                RA.ShowDialog();
                this.Hide();
            }
            //catch (Exception Ex)
            {

                MessageBox.Show($"Todos os campos precisam estar bem preenchidos!");
            }
        }


        private void rdb_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            // radiobutton para escolher a sexo Masculino
            rdb_Masculino.Text = "Masculino";
            Sexo = "M";
        }

        private void rdb_Feminino_CheckedChanged(object sender, EventArgs e)
        {
            // radiobutton para escolher a sexo Femenino
            rdb_Feminino.Text = "Femenino";
            Sexo = "F";
        }

        private void rdb_Corrente_CheckedChanged(object sender, EventArgs e)
        {
            
            // radiobutton para escolher a conta do tipo Corrente
            rdb_Corrente.Text = "Corrente";
            Tipo_Conta = "Corrente";
        }

        private void rdb_Poupanca_CheckedChanged(object sender, EventArgs e)
        {
            // radiobutton para escolher a conta do tipo Poupanca
            rdb_Poupanca.Text = "Poupança";
            Tipo_Conta =rdb_Poupanca.Text;
        }

        private void cbxProvincia_DropDownClosed(object sender, EventArgs e)
        {
            try
            {

                //Comandos para carregar os Municipios na combBox
                SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");
                SqlCommand Comando = new SqlCommand($"select *from Municipio where Id_Provincia = {cbxProvincia.SelectedValue.ToString()}", Conector);
                SqlDataAdapter adaptador = new SqlDataAdapter(Comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);

                cbxMunicipio.DataSource = tabela;
                cbxMunicipio.DisplayMember = "Nome";
                cbxMunicipio.ValueMember = "Id_Municipio";

            }
            catch (Exception Ex)
            {

                MessageBox.Show($"{Ex}");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TRANSACOES Transa = new TRANSACOES();
            Transa.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
