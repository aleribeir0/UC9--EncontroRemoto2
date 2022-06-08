using Cadastro___Encontro_R2.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaFisica metodosPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();

novaPf.Nome = "Alex";
novaPf.dataNasc = new DateTime(2000, 01, 01);
novaPf.cpf = "1234567890";
novaPf.Rendimento = 3500;

novoEndPf.logradouro = "Alameda barao de limeira";
novoEndPf.numero = 539;
novoEndPf.complemento = "Senai informatica";
novoEndPf.endComercial = true;

novaPf.Endereco = novoEndPf;

Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
");

//Console.WriteLine($"Nome: {novaPF.Nome} Nome: {novaPF.Nome}");
//Console.WriteLine("Nome" + novaPF.Nome + " Nome: " + novaPF.Nome);
