﻿using System;



// NECESSARIO TESTAR LISTAR
namespace MainPlayground
{
    class Program
    {   
        static void Main(string[] args)
        {
           Responsavel responsavel = new Responsavel();
           Crianca crianca = new Crianca();
           Pacote pac = new Pacote();
           int op = Menu();
           while(op != 0){
            switch(op){
                case 1: InserirResponsavel();break;
                case 2: ListarResponsavel();break;
            }
           }
        //    SEGUNDA OPÇÃO DO MENU TÁ ESQUISITA.... CHECAR
           
           
           responsavel.id = 2;
           crianca.id = 2;
           crianca.nome= "suzy";
           crianca.idade = 12;
           crianca.genero= "F";
           crianca.outros= "Ama chocolate";
           responsavel.Criancas.Add(crianca);
           Console.WriteLine(responsavel.id);
           foreach (Crianca criancas in responsavel.Criancas){
            Console.WriteLine("Id Criança:"+ criancas.id);
            Console.WriteLine("Nome:"+criancas.nome);
            Console.WriteLine("idade:"+criancas.idade);
            Console.WriteLine("genero:"+criancas.genero);
            Console.WriteLine("outros:"+criancas.outros);
           }
           
           ListarResponsavel();

            
        //   VERIFICAR LISTAR
             
           

            
        }
        
    public static void InserirResponsavel(){
        // Adicionar perguntas de inserção
        string n = Console.ReadLine();
        string cpf = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());
        string contato = Console.ReadLine();
        Responsavel c = new Responsavel { nome = n, cpf = cpf , idade = idade, contato = contato};
        Nresponsavel.Inserir(c);
        Menu();
    }
    public static void ListarResponsavel(){
        // Adicionar frase
        foreach (Responsavel responsavel in Nresponsavel.Listar()){
            Console.WriteLine("nome"+responsavel.nome);
            
        }
    }

    public static void ListarPacote(){
        // Adicionar frase
        foreach (Pacote p in Npacote.Listar()){
            Console.WriteLine(p);
            Console.WriteLine();
        }
    
    }

    public static int Menu(){
        Console.WriteLine("1-Inserir Res\n2-Listar Res\n");
        return int.Parse(Console.ReadLine());

    }


}
}
