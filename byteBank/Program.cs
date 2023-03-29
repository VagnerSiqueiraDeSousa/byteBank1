using bytebank.Contas;
using bytebank.Titular;

/**
 * para comentar parte do condigo podemos usar o ctrl + k + c
 * 
 *´para descomentar ctrl + k + u 
 * **/

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "Andre Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;
//Console.WriteLine("Saldo da conta do André  = " + contaDoAndre.saldo);


//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "Andre Silva";
//contaDoAndre2.numero_agencia = 15;
//contaDoAndre2.conta = "1010-x";
//contaDoAndre2.saldo = 100;
//Console.WriteLine("Saldo da conta do André  = " + contaDoAndre2.saldo);

//contaDoAndre = contaDoAndre2;


//Console.WriteLine(contaDoAndre == contaDoAndre2);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);


//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);




/**
 * comentario linha daas função do bank desposita  e saque 
contaDoAndre.Depositar(201);
Console.WriteLine("Saldo da conta do André pós-Deposito = " + contaDoAndre.saldo);

if(contaDoAndre.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta do André pós-saque = " + contaDoAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para saque.");
}
**/




//Cliente cliente = new Cliente();
//cliente.nome = "Cravo Rosa";
//cliente.cpf = "78945612301";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-x";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão " + conta.titular.profissao);
//Console.WriteLine("nº Conta = " + conta.conta);
//Console.WriteLine("nº Agência = " + conta.numero_agencia);
//Console.WriteLine("Saldo = " + conta.saldo);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "Inocencio Silva";
//conta2.titular.cpf = "14785236901";
//conta2.titular.profissao = "QA";
//conta2.conta = "9874-x";
//conta2.numero_agencia = 15;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo (200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-x");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

//ContaCorrente conta5 = new ContaCorrente(283, "1234-x");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta6 = new ContaCorrente(284, "9874-z");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta7 = new ContaCorrente(285, "9875-x");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//Console.WriteLine();

//Cliente cliente1 = new Cliente("Rude", "32145678901");
//Console.WriteLine(Cliente.TotalDeClientesCriados);

//Cliente cliente2 = new Cliente("Rude", "22145678901");
//Console.WriteLine(Cliente.TotalDeClientesCriados);

//Cliente cliente3 = new Cliente("Rude", "12145678901");
//Console.WriteLine(Cliente.TotalDeClientesCriados);

//Cliente sarah = new Cliente();
//sarah.Nome = "Sarah Silva";
//sarah.Profissao = "Professora";
//sarah.Cpf = "11111111-12";

//Cliente ester = new Cliente();
//ester.Nome = "Ester Almeida";
//ester.Profissao = "Advogada";
//ester.Cpf = "868524125-32";

//Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

//ContaCorrente contaAndre = new(159, "152869-x");
//contaAndre.Titular = new Cliente();
//contaAndre.Titular.Nome = " André Pereira";
//contaAndre.Titular.Profissao = "Auxiliar Administrativo";
//contaAndre.Saldo = 100;

//Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados );

ContaCorrente contaCorrente1 = new("Joaquim", "78945613201", "Program", 18, "4545-x");
ContaCorrente contacorrente2 = new("Maria", "78945612301", "Artista", 18, "4646-z");
Console.WriteLine("Nome: " + contaCorrente1.Titular.Nome + "\r\n" + "CPF: " + contaCorrente1.Titular.Cpf + "\r\n" +
    contaCorrente1.Conta + "-" + contaCorrente1.Numero_agencia);

Console.WriteLine();

Console.WriteLine("Nome: " + contacorrente2.Titular.Nome + "\r\n" + "CPF: " + contacorrente2.Titular.Cpf + "\r\n" +
    contacorrente2.Conta + "-" + contacorrente2.Numero_agencia);
Console.WriteLine();
Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

Console.WriteLine();
Console.WriteLine("Pressione entre para sair");
Console.ReadKey();
