using Cadastro___Encontro_R2.Classes;

Console.WriteLine(@$"
==============================================
|    Bem vindo ao sistema de cadastro de     |
|       Pessoas Físicas e Jurídicas          |
==============================================
");

    BarraCarregamento("Iniciando", 100, 40);
string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
==============================================
|         Escolha uma das opções abaixo      |
|--------------------------------------------|
|         1 - Pessoa Física                  |
|         2 - Pessoa Jurídica                |
|                                            |
|         0 - Sair                           |
==============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
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

            Console.Clear();
            Console.WriteLine(@$"
    Nome: {novaPf.Nome}
    Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
    ");

            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            break;

        case "2":
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

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.logradouro}, Nº: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");

            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            break;
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema");
            Thread.Sleep(3000);
            BarraCarregamento("Finalizando", 500, 6);
            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo, int quantidade);

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;

Console.Write(texto);

for (var contador = 0; contador < 6; contador++)
{
    Console.Write(".");
    Thread.Sleep(tempo);
}
Console.ResetColor();


// Console.WriteLine($"Nome: {novaPF.Nome} Nome: {novaPF.Nome}");
// Console.WriteLine("Nome" + novaPF.Nome + " Nome: " + novaPF.Nome);