namespace ExercicioAlunos;
class Aluno
{
    public string nome="";
    public double nota1, nota2;

    //Media 
    public double obterMedia(){
        double media = (nota1+nota2)/2;
        return media;
    }

    //Situação
    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="Aprovado";
        }else{
            situacao="Reprovado";
        }
        return situacao;
    }
    //Menssagem
    public void menssagem(){
        double mediaCalculada = obterMedia();
        string resutadoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome+" está "+resutadoSituacao+" com está: "+mediaCalculada);
    }

    

}