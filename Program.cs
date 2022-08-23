﻿using OO.ByteBank;
using OO.ByteBank.titular;
using OO.ByteBank.titular.cliente;
using Heranca.ByteBank_ADM.Funcionarios;
using Heranca.ByteBank_ADM.Utilitario;
using Heranca.OperacoesMatematicas.Basicas;
using Heranca.OperacoesMatematicas.Utilitario;
using OO.Delivery;
using Heranca.Library;
using Heranca.ByteBank_ADM.SistemaInterno;
using Heranca.ByteBank_ADM.Parceiro;

// //********************************************************************************************************
// // O R I E N T A Ç Ã O  A  O B J E T O S 


// //ByteBank

// Console.WriteLine("Boas vindas ao banco ByteBank!");

// //Populando contas
// ContaCorrente conta1 = new ContaCorrente(123, "12345-5", "agencia central");
// conta1.titular = new Cliente("Helena Maria", "123.456.789-00");

// ContaCorrente conta2 = new ContaCorrente(234, "12345-3", "agencia norte");
// conta2.titular = new Cliente("Natasha Romanov", "987.654.321.00");

// ContaCorrente conta3 = new ContaCorrente(145, "12345-6", "agencia sul");
// conta3.titular = new Cliente("Fernando Silva", "345.256.755-44");

// ContaCorrente conta4 = new ContaCorrente(567, "12345-9", "agencia leste");
// conta4.titular = new Cliente("Maria Eduarda", "985.334.221-76");

// //informações da conta
// conta1.InformacoesConta();
// conta2.InformacoesConta();
// conta3.InformacoesConta();
// conta4.InformacoesConta();

// Console.WriteLine("********************************************");

// //total de contas criadas
// Console.WriteLine("O número total de contas criadas é de: " + ContaCorrente.TotalContasCriadas);

// Console.WriteLine("********************************************");

// //total de clientes cadastrados
// Console.WriteLine("O número total de clientes cadastrados é de: " + Cliente.TotalClientesCadastrados);

// Console.WriteLine("********************************************");

// //Método depositar
// conta1.Depositar(250);
// conta2.Depositar(300);
// conta3.Depositar(50);
// conta4.Depositar(100);

// Console.WriteLine("********************************************");

// //Métodos sacar e transferir com valores ABAIXO do saldo atual
// conta1.Sacar(50); //conta1 = 200, conta2 = 300
// conta2.Transferir(150, conta1); //conta1 = 350, conta2 = 150

// Console.WriteLine("********************************************");

// //Métodos sacar, depositar e transferir com valores acima do saldo atual

// conta3.Sacar(300); //conta3 = 50, conta4 = 100
// conta4.Transferir(400, conta1); //conta3 = 50, conta4 = 100

// Console.WriteLine("********************************************");



// //********************************************************************************************************



// //Delivery

// Console.WriteLine("Boas vindas ao sistema de delivery!");

// // //Populando produtos
// Produto combo1 = new Produto(1);
// Produto combo2 = new Produto(2);
// Produto combo3 = new Produto(3);

// // //Populando clientes e endereços
// Contato cliente1 = new Contato("Helena Maria", "123.456.789-00", "(19)3456-2345");
// cliente1.endereco = new Endereco("Rua 15", "34A", "", "Jardim Souzas", "Americana", "13456-234");

// Contato cliente2 = new Contato("Natasha Romanov", "987.654.321.00", "(19)3451-8769");
// cliente2.endereco = new Endereco("Rua 89", "234", "Apto 23-A", "Jardim Amaranto", "Sumaré", "15478-231");

// //Recebendo pedidos
// //Pedido 1 - endereço sem complemento, quantidade = 1
// Pedido um = new Pedido();
// um.numeroComanda = 1;
// Console.WriteLine("Número da comanda: " + um.numeroComanda);
// um.cliente = cliente1;
// um.item = combo1;
// um.item.quantidadeSolicitada = 1;
// um.cliente.DadosCliente();
// um.cliente.endereco.Entrega();
// um.item.InfoCombos();

