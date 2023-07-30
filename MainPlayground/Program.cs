using System;

// O playground funciona como o gamestation
// A compra é de um passe que dura N período

namespace MainPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            // Carrega o arquivo json
            CarregarResponsavel();
            CarregarPacote();
            
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
            SalvarResponsalvel();
        }
        public static void ListarResponsavel()
        {
            // Adicionar frase
            foreach (Responsavel responsavel in Nresponsavel.Listar())
            {
                Console.WriteLine(responsavel);
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
            SalvarPacote();
            // Npacote.Salvar();
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
    
        static void SalvarResponsalvel()
        {
            string json = JsonSerializer.Serialize(Nresponsavel.responsavel);
            File.WriteAllText("resp.json",json);
        }

        static void CarregarResponsavel()
        {
            if(File.Exists("resp.json"))
            {
                string json = File.ReadAllText("resp.json");
                Nresponsavel.responsavel = JsonSerializer.Deserialize<List<Responsavel>>(json);
            }
            else
            {
                Nresponsavel.responsavel = new List<Responsavel>();
            }
        }

        static void SalvarPacote()
        {
            string json = JsonSerializer.Serialize(Npacote.pac);
            File.WriteAllText("pacotes.json",json);
        }
        static void CarregarPacote()
        {
            if(File.Exists("pacotes.json"))
            {
                string json = File.ReadAllText("pacotes.json");
                Npacote.pac = JsonSerializer.Deserialize<List<Pacote>>(json);
            }
            else
            {
                Npacote.pac = new List<Pacote>();
            }
        }




       
       
    }
}

