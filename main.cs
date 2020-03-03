using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    
    ArrayList ListaTotal = new ArrayList();

    while (true){
      Console.WriteLine ("\n[X]Olá, bem vindo ao Crud de Concessionaria!");
      Console.WriteLine ("[1]Cadastrar.");
      Console.WriteLine ("[2]Apresentar.");
      Console.WriteLine ("[3]Alterar.");
      Console.WriteLine ("[4]Excluir.");
      Console.WriteLine ("[5]Sair.");
      Console.WriteLine ("[X]Escolha uma opção!");
      string VerificaMenu1 = Console.ReadLine();

      if(VerificaMenu1 == "1"){
        Console.WriteLine("\n[X]Opção de cadastro!");

        Console.WriteLine("\n[X]Digite o codigo do carro:");
        string Codigo = Console.ReadLine();

        Console.WriteLine("\n[X]Digite o nome do carro:");
        string Nome = Console.ReadLine();
      
        Console.WriteLine("\n[X]Digite o ano do carro:");
        string Ano = Console.ReadLine();

        Console.WriteLine("\n[X]Digite o tipo do combustivel do carro:");
        string Combustivel = Console.ReadLine();

        Console.WriteLine("\n[X]Digite a configuração do carro:");
        string Configuração = Console.ReadLine();

        Console.WriteLine("\n[X]Digite a quantidade de lugares do carro:");
        string Lugares = Console.ReadLine();

        Console.WriteLine("\n[X]Digite o tipo de tração do carro:");
        string Tração = Console.ReadLine();

        string CadastroCompleto = Codigo + " | " + Nome + " | " + Ano + " | " + Combustivel + " | " + Configuração + " | " + Lugares + " | " + Tração;

        ListaTotal.Add(CadastroCompleto);
      }
      
      else if(VerificaMenu1 == "2"){
        Console.WriteLine("\n[X]Opção de Apresentação!");

        if(ListaTotal.Count == 0){
          Console.WriteLine("[X]Nenhum usuário registrado!");
        }

        else{
          for(int i = 0; i < ListaTotal.Count; i++){
            Console.WriteLine("Carro " + i + ": " + ListaTotal[i]);
          }
        }
      }

      else if(VerificaMenu1 == "3"){
        Console.WriteLine("\n[X]Opção de Alteração!");

        if(ListaTotal.Count == 0){
          Console.WriteLine("[X]Nenhum usuário registrado!");
        }

        else{
          try {
            
            Console.WriteLine("\n[X]Digite o carro a ser alterado: ");
            int CarroAltera = Convert.ToInt32(Console.ReadLine());
          
            int Verificador = 0;

            for(int i = 0; i < ListaTotal.Count; i++){
            
              string PegaIndex = i.ToString();
              string PegaCarroAltera = CarroAltera.ToString();
            
              if(PegaCarroAltera == PegaIndex){
                Verificador = Verificador + 1;
              }
              
              else{
                Verificador = Verificador + 0;
              }
            }

            if(Verificador > 0){
              Console.WriteLine("\n[X]Digite o codigo do carro:");
              string Codigo = Console.ReadLine();

              Console.WriteLine("\n[X]Digite o nome do carro:");
              string Nome = Console.ReadLine();
      
              Console.WriteLine("\n[X]Digite o ano do carro:");
              string Ano = Console.ReadLine();

              Console.WriteLine("\n[X]Digite o tipo do combustivel do carro:");
              string Combustivel = Console.ReadLine();

              Console.WriteLine("\n[X]Digite a configuração do carro:");
              string Configuração = Console.ReadLine();

              Console.WriteLine("\n[X]Digite a quantidade de lugares do carro:");
              string Lugares = Console.ReadLine();

              Console.WriteLine("\n[X]Digite o tipo de tração do carro:");
              string Tração = Console.ReadLine();

              string CadastroCompleto = Codigo + " | " + Nome + " | " + Ano + " | " + Combustivel + " | " + Configuração + " | " + Lugares + " | " + Tração;

              ListaTotal[CarroAltera] = CadastroCompleto;

            }
            else {
              Console.WriteLine("\n[X]Nenhum carro encontrado nesse indice!");
            }
          }
          catch(Exception e){
            Console.WriteLine("\n[X]Digite um número!");
          }
        }
      }

      else if(VerificaMenu1 == "4"){
        Console.WriteLine("\n[X]Opção de Exclusão!");

        if(ListaTotal.Count == 0){
          Console.WriteLine("[X]Nenhum usuário registrado!");
        }

        else{
          try {
            Console.WriteLine("\n[X]Digite o carro a ser excluido: ");
            int CarroExclui = Convert.ToInt32(Console.ReadLine());

            int Verificador = 0;

            for(int i = 0; i < ListaTotal.Count; i++){
            
              string PegaIndex = i.ToString();
              string PegaCarroExcluir = CarroExclui.ToString();
            
              if(PegaCarroExcluir == PegaIndex){
                Verificador = Verificador + 1;
              }
            
              else{
                Verificador = Verificador + 0;
              }
            }

            if(Verificador > 0){
              ListaTotal.RemoveAt(CarroExclui);
            }
          
            else{
              Console.WriteLine("\n[X]Nenhum carro encontrado nesse indice!");
            }
          }
          catch(Exception e){
            Console.WriteLine("\n[X]Digite um número!");
          }
        }
      }

      else if(VerificaMenu1 == "5"){
        Console.WriteLine("\n[X]Opção de saida. Obrigado!");
        Environment.Exit(0);
      }

      else{
        Console.WriteLine("\n[X]Digite uma opção valida!");
      }
    }
  }
}