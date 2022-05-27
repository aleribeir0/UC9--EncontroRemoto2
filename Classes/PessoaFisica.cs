using Cadastro___Encontro_R2.Interfaces;

namespace Cadastro___Encontro_R2.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {

        public string? cpf { get; set; }
        public DateTime dataNasc { get; set; }
             
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}