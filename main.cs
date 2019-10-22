using System;
using System.IO;
using System.Collections.Generic;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Administrador adm = new Administrador();

    Console.WriteLine("Cadastro Pessoa baixa renda");
    Console.WriteLine();

    Console.Write("Deseja cadastrar uma nova Pessoa? ");
    string cad = Console.ReadLine();

    while(cad == "SIM" || cad == "S")
    {
      Console.Write("Digite o Nome: ");
      string nome = Console.ReadLine();

      Console.Write("Digite o Cargo: ");
      string cargo = Console.ReadLine();

      Console.Write("Digite a Idade: ");
      int idade = int.Parse(Console.ReadLine());

      Console.Write("Digite a Quantidade de Filhos: ");
      int qtdFilhos = int.Parse(Console.ReadLine());

      Console.Write("Digite o Salário: ");
      double salario = double.Parse(Console.ReadLine());

      
      
      adm.AddPessoa(nome, cargo, idade, qtdFilhos, salario);
      //adm.Imprimir();

      StreamWriter x;

      string CaminhoNome = "dados.txt";

      x = File.AppendText(CaminhoNome);

      //string aux = "";

      List <Pessoa>Pessoas = adm.getListaPessoa();
      
      foreach(Pessoa pessoa in  Pessoas)
      {
        x.WriteLine(pessoa.Imprimir());        
        
      }

      x.Close();

    Console.Write("Deseja cadastrar uma nova Pessoa? ");
    string cad2 = Console.ReadLine();

    if(cad2 == "NAO" || cad2 == "N")
    {
      break;
    }


    }

    
    Console.WriteLine(Controlador.ValidaBeneficio(adm.Pessoas[0]));

    Console.WriteLine(Controlador.ValidaBolsaF(adm.Pessoas[0]));

  }
}
