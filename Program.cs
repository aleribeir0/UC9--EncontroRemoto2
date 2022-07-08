using Cadastro___Encontro_R2.Classes;

Console.WriteLine(@$"
==============================================
|    Bem vindo ao sistema de cadastro de     |
|       Pessoas Físicas e Jurídicas          |
==============================================
");

BarraCarregamento("Iniciando", 100, 40);


List<PessoaFisica> listaPf = new List<PessoaFisica>();

List<PessoaJuridica> listaPj = new List<PessoaJuridica>();


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

            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
==============================================
|         Escolha uma das opções abaixo      |
|--------------------------------------------|
|         1 - Cadastrar Pessoa Física        |
|         2 - Listar Pessoa Física           |
|                                            |
|         0 - Voltar ao menu anterior        |
==============================================
");

                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":


                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();
                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");

                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex.: DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();

                            dataValida = metodosPf.ValidarDataNasc(dataNascimento);

                            if (dataValida)
                            {
                                DateTime.DataConvertida;
                                DateTime.TryParse(dataNascimento, out DataConvertida);

                                novaPf.dataNasc = DataConvertida;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada inválida, por favor digite uma data válida");
                                Console.ResetColor;
                                Thread.Sleep(3000);
                            }

                        } while (dataValida = false);
                        Console.WriteLine($"Digite o número do CPF");
                        novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (DIGITE SOMENTE NUMEROS");
                        novaPf.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPf.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero");
                        novoEndPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");
                        novoEndPf.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPf.endComercial = true;
                        }
                        else
                        {
                            novoEndPf.endComercial = false;
                        }


                        novaPf.Endereco = novoEndPf;

                        listaPf.Add(novaPf);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Cadastrado criado com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":

                        Console.Clear();

                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {

                                Console.Clear();
                                Console.WriteLine(@$"
    Nome: {cadaPessoa.Nome}
    Endereço: {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero}
    Imposto a ser pago: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C")}
    ");

                                Console.WriteLine($"Aperta 'ENTER' para continuar");
                                Console.ReadLine();

                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia");
                            Thread.Sleep(3000);
                        }
                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }

                Console.WriteLine($"Aperte ENTER para continuar");
                Console.ReadLine();
                break;



              case "2":


            string? opcaoPj;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
==============================================
|         Escolha uma das opções abaixo      |
|--------------------------------------------|
|         1 - Cadastrar Pessoa Jurídica      |
|         2 - Listar Pessoa Jurídica         |
|                                            |
|         0 - Voltar ao menu anterior        |
==============================================
");

                opcaoPj = Console.ReadLine();
                PessoaJuridica metodosPj = new PessoaJuridica();

                switch (opcaoPf)
                {
                    case "1":

                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();
                        Console.WriteLine($"Digite o nome da Razão Social que deseja cadastrar");

                        bool cnpjValido;
                        do
                        {
                            Console.WriteLine($"Digite o CNPJ 'SOMENTE NUMEROS' ");
                            string? ValidarCnpj = Console.ReadLine();

                            cnpjValido = metodosPj.ValidarCnpj(ValidarCnpj);

                            if (cnpjValido)
                            {
                                string subStringCnpj = cnpj.Substring(14);

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"CNPJ inválido, por favor digite verifique novamente");
                                Console.ResetColor;
                                Thread.Sleep(3000);
                            }

                        }

                        Console.WriteLine($"Digite o rendimento mensal 'INSERIR SOMENTE NUMEROS' ");
                        novaPj.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero");
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");
                        novoEndPj.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPj.endComercial = true;
                        }
                        else
                        {
                            novoEndPj.endComercial = false;
                        }


                        novaPj.Endereco = novoEndPj;

                        listaPj.Add(novaPj);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Cadastrado criado com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;


                        Console.Clear();

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPessoa in listaPj)
                            {

                                Console.Clear();
                                Console.WriteLine(@$"
Razão Social: {cadaPessoa.RazaoSocial}
Endereço: {cadaPessoa.Endereco.logradouro}, Nº: {cadaPessoa.Endereco.numero}
Imposto a ser pago: {metodosPj.PagarImposto(novaPj.Rendimento).ToString("C")}
");

                                Console.WriteLine($"Aperta 'ENTER' para continuar");
                                Console.ReadLine();

                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia");
                            Thread.Sleep(3000);
                        }
                        break;


                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;

                }

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

// ifternario: condicao ? "Sim" : " Não"
// Console.WriteLine($"Nome: {novaPF.Nome} Nome: {novaPF.Nome}");
// Console.WriteLine("Nome" + novaPF.Nome + " Nome: " + novaPF.Nome);
// .ToLower: as letras ficam em minusculos
// .ToUpper: as letras ficam em maisculos
// Usar o foreach para lista