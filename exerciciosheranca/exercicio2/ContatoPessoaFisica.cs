namespace Exercicio2;
class ContatoPessoaFisica:Contato
{
    public string? CPF{get;set;}
    public int Idade{get;set;}

    public override string MostrarDados(){
        return base.MostrarDados() +"\nCPF: "+ this.CPF +"\nIdade: "+ this.Idade;
    }
}