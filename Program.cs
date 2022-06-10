using Cadastro___Encontro_R2.Classes;

// PessoaFisica novaPf = new PessoaFisica();
// PessoaFisica metodosPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPf.Nome = "Alex";
// novaPf.dataNasc = new DateTime(2000, 01, 01);
// novaPf.cpf = "1234567890";
// novaPf.Rendimento = 3500;

// novoEndPf.logradouro = "Alameda barao de limeira";
// novoEndPf.numero = 539;
// novoEndPf.complemento = "Senai informatica";
// novoEndPf.endComercial = true;

// novaPf.Endereco = novoEndPf;

// Console.WriteLine(@$"
// Nome: {novaPf.Nome}
// Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
// ");

//Console.WriteLine($"Nome: {novaPF.Nome} Nome: {novaPF.Nome}");
//Console.WriteLine("Nome" + novaPF.Nome + " Nome: " + novaPF.Nome);

PessoaJuridica novaPj = new PessoaJuridica();
PessoaJuridica metodosPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.Nome = "Nome Pj";
novaPj.RazaoSocial = "Razao Social Pj";
novaPj.Cnpj = "00.000.000/0001-00";
novaPj.Rendimento = 10000.5f;

novoEndPj.logradouro = "Alameda Barão de Limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "SENAI Informatica";
novoEndPj.endComercial = true;

novaPj.Endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.logradouro}, Nº: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");


