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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Informaçoes das Contas
            SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");

            SqlCommand Comando = new SqlCommand($"Select *from Conta", Conector);
            Conector.Open();
            SqlDataAdapter Adpatador = new SqlDataAdapter(Comando);
            DataTable Tabela = new DataTable();
            Adpatador.Fill(Tabela);

            dataGridView1.DataSource = Tabela;

            

            // Informaçoes dos clientes
            SqlCommand Comando_2 = new SqlCommand($"Select *from Clientes", Conector);
            
            SqlDataAdapter Adpatador_2 = new SqlDataAdapter(Comando_2);
            DataTable Tabela_2 = new DataTable();
            Adpatador_2.Fill(Tabela_2);

            dataGridView2.DataSource = Tabela_2;

            Conector.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");

            SqlCommand Comando = new SqlCommand($"Select *from Conta where Numero_Conta ='{Convert.ToInt64( textConsulta.Text)}'", Conector);
            Conector.Open();
            SqlDataAdapter Adpatador = new SqlDataAdapter(Comando);
            DataTable Tabela = new DataTable();
            Adpatador.Fill(Tabela);

            dataGridView1.DataSource = Tabela;


           

            SqlCommand Comando_1 = new SqlCommand($"select Saldo from Conta where Numero_Conta ='{Convert.ToInt64(textConsulta.Text)}'", Conector);
            
            SqlDataAdapter Adpatador_1 = new SqlDataAdapter(Comando_1);
            DataTable Saldo = new DataTable();
            Adpatador_1.Fill(Saldo);

            
            comboBox1.DataSource = Saldo;
            comboBox1.DisplayMember = $"Saldo";
            
            
            SqlCommand Comando_2 = new SqlCommand($"select BI from Conta where Numero_Conta ='{Convert.ToInt64(textConsulta.Text)}'", Conector);

            SqlDataAdapter Adpatador_2 = new SqlDataAdapter(Comando_2);
            DataTable BI = new DataTable();
            Adpatador_2.Fill(BI);


            comboBox2.DataSource = BI;
            comboBox2.DisplayMember = $"BI";

            SqlCommand Comando_3 = new SqlCommand($"Select * from Clientes where BI ='{Convert.ToInt32(comboBox2.Text)}'", Conector);

            SqlDataAdapter Adpatador_3 = new SqlDataAdapter(Comando_3);
            DataTable Tabela_Cliente = new DataTable();
            Adpatador_3.Fill(Tabela_Cliente);

            dataGridView2.DataSource = Tabela_Cliente;


            Conector.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");

            SqlCommand Comando_1 = new SqlCommand($"select Saldo from Conta where Numero_Conta ='{Convert.ToInt64( textConsulta.Text)}'", Conector);
            Conector.Open();
            SqlDataAdapter Adpatador_1 = new SqlDataAdapter(Comando_1);
            DataTable Saldo_Conta = new DataTable();
            Adpatador_1.Fill(Saldo_Conta);

            comboBox1.DataSource = Saldo_Conta;
            comboBox1.DisplayMember = "Saldo";

            

            Contas Conta = new Contas();
            Conta.FecharConta(Convert.ToInt64(textConsulta.Text), Convert.ToDecimal(comboBox1.Text));

            SqlCommand Comando = new SqlCommand($"Select *from Conta", Conector);
            
            SqlDataAdapter Adpatador = new SqlDataAdapter(Comando);
            DataTable Tabela = new DataTable();
            Adpatador.Fill(Tabela);

            dataGridView1.DataSource = Tabela;

            SqlCommand Comando_2 = new SqlCommand($"Select *from Clientes", Conector);

            SqlDataAdapter Adpatador_2 = new SqlDataAdapter(Comando_2);
            DataTable Tabela_2 = new DataTable();
            Adpatador_2.Fill(Tabela_2);

            dataGridView2.DataSource = Tabela_2;


            Conector.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textSaldo_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
