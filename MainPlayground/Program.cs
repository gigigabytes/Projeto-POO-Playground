using System;






// NECESSARIO TESTAR LISTAR
namespace MainPlayground
{
    class Program
    {   
        static void Main(string[] args)
        {
           Responsavel responsavel = new Responsavel();
           Crianca crianca1 = new Crianca();
            InserirResponsavel();
            ListarResponsavel();
        //    Variaveis usadas pra teste. Excluir depois
        //    responsavel.id = 1;
        //    crianca1.id = 2;
        //    crianca1.nome= "suzy";
        //    crianca1.idade = 12;
        //    crianca1.genero= "F";
        //    crianca1.outros= "Ama chocolate";
        //    responsavel.Criancas.Add(crianca1);
        //    Console.WriteLine(responsavel.id);
        //    foreach (Crianca criancas in responsavel.Criancas){
        //     Console.WriteLine("Id Criança:"+ criancas.id);
        //     Console.WriteLine("Nome:"+criancas.nome);
        //     Console.WriteLine("idade:"+criancas.idade);
        //     Console.WriteLine("genero:"+criancas.genero);
        //     Console.WriteLine("outros:"+criancas.outros);

        //    }
        }
    public static void InserirResponsavel(){
        // Adicionar perguntas de inserção
        string n = Console.ReadLine();
        string cpf = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());
        string contato = Console.ReadLine();
        Responsavel c = new Responsavel { nome = n, cpf = cpf , idade = idade, contato = contato};
        Nresponsavel.Inserir(c);
    }
    public static void ListarResponsavel(){
        // Adicionar frase
        foreach (Responsavel d in Nresponsavel.Listar()){
            Console.WriteLine(d);
            Console.WriteLine();
        }
    }
    
    }

}
