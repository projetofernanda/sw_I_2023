namespace exemplo_herança;
class Funcionario
{
    public string? Nome {get;set;}
    public int Idade {get;set;}

    public virtual double Lucro(){
        return 15000;
    }
}