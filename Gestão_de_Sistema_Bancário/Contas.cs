using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Gestão_de_Sistema_Bancário
{
    class Contas
    {
        private Clientes Cliente { get; set; }
        private int IDGestor { get; set; }
        public long NumeroConta { get; set; }
        private decimal Saldo { get; set; }
        public long  IBAN { get; set; }
        private string TipoConta { get; set; } 
        private DateTime DataAbertura { get; set; }
        private DateTime DataFechamento { get; set; }

        public Contas(Clientes cliente, int IdGestor,long numeroConta, long iban, string tipoConta, decimal saldo, DateTime dataAbertura)
        {
            this.Cliente = cliente;
            this.IDGestor = IdGestor;
            this.NumeroConta = numeroConta;
            this.IBAN = iban;
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.DataAbertura = dataAbertura;

        }
        public Contas()
        {


        }

        public void AbrirConta()
        {
                        
            if (this.Cliente.Idade <= 17)
            {
                MessageBox.Show("Idade não permitida!");
            }
            else
            {
                
                SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");
                SqlCommand Comando = new SqlCommand($"Insert into Clientes(BI, Nome, Sexo, Data_Nascimento, Id_Municipio) Values ('{Cliente.BI}','{Cliente.NomeCompleto}', '{Cliente.sexo}', '{Cliente.DataNascimento}', '{Cliente.IDMunicipio}')", Conector);

                SqlCommand Comando2 = new SqlCommand($"Insert into Conta (Numero_Conta, Saldo, BI, Cod_Admin, IBAN, Data_Abertura, Data_Fechamento, Tipo_Conta) values ('{Convert.ToInt64( this.NumeroConta)}','{this.Saldo}','{this.Cliente.BI}','{this.IDGestor}','{Convert.ToInt64( this.IBAN)}','{this.DataAbertura}','{this.DataFechamento}', '{this.TipoConta}')", Conector);
                SqlCommand Comando3 = new SqlCommand($"Insert into Contactos_Cliente(Contacto, BI_Cliente)Values('{Cliente.Contacto}', '{Cliente.BI}')", Conector);

                Conector.Open();
                Comando.ExecuteNonQuery();
                Comando2.ExecuteNonQuery();
                Comando3.ExecuteNonQuery();
                Conector.Close();

            }
        }
        public void FecharConta(long Nconta, decimal Saldo)
        {
            SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");

            SqlCommand Comando_1 = new SqlCommand($"select Saldo from Conta where Numero_Conta ='{Nconta}'", Conector);
            Conector.Open();
            SqlDataAdapter Adpatador_1 = new SqlDataAdapter(Comando_1);
            DataTable Saldo_Conta = new DataTable();
            Adpatador_1.Fill(Saldo_Conta);

            


            if (Convert.ToDecimal(Saldo) > 0)
            {
                MessageBox.Show($"Impossivel fechar a conta! Precisa retirar os {Saldo:C} antes de fechar a conta.");
            }
            else if (Saldo < 0)
            {
                MessageBox.Show($"Impossivel fechar a conta! Precisa pagar os {Saldo:C} antes de fechar a conta.");
            }
            else
            {
                SqlCommand Comando_2 = new SqlCommand($"delete from Transacoes where Numero_Conta ='{Nconta}'", Conector);
                SqlCommand Comando_3 = new SqlCommand($"delete from Conta where Numero_Conta ='{Nconta}'", Conector);
                Comando_2.ExecuteNonQuery();
                Comando_3.ExecuteNonQuery();

                

            }

           
        }
        public void Deposito(long Nconta, decimal levantamento)
        {
            this.NumeroConta = Nconta;

            SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");

            SqlCommand Comando_1 = new SqlCommand($"select Saldo from Conta where Numero_Conta ='{this.NumeroConta}'", Conector);
            Conector.Open();
            SqlDataReader Saldo_Cliente = Comando_1.ExecuteReader();

            Saldo_Cliente.Read();

            var Saldo_Actual = Saldo_Cliente["Saldo"];

            Saldo_Cliente.Close();


            decimal NovoSaldo = Convert.ToDecimal(Saldo_Actual) + levantamento;

            SqlCommand Comando_3 = new SqlCommand($"update Conta set Saldo ={NovoSaldo} where Numero_Conta ={this.NumeroConta} ", Conector);
            Comando_3.ExecuteNonQuery();

            MessageBox.Show($"DEPÓSITO DE {levantamento:c} FEITO COM SUCESSO");

            

            Conector.Close();

        }
        public void Levantamento(long Nconta, decimal levantamento)
        {
            this.NumeroConta = Nconta;
            

            SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");

            SqlCommand Comando_1 = new SqlCommand($"select Saldo from Conta where Numero_Conta ='{this.NumeroConta}'", Conector);
            Conector.Open();
            SqlDataReader Saldo_Cliente = Comando_1.ExecuteReader();

            Saldo_Cliente.Read();

            var Saldo_Actual = Saldo_Cliente["Saldo"];

            Saldo_Cliente.Close();
            

            
            
            if (Convert.ToDecimal( Saldo_Actual) >= levantamento)
            {

                decimal NovoSaldo =Convert.ToDecimal( Saldo_Actual) - levantamento;

                SqlCommand Comando_3 = new SqlCommand($"update Conta set Saldo ={NovoSaldo} where Numero_Conta ={this.NumeroConta} ", Conector);
                Comando_3.ExecuteNonQuery();

                MessageBox.Show($"LEVANTAMENTO DE {levantamento:c} FEITO COM SUCESSO");

                

                Conector.Close();
            }
            else
            {
                MessageBox.Show("SALDO INSUFICIENTE PARA EFECTUAR O LEVANTEMENTO DE " + levantamento + " KZ.");
            }
        }
        public void Transferias(long Nconta, long iban, decimal levantamento)
        {
            this.NumeroConta = Nconta;
            this.IBAN = iban;


            SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");

            SqlCommand Comando_1 = new SqlCommand($"select Saldo from Conta where Numero_Conta ='{this.NumeroConta}'", Conector);
            Conector.Open();
            SqlDataReader Saldo_Cliente = Comando_1.ExecuteReader();
            

            Saldo_Cliente.Read();
            var Saldo_Actual = Saldo_Cliente["Saldo"];
            Saldo_Cliente.Close();
           // Conector.Close();


            SqlCommand Comando_2 = new SqlCommand($"select Saldo from Conta where IBAN ='{this.IBAN}'", Conector);
            //Conector.Open();
            SqlDataReader Saldo_Cliente_2 = Comando_2.ExecuteReader();
            Saldo_Cliente_2.Read();
            var Saldo_Actual_2 = Saldo_Cliente_2["Saldo"];
            Saldo_Cliente_2.Close();
            Conector.Close();

            if (Convert.ToDecimal(Saldo_Actual) >= levantamento)
            {

                decimal NovoSaldo = Convert.ToDecimal(Saldo_Actual) - levantamento;
                decimal NovoSaldo_2 = Convert.ToDecimal(Saldo_Actual_2) + levantamento;

                SqlCommand Comando_3 = new SqlCommand($"update Conta set Saldo ={NovoSaldo} where Numero_Conta ={this.NumeroConta} ", Conector);
                Conector.Open();
                Comando_3.ExecuteNonQuery();
                Conector.Close();

                SqlCommand Comando_4 = new SqlCommand($"update Conta set Saldo ={NovoSaldo_2} where IBAN ={this.IBAN} ", Conector);
                Conector.Open();
                Comando_4.ExecuteNonQuery();
                Conector.Close();

                MessageBox.Show($"Transferência DE {levantamento:c} FEITO COM SUCESSO");

                

               
            }
            else
            {
                MessageBox.Show("SALDO INSUFICIENTE PARA EFECTUAR a Transferência DE " + levantamento + " KZ.");
            }
        }
        public void Consulta()
        {

        }
        public void Status()
        {

        }
        public void Transacoes(string Tipo_Transacao, long Nconta, decimal valor)
        {
            SqlConnection Conector = new SqlConnection($"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Bancario;Data Source=LAPTOP-1P76VB17");
            SqlCommand Comandos = new SqlCommand($"insert into Transacoes(Tipo_Transacao, Numero_conta, Data_Transacao, Valor) Values('{Tipo_Transacao}', {Nconta}, '{DateTime.Now}', {valor})", Conector);
            Conector .Open();
            Comandos.ExecuteNonQuery();
            Conector.Close();

        }
    }
}
