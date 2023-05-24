namespace Exercicio2;
class Program
{
    static void Main(string[] args)
    {
        ContatoPessoaFisica n1 = new ContatoPessoaFisica();
        ContatoPessoaJuridica n2 = new ContatoPessoaJuridica();

        n1.Nome = "Fernanda";
        n1.Email = "fernandaeloise2006@gmail.com";
        n1.Telefone = "11 934075506";
        n1.CPF = "216.165.956-01";
        n1.Idade = 16;

        n2.Nome = "Dayana";
        n2.Email = "jagbjdk@gmail.com";
        n2.Telefone = "11 911031917";
        n2.CNPJ = "111525230";
        n2.IE = "157451210";
        n2.NomeDaEmpresa = "Fernandananda";

        Console.WriteLine(n1.MostrarDados());
        Console.WriteLine();
        Console.WriteLine(n2.MostrarDados());
    }
}