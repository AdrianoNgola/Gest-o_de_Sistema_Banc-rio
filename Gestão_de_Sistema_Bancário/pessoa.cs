using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Sistema_Bancário
{
    abstract class  Pessoa
    {
       
         public string Nome { get; set; }
         public string SobreNome { get; set; }
        public string NomeCompleto { get; }
        public string sexo { get; set; }
        public DateTime  DataNascimento { get; set; }
        public int Idade { get; }
        public int BI { get; set; }
        public int IDMunicipio { get;}

        public Pessoa(int BI_Cliente, string nome, string sobrenome, DateTime datanascimento, int bi, string sexo, int IdMunicipio)
        {
            this.BI =BI_Cliente;
            this.Nome = nome;
            this.SobreNome = sobrenome;
            this.NomeCompleto = $"{Nome} {SobreNome}";
            this.sexo = sexo;
            this.DataNascimento = datanascimento;
            this.IDMunicipio = IdMunicipio;
            
            
            this.Idade = Convert.ToInt16(DateTime.Now.Year) - Convert.ToInt16(datanascimento.ToString("yyyy"));
        }

        public Pessoa()
        {

        }


    }


}
