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
    public partial class Reservada : Form
    {
        public Reservada()
        {
            InitializeComponent();
        }

        private void Reservada_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cadastrar = new Form1();
            
            cadastrar.ShowDialog();
            cadastrar.Hide();
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
    }
}
