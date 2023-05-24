namespace Exercicio2;

class ContatoPessoaJuridica:Contato
{
    public string? CNPJ{get;set;}
    public string? IE{get;set;}
    public string? NomeDaEmpresa{get;set;}

    public override string MostrarDados(){
        return base.MostrarDados() +"\nCNPJ: "+ this.CNPJ +"\nIE: "+ this.IE +"\nNome da Empresa: "+ this.NomeDaEmpresa;
    }
    
}