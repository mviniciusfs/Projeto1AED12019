using System;
using System.Collections.Generic;

class Administrador

  {
    //Lista - dados da pessoa.
    public List<Pessoa>Pessoas;

    public Administrador()
    {
      Pessoas = new List<Pessoa>();                        
    }

    //Adicionar dados inseridos pelo operador do sistema.
    public void AddPessoa(string nome, string cargo, int idade, int qtdFilhos, double salario)
    {
      Pessoa p1 = new Pessoa(nome, idade, cargo, salario, qtdFilhos);

      Pessoas.Add(p1);
    }

    public List<Pessoa> getListaPessoa() 
    {
      return Pessoas;
    }           
  }
