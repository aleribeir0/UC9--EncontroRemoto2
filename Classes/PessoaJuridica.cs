using System.Text.RegularExpressions;
using Cadastro___Encontro_R2.Interfaces;

namespace Cadastro___Encontro_R2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }
        public string? RazaoSocial { get; set; }



        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {

            //xx.xxx.xxx/0001-xx ------- xxxxxxxx0001xx
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");

            if (retornoCnpjValido == true)
            {
                if (cnpj.Length == 18)
                {

                    string subStringCnpj = cnpj.Substring(11, 4);

                    if (subStringCnpj == "0001")

                        return true;


                }
                else if (cnpj.Length == 14)

                {
                    string subStringCnpj = cnpj.Substring(8, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}