// Console.WriteLine("********************************************");

// //Pedido 2 - endereço com complemento, quantidade > 1
// Pedido dois = new Pedido();
// dois.numeroComanda = 2;
// Console.WriteLine("Número da comanda: " + dois.numeroComanda);
// dois.cliente = cliente2;
// dois.item = combo1;
// dois.item.quantidadeSolicitada = 1;
// dois.cliente.DadosCliente();
// dois.cliente.endereco.Entrega();
// dois.item.InfoCombos();

// /*IMPROVEMENTS:
// 1- Criar método que gere número de comandas automaticamente, de forma sequencial e sem repetições;
// 2- Criar uma forma do pedido poder ter mais itens distintos, não apenas um combo em específico;
// */




// //**************************************************************************************************************




// //H E R A N Ç A  E  C L A S S E  A B S T R A T A

// //ByteBank_ADM
// Console.WriteLine("Boas vindas ao ByteBank Administrativo!");

// CalcularBonificação();

// void CalcularBonificação()
// {
//     GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

//     Designer pedro = new Designer("Pedro Silva", "234.564.343-09");

//     Diretor maria = new Diretor("Maria Alencar", "124.899.566.78");

//     Auxiliar jose = new Auxiliar("José Alves", "234.234.222.98");

//     Gerente camila = new Gerente("Camila Oliveira", "345.678.543-32");

//     gerenciador.Registrar(pedro);
//     gerenciador.Registrar(maria);
//     gerenciador.Registrar(jose);
//     gerenciador.Registrar(camila);

//     Console.WriteLine("O número de funcionários registrados é: " + Funcionario.TotalFuncionarios);
//     Console.WriteLine("O total de bonificações é de: " + gerenciador.GetTotalBonificacao());
// }




// //Gerando autenticação com senha
// LogarSistema();

// void LogarSistema()
// {
//     SistemaInterno sistemaInterno = new SistemaInterno();

//     Diretor maria = new Diretor("Maria Alencar", "124.899.566.78");
//     maria.User = "malencar";
//     maria.Senha = "123";

//     Gerente camila = new Gerente("Camila Oliveira", "345.678.543-32");
//     camila.User = "coliveira";
//     camila.Senha = "456";

//     //utilizando interface IAutenticador
//     ParceiroComercial carlos = new ParceiroComercial();
//     carlos.User = "csilva";
//     carlos.Senha = "398";

//     sistemaInterno.Logar(maria, "malencar", "123"); //deve retornar true
//     sistemaInterno.Logar(camila, "coliveira", "789"); //deve retornar false
//     sistemaInterno.Logar(carlos, "csilva", "398"); //deve retornar true


// }




// //*********************************************************************************************




// //Operaçõess Matemáticas

// Operacoes operacoes = new Operacoes();
// Console.WriteLine("Somando valores... o resultado é:  " + operacoes.somar.Calcular(15,24));
// Console.WriteLine("Subtraindo valores... o resultado é:  " + operacoes.subtrair.Calcular(10,56));
// Console.WriteLine("Multiplicando valores... o resultado é:  " + operacoes.multiplicar.Calcular(87,198));
// Console.WriteLine("Dividindo valores... o resultado é:  " + operacoes.dividir.Calcular(99,33));




// //*************************************************************************************************




// //Library
// Fantasia lotr1 = new Fantasia("O Senhor dos Aneis: A Sociedade do Anel", "J. R. R. Tolkien", "9788533613379");
// lotr1.anoPublicacao = 2010;
// lotr1.numeroPaginas = 434;
// lotr1.FichaLivro();

// Fantasia lotr2 = new Fantasia("O Senhor dos Aneis: As duas Torres", "J. R. R. Tolkien", "9788533613386");
// lotr2.FichaLivro();

// Console.WriteLine("O número de livros registrados é: " + Livro.TotalLivrosRegistrados);