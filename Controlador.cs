using System;

class Controlador 
{
   
    /*
    Beneficio:
    1 - desconto energia
    */
        
    public static string ValidaBeneficio(Pessoa p)
    {
      if(p.Salario <= 1000)
      {
        return "\nBenefícios disponíveis: \nEnergia 10% \nÁgua 15%";
      }

      else if (p.Salario >1000 && p.Salario <= 1300)
      {
        return "\nBenefícios disponíveis: \nEnergia 5% \nÁgua 8%";
      }

      else if (p.Salario >1300 && p.Salario <= 1500)
      {
        return "\nBenefícios disponíveis: \nÁgua 5%";
      }

      else
      {
        return "\nNão possui descontos no pagamento de água e energia elétrica.";
      }
        
    }

    public static string ValidaBolsaF(Pessoa bf)
    {
      if(bf.QtdFilhos >= 1)
      {
        return "\nPossui direito a auxilio bolsa família por filho";
      }

      else
      {
        return "\nNão possui direito ao auxilio bolsa família.";
      }
      
    } 
}
