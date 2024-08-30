Console.WriteLine($"Conta Juridica");


PessoaJuridica devCauan = new PessoaJuridica("dev_Cauan", "1031", 2500.00, "076396185000124");
devCauan.ExibirDados();


Console.WriteLine($"Conta Fisica");

PessoaFisica joao = new PessoaFisica("João", "2056", 1000.00, "00218937817");
joao.Deposit(1500);
