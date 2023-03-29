using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    internal class ContaCorrente
    {
        public static int TotalDeContasCriadas { get;  set; }

        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                 if(value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }


        public string Conta { get; set; }

        private double saldo;

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                if(value > 0)
                {
                    this.saldo = value;
                }
                else
                {
                    return;
                }
            }
        }


        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(string nome_titular, string cpf_titular, string profissao_titular, int numero_agercia, string numero_conta)
        {
            this.Numero_agencia = numero_agercia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;

            this.Titular = new Cliente(nome_titular, cpf_titular, profissao_titular);
        }

       


    }
}
