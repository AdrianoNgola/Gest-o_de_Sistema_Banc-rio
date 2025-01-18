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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == comboBox1.SelectedValue.ToString())
            {
                Reservada reservadoo = new Reservada();
                this.Hide();
                reservadoo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Código Inválido!");
            }

           
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");
            SqlCommand Comando1 = new SqlCommand($"select *from Administrador", Conector);

            SqlDataAdapter adaptador1 = new SqlDataAdapter(Comando1);
            DataTable tabela1 = new DataTable();

            // Linha de codigo que preenche objecto tabela1 com os dados da tabela Administrador
            adaptador1.Fill(tabela1);
            comboBox1.DataSource = tabela1;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Cod_Admin";
        }
    }
}
