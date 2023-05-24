namespace exercicio3;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica n1 = new ContratoPessoaFisica();
        ContratoPessoaJuridica n2 = new ContratoPessoaJuridica();

        n1.Email = "fernandaeloise2006@gmail.com";
        n1.Nome = "Fernanda";
        n1.Telefone = "(11) 934075506";
        n1.cpf = "123.321.012-32";
        n1.Idade = 16;
        n1.Prazo = 10;


        n2.Email = "dayabajsh@gmail.com";
        n2.Nome = "Dayana";
        n2.Telefone = "(11) 911031917";
        n2.cnpj = "12.332.112/0001-00";
        n2.ie = "123.321.456.789";
        n2.NomeEmpresa = "Fernandananda";
        n2.Prazo = 10;
        

        Console.WriteLine("os dados da Pessoa Física sao: " + n1.MostraDados());
        Console.WriteLine("os dados da Pessoa Jurídica sao: " + n2.MostraDados());
        Console.WriteLine("************************************");
        Console.WriteLine("O valor da prestação da Pessoa Física é de: " + n1.calcularPrestacao());
        Console.WriteLine("O valor da prestação da Pessoa Jurídica é de: " + n2.calcularPrestacao());
    }
}