using ByteBank;

Console.WriteLine("Boas vindas ao banco ByteBank!");

ContaCorrente conta1 = new ContaCorrente();

    conta1.titular = "Heloisa Busquim";
    conta1.numero_agencia = 0345;
    conta1.numero_conta = "123345-6";
    conta1.nome_agencia = "Campinas Bank";
    conta1.saldo = 250.00;

    Console.WriteLine("Titular:" + conta1.titular);
    Console.WriteLine("Agência:" + conta1.numero_agencia);
    Console.WriteLine("Conta:" + conta1.numero_conta);
    Console.WriteLine("Nome da agência:" + conta1.nome_agencia);
    Console.WriteLine("Saldo:" + conta1.saldo);
