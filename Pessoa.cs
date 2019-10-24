using System;

class Pessoa 

  //public static void Main (string[] args) 
  {
    public string Nome;
    public int Idade;
    public string Cargo;
    public double Salario;
    public int QtdFilhos;

    public Pessoa (string n, int i, string c, double s, int q)
    {
      Nome = n;
      Idade = i;
      Cargo = c;
      Salario = s;
      QtdFilhos = q;
    }

    public string Imprimir()
    {
      string dados = Nome +" "+ Idade +" "+ Cargo +" "+ Salario +" "+ QtdFilhos;

      return dados;
    }    
  }
