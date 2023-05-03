namespace exemplo_herança;
class FuncionarioN2:Funcionario
{
   


    public override double Lucro(){
        return base.Lucro()*0.02;
    }
}