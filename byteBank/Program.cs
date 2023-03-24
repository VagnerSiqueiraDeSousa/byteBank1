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

ContaCorrente conta3 = new ContaCorrente();
conta3.SetSaldo (200);
Console.WriteLine(conta3.GetSaldo());



Console.WriteLine();
Console.WriteLine("Pressione entre para sair");
Console.ReadKey();
