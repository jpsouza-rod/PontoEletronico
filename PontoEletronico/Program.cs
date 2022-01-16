using System;
using System.Threading;
public class Funcionario {

  public Funcionario(){
      Historico = new List<DateTime>();
  }
  public List<DateTime> Historico;

  public void NovoPonto () {
    Historico.Add(DateTime.Now);
  }

  public void Historico_ponto (){
    foreach (var ponto in Historico){
      Console.WriteLine(ponto);
    }
  }
}

class Program {
  public static void Main (string[] args) {
    var Joao = new Funcionario();
    Joao.NovoPonto();
    Thread.Sleep(5000);
    Joao.NovoPonto();
    Thread.Sleep(5000);
    Joao.NovoPonto();
    Joao.Historico_ponto();
  }
}