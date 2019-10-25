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
    string cad = Console.ReadLine().ToUpper();

    //Leitura dos dados;
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


      //Validação para BENEFICIÁRIOS;
      if(salario <= 1100)
      {        
        //Trabalhando com arquivo .txt
        StreamWriter x;
        string CaminhoNome = "dados.txt";
        x = File.AppendText(CaminhoNome);

        //Salvando dados no arquivo;
        adm.AddPessoa(nome, cargo, idade, qtdFilhos, salario);
        List <Pessoa>Pessoas = adm.getListaPessoa();      
        foreach(Pessoa pessoa in  Pessoas)
        {
          x.WriteLine(pessoa.Imprimir().ToUpper());        
        }

        x.Close();

        Console.Write("Deseja cadastrar uma nova Pessoa? ");
        string cad2 = Console.ReadLine().ToUpper();

        if(cad2 == "NAO" || cad2 == "N")
        {
          break;
        }
      }

      else if(salario > 100)
      {
        Console.WriteLine("**********ATENÇÃO*********");
        Console.WriteLine("APENAS CADASTROS DE BAIXA RENDA - SALÁRIO ATÉ R$1100,00");

        Console.WriteLine();

        Console.Write("Deseja cadastrar uma nova Pessoa? ");
        string cad3 = Console.ReadLine().ToUpper();

        if(cad3 == "NAO" || cad3 == "N")
        {
          break;
        }
      }
    }

    
    
    //Imprimir na tela os benefícios disponíveis;
    Console.WriteLine();
    Console.WriteLine("Deseja verificar o banco de beneficiários? ");
    string resultfinal = Console.ReadLine().ToUpper();
    Console.WriteLine();

    if(resultfinal == "SIM" || resultfinal == "S")
    {
      StreamReader y;

      
      Console.WriteLine();
      Console.WriteLine("DIRETOS Á: \nDesconto pagamento Saneamento Básico 10%\nDesconto pagamento de Energia 5%")
      ;
      Console.WriteLine();
      Console.WriteLine("LISTA DE BENEFICIÁRIOS");
      Console.WriteLine();

      string Caminho = "dados.txt";

      y = File.OpenText(Caminho);

      while(y.EndOfStream != true)
      {
        string linha = y.ReadLine();
        Console.WriteLine(linha);
        
      }    
      y.Close();

      Console.WriteLine();
      Console.Write("********PROGRAMA FINALIZADO*********");
      
    }
    
  }
}
