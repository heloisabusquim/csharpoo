using OO.ByteBank;
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
using StringsExpressoesRegularesClasseObjeto.ByteBank;
using System.Text.RegularExpressions;
using ArraysETiposGenericos;


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

// //Populando produtos
// Produto combo1 = new Produto(1);
// Produto combo2 = new Produto(2);
// Produto combo3 = new Produto(3);

// //Populando clientes e endereços
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



//********************************************************************************************************


//S T R I N G S  |  E X P R E S S Õ E S  R E G U L A R E S  |  C L A S S E  O B J E C T


// //Estudo sobre strings, substring e métodos.

// string url = "www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
// ExtratorArgumentosURL extrator = new ExtratorArgumentosURL(url);
// Console.WriteLine(extrator.GetValor("moedaOrigem")); //deve retornar: real
// Console.WriteLine(extrator.GetValor("moedaDestino")); //deve retornar: dolar
// Console.WriteLine(extrator.GetValor("valor")); //deve retornar 1500



// //Estudo sobre expressões regulares.

// string padraoNaoIdeal = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
// string padraoMelhorado = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
// string padraoMelhoradoAindaMais = "[0-9]{4}[-][0-9]{4}";
// string padraoIdeal = "[0-9]{4,5}-?[0-9]{4}"; //{4,5} vai puxar 4 ou 5 caracteres | para - não precisa de [] e pra identificar se tem ou não o -, usa o ?
// string texto = "meu numero de telefone é 3455-2334";

// Match resultado = Regex.Match(texto, padraoIdeal);

// Console.WriteLine(resultado.Value);

// string padraoCPF = "[0-9]{3}.?[0-9]{3}.?[0-9]{3}-?[0-9]{2}";
// string meuCPF = "234.456.654-88";
// string meuCPFSemPontos = "12345678900";

// Match resultado1 = Regex.Match(meuCPF, padraoCPF);
// Match resultado2 = Regex.Match(meuCPFSemPontos, padraoCPF);

// Console.WriteLine(resultado1.Value);
// Console.WriteLine(resultado2.Value);

// //DÚVIDAS:
// //1- Vi expressões como essa: ^\d{3}\.\d{3}\.\d{3}-\d{2}$ na internet, tentei aplicar aqui e não rolou :( , é um jeito diferente de aplicar?
// // não entendi se esse é pra encontrar o valor nesse formato ou se é pra formatar o valor encontrado nesse padrão.
// //*Aprofundar estudos aqui.




// //Classe Object
// ContaCorrente conta = new ContaCorrente(123, "334556", "agencia central");
// conta.titular = new Cliente("Ana Maria", "123.122.333-11");
// string contaToString = conta.ToString();
// Console.WriteLine(conta);

// Cliente carlos_1 = new Cliente("Carlos", "123.456.789-00");
// Cliente carlos_2 = new Cliente("Carlos", "123.456.789-00");

// Console.WriteLine(carlos_1.Equals(carlos_2)); //return true - nesse formato, está comparando os valores dos objetos e não suas referências.



//*******************************************************************************************



// //A R R A Y S  |  T I P O S  G E N É R I C O S

// //estudos com arrays
// int[] idades = new int[5];

// idades[0] = 23;
// idades[1] = 12;
// idades[2] = 67;
// idades[3] = 39;
// idades[4] = 50;

// //Improvement no array:
// int[] idades2 = new int[] {23,12,67,39,50};

// int somaIdades = 0;
// for(int indice = 0; indice < idades.Length; indice++)
// {
//     somaIdades += idades[indice];
// }
// int media = somaIdades / idades.Length;
// Console.WriteLine(media); 

//Arrays com ContaCorrente - IN PROGRESS
ListaDeContasCorrente contas = new ListaDeContasCorrente();

    ContaCorrente contaTeste = new ContaCorrente(111, "11111", "agencia 1");
    contas.Adicionar(contaTeste);

    contas.Adicionar(new ContaCorrente(123, "23345", "agencia central"));
    contas.Adicionar(new ContaCorrente(344, "2345a", "agencia sul"));

    for(int i = 0; i < contas.Tamanho; i++)
    {
        ContaCorrente itemAtual = contas.GetContaCorrenteNoIndice(i);
        Console.WriteLine($"Item na posição {i} = Conta {itemAtual.numeroConta}/{itemAtual.numeroAgencia}");
    }
