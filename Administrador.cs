using System;
using System.Collections.Generic;

class Administrador

  //public static void Main (string[] args) 
  {
    public List<Pessoa>Pessoas;

    public Administrador()
    {
      Pessoas = new List<Pessoa>();                        
    }

    public void AddPessoa(string nome, string cargo, int idade, int qtdFilhos, double salario)
    {
      Pessoa p1 = new Pessoa(nome, idade, cargo, salario, qtdFilhos);

      Pessoas.Add(p1);

    }

    public List<Pessoa> getListaPessoa() 
    {
      return Pessoas;

    }







    

    public void Imprimir()
    {
      foreach(Pessoa pessoa in Pessoas)
      {
        Console.WriteLine(pessoa.Nome + pessoa.Cargo + pessoa.Idade + pessoa.Salario + pessoa.QtdFilhos);

      }

      
    }        
  }
