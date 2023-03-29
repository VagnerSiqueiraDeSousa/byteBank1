using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }


        public static int TotalClientesCadastrados { get; set; }

        public Cliente(string nome_titular, string cpf_titular, string profissao_titular)
        {
            this.Nome = nome_titular;
            this.Cpf = cpf_titular;
            this.Profissao = profissao_titular;

            TotalClientesCadastrados++;
        }

      
    }
}
