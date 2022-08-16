using ByteBank;

Console.WriteLine("Boas vindas ao banco ByteBank!");

ContaCorrente conta1 = new ContaCorrente("Heloisa Busquim", "12345-5", 123, "agencia central", 250.00);
ContaCorrente conta2 = new ContaCorrente("Maria Eduarda", "12345-3", 234, "agencia norte", 300.00);

//Teste para operacoes sacar, depositar e transferir com valores abaixo do saldo atual

Console.WriteLine("Saldo anterior da conta: " + conta1.numero_conta + " é de: " + conta1.saldo);
Console.WriteLine("Saldo anterior da conta: " + conta2.numero_conta + " é de: " + conta2.saldo);

conta1.Sacar(50); //conta1 = 200, conta2 = 300
conta2.Depositar(100); //conta1 = 200, conta2 = 400
conta2.Transferir(150, conta1); //conta1 = 350, conta2 = 250

Console.WriteLine("Saldo atual da conta: " + conta1.numero_conta + " é de: " + conta1.saldo);
Console.WriteLine("Saldo atual da conta: " + conta2.numero_conta + " é de: " + conta2.saldo);


ContaCorrente conta3 = new ContaCorrente("Felipe Duarte", "12345-6", 145, "agencia sul", 50.00);
ContaCorrente conta4 = new ContaCorrente("Natasha Alencar", "12345-9", 567, "agencia leste", 100.00);

Console.WriteLine("********************************************");


//Teste para operacoes sacar, depositar e transferir com valores acima do saldo atual

Console.WriteLine("Saldo anterior da conta: " + conta3.numero_conta + " é de: " + conta3.saldo);
Console.WriteLine("Saldo anterior da conta: " + conta4.numero_conta + " é de: " + conta4.saldo);

conta3.Sacar(300); //conta1 = 50, conta2 = 100
conta4.Depositar(50); //conta1 = 50, conta2 = 150
conta4.Transferir(400, conta1); //conta1 = 50, conta2 = 150

Console.WriteLine("Saldo atual da conta: " + conta3.numero_conta + " é de: " + conta3.saldo);
Console.WriteLine("Saldo atual da conta: " + conta4.numero_conta + " é de: " + conta4.saldo);