using Cadastro___Encontro_R2.Interfaces;

namespace Cadastro___Encontro_R2.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        public float Rendimento { get; set; }
        public string? Endereco { get; set; }

        public abstract float PagarImposto(float rendimento);
    }
}