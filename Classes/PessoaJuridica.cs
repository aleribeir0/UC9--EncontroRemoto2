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
            throw new NotImplementedException();
        }
    }
}