using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Sistema_Bancário
{
    class Clientes : Pessoa
    {
        public int Contacto { get; set; }
        public Clientes(int BI, string nome, string sobrenome, DateTime datanascimento, int bi, string sexo, int contacto, int IdMunicipio) : base (BI, nome, sobrenome, datanascimento, bi, sexo, IdMunicipio)
        {
            this.Contacto = contacto;
        }
        public Clientes()
        {

        }
       
    }
}
