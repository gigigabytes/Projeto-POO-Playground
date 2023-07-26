using System;



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
            while (op != 0)
            {
                switch (op)
                {
                    case 1: InserirResponsavel(); break;
                    case 2: ListarResponsavel(); break;
                    case 3: InserirPacote(); break;
                    case 4: ListarPacote(); break;
                }
                op = Menu();
            }
        }




        //   VERIFICAR LISTAR






        public static void InserirResponsavel()
        {
            
            Console.WriteLine("Nome:");
            string n = Console.ReadLine();
            Console.WriteLine("Cpf sem pontos ou barras:");
            string cpf = Console.ReadLine();
            Console.WriteLine("Idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("N° para contato:");
            string contato = Console.ReadLine();
            Responsavel c = new Responsavel { nome = n, cpf = cpf, idade = idade, contato = contato };
            Nresponsavel.Inserir(c);
        }
        public static void ListarResponsavel()
        {
            // Adicionar frase
            foreach (Responsavel responsavel in Nresponsavel.Listar())
            {
                Console.WriteLine(responsavel);
                Console.WriteLine("TESTE");

            }
        }
        public static void InserirPacote()
        {
            Console.WriteLine("Descrição:");
            string d = Console.ReadLine();
            Console.WriteLine("Tempo de duração:");
            string h = Console.ReadLine();
            Console.WriteLine("Valor:");
            double v = double.Parse(Console.ReadLine());
            Pacote p = new Pacote{descricao = d, horas = h ,valor = v  };
            Npacote.Inserir(p);

        }

        public static void ListarPacote()
        {
            // Adicionar frase
            foreach (Pacote p in Npacote.Listar())
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }

        }

        public static int Menu()
        {
            Console.WriteLine("1-Inserir Res\n2-Listar Res");
            return int.Parse(Console.ReadLine());

        }

    }
}

