using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace MainPlayground
{
    class Program
    {
        public static Responsavel usuarioLogado = null;
        public static Admin adminLogado = null;



        static void Main(string[] args)
        {
            // Carrega o arquivo json
            CarregarResponsavel();
            CarregarPacote();
            CarregarAdmin();
            CarregarCriancas();
            CarregarCompras();
            // Responsavel responsavel = new Responsavel();
            // Crianca crianca = new Crianca();
            // Pacote pac = new Pacote();

            Console.WriteLine("Bem vindo ao playground!\n");
            int op = 100;

            op = Menu();
            switch (op)
            {
                case 1: CriarConta(); break;
                case 2: Login(); break;
                case 3: LoginAdmin(); break;
            }



            if (usuarioLogado != null)
            {
                while (op != 0)
                {
                    op = MenuUsuario();
                    switch (op)
                    {
                        case 1: InserirCrianca(); break;
                        case 2: ListarCrianca(); break;
                        case 4: ExcluirCriança(); break;
                        case 5: AtualizarCrianca(); break;
                        case 6: SairSistema(); break;
                        case 7: ComprarPacote(); break;

                    }
                }

            }

            else if (adminLogado != null)
            {
                while (op != 0)
                {
                    op = MenuAdmin();
                    switch (op)
                    {
                        case 1: ListarPacote(); break;
                        case 2: InserirPacote(); break;
                        case 3: AtualizarPacote(); break;
                        case 4: ExcluirPacote(); break;
                        case 5: ListarResponsavel(); break;
                        case 6: CriarConta(); break;
                        case 7: AtualizarUsuario(); break;
                        case 8: ExcluirUsuario(); break;
                        case 99: SairSistema(); break;
                    }
                }
            }




            Console.WriteLine("Tchau:)");

        }


        public static void CriarConta()
        {
            Console.WriteLine("Nome:");
            string n = Console.ReadLine();
            Console.WriteLine("Senha:");
            string senha = Console.ReadLine();
            Console.WriteLine("Cpf sem pontos ou barras:");
            string cpf = Console.ReadLine();
            Console.WriteLine("Idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("N° para contato:");
            string contato = Console.ReadLine();
            Responsavel c = new Responsavel { nome = n, cpf = cpf, idade = idade, contato = contato, senha = senha };
            Nresponsavel.Inserir(c);
            Console.WriteLine("Conta criada com sucesso");
            Console.WriteLine("Id de acesso" + c.id);

        }

        static void InserirAdmin()
        {
            Console.WriteLine("Informe Nome");
            string n = Console.ReadLine();
            Console.WriteLine("Informe senha:");
            string s = Console.ReadLine();
            Admin a = new Admin { nome = n, senha = s };
            Nadmin.Inserir(a);
            Console.WriteLine("Conta Criada");
        }
        static void LoginAdmin()
        {
            Console.WriteLine("Informe id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe senha:");
            string senha = Console.ReadLine();
            adminLogado = Nadmin.Login(id, senha);
            if (adminLogado == null)
            {
                Console.WriteLine("Id ou senha incorreta");
            }
            else { Console.WriteLine("Bem vindo " + adminLogado.nome); }
        }

        static void Login()
        {
            Console.WriteLine("Área de login");
            Console.WriteLine("Informe id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a senha");
            string senha = Console.ReadLine();
            usuarioLogado = Nresponsavel.Login(id, senha);
            // usuarioLogado = Nresponsavel.Login(id, senha);
            if (usuarioLogado == null)
            {
                Console.WriteLine("Usuário ou senha incorretos");
            }
            else { Console.WriteLine("Bem vindo(a) " + usuarioLogado.nome); }

        }

        static int MenuAdmin()
        {
            Console.WriteLine("----Pacotes----");
            Console.WriteLine("|01 - Listar  |");
            Console.WriteLine("|02 - Inserir  |");
            Console.WriteLine("|03 - Atualizar  |");
            Console.WriteLine("|04 - Excluir  |");
            Console.WriteLine("----Usuários----");
            Console.WriteLine("|05 - Listar  |");
            Console.WriteLine("|06 - Inserir  |");
            Console.WriteLine("|07 - Atualizar |");
            Console.WriteLine("|08 - Excluir  |");
            Console.WriteLine("|----Crianca----");
            Console.WriteLine("|09 - Listar Criancas|");
            Console.WriteLine("|99 - Sair  |");
            Console.WriteLine("|                     |");

            return int.Parse(Console.ReadLine());

        }

        static int MenuUsuario()
        {
            // Console.WriteLine("Bem vindo(a) " + usuarioLogado.nome);
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("01 - Cadastrar criança |");
            Console.WriteLine("02 - Ver crianças cadastradas |");
            Console.WriteLine("03 - Ver historico de compras |");
            Console.WriteLine("04 - Excluir criança |");
            Console.WriteLine("05 -Atualizar informações da criança |");
            Console.WriteLine("06 - Sair |");
            Console.WriteLine("07 - Comprar Pacote |");


            return int.Parse(Console.ReadLine());
        }
        public static void ListarResponsavel()
        {
            // Adicionar frase
            foreach (Responsavel responsavel in Nresponsavel.Listar())
            {
                Console.WriteLine(responsavel);
            }
        }

        //       static void InserirUsuario()
        //        {
        //           Console.WriteLine("Informe Nome");
        //           string n = Console.ReadLine();
        //           Console.WriteLine("Informe senha:");
        //            string s = Console.ReadLine();
        //            Admin a = new Admin { nome = n, senha = s };
        //            Nadmin.Inserir(a);
        //            Console.WriteLine("Conta Criada");
        //        }


        public static void AtualizarUsuario()
        {
            ListarResponsavel();
            Console.WriteLine("Informe o id para atualizar\n");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe nova senha");
            string s = Console.ReadLine();
            Console.WriteLine("Informe contato");
            string c = Console.ReadLine();
            Responsavel responsavel = new Responsavel { id = id, senha = s, contato = c };
            Nresponsavel.Atualizar(responsavel);
        }

        public static void ExcluirUsuario()
        {
            ListarResponsavel();
            Console.WriteLine("Infome o id para excluir:");
            int id = int.Parse(Console.ReadLine());
            Responsavel responsavel = new Responsavel { id = id };
            Nresponsavel.Excluir(responsavel);
            Console.WriteLine("Responsavel excluido.");

        }
        public static void InserirPacote()
        {
            Console.WriteLine("Descrição:");
            string d = Console.ReadLine();
            Console.WriteLine("Tempo de duração:");
            string h = Console.ReadLine();
            Console.WriteLine("Valor:");
            double v = double.Parse(Console.ReadLine());
            Pacote p = new Pacote { descricao = d, horas = h, valor = v };
            Npacote.Inserir(p);

            // Npacote.Salvar();
        }
        public static void AtualizarPacote()
        {
            ListarPacote();
            Console.WriteLine("Informe o Id para atualizar");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a descrição");
            string s = Console.ReadLine();
            Console.WriteLine("Informe novo período");
            string p = Console.ReadLine();
            Console.WriteLine("Informe novo valor");
            double v = double.Parse(Console.ReadLine());
            Pacote pac = new Pacote { id = id, descricao = s, horas = p, valor = v };
            Npacote.Atualizar(pac);
            Console.WriteLine("Informações atualizadas\n");
        }

        public static void ExcluirPacote()
        {
            ListarPacote();
            Console.WriteLine("Infome o id para excluir:");
            int id = int.Parse(Console.ReadLine());
            Pacote pac = new Pacote { id = id };
            Npacote.ExcluirPacote(pac);
            Console.WriteLine("Pacote excluido.\n");
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

        public static void InserirCrianca()
        {
            Console.WriteLine("Nome:");
            string n = Console.ReadLine();
            Console.WriteLine("Idade (somente numeros)");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Genero F ou M");
            string g = Console.ReadLine();
            Console.WriteLine("Alguma informação que você ache essencial sabermos:\n");
            string o = Console.ReadLine();
            Crianca crianca = new Crianca { nome = n, idade = idade, genero = g, outros = o, idresponsavel = usuarioLogado.id };
            Ncrianca.Inserir(crianca);
            Console.WriteLine("Criança cadastrada com sucesso.");
        }

        static void ListarCrianca()
        {
            Ncrianca.Listar();

            List<Crianca> respon;

            respon = Ncrianca.Listar().Where(c => c.idresponsavel == usuarioLogado.id).ToList();

            if(respon.Count ==0)
            {
                Console.WriteLine("Nenhuma crianca cadastrada");
            }

            else
            {
                Console.WriteLine("Crianças cadastradas:\n");
                foreach(Crianca c in respon)
                {
                    Console.WriteLine($"{c.nome}\n");
                }
            }
        }

        public static void AtualizarCrianca()
        {
            ListarCrianca();
            Console.WriteLine("Informe o Id para atualizar");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nova informação necessaria");
            string s = Console.ReadLine();
            Crianca crianca = new Crianca { id = id, outros = s };
            Ncrianca.Atualizar(crianca);
            Console.WriteLine("Informações atualizadas\n");

        }

        public static void ExcluirCriança()
        {
            ListarCrianca();
            Console.WriteLine("Informe o id para excluir");
            int id = int.Parse(Console.ReadLine());
            Crianca crianca = new Crianca { id = id };
            Ncrianca.Excluir(crianca);
            Console.WriteLine("Criança removida");
        }

        static void ComprarPacote()
        {
            ListarPacote();
            Console.WriteLine("Informe o Id  tipo de pacote que deseja comprar:");
            int idPacote = int.Parse(Console.ReadLine());

            if (Npacote.pac.Any(p => p.id == idPacote))
            {
                Compra compras = new Compra { idresponsavel = usuarioLogado.id, idpacote = idPacote, data = DateTime.Now };
                Ncompra.Inserir(compras);
                Console.WriteLine("Compra realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Pacote não encontrado. Compra não realizada.");
            }
        }
        public static int Menu()
        {
            Console.WriteLine("-----------Opções--------");
            Console.WriteLine("| 01 - Cadastrar      |");
            Console.WriteLine("| 02 - Login     |");
            Console.WriteLine("| 03 - Login Admin     |");
            return int.Parse(Console.ReadLine());

        }
        static void SairSistema()
        {
            SalvarResponsavel();
            SalvarPacote();
            SalvarCrianca();
            SalvarAdmin();
            SalvarCompras();
            usuarioLogado = null;
            adminLogado = null;

            // Menu();
        }
        //

        //
        static void SalvarResponsavel()
        {
            string json = JsonSerializer.Serialize(Nresponsavel.responsavel);
            File.WriteAllText("resp.json", json);
        }

        static void CarregarResponsavel()
        {
            if (File.Exists("resp.json"))
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
            File.WriteAllText("pacotes.json", json);
        }
        static void CarregarPacote()
        {
            if (File.Exists("pacotes.json"))
            {
                string json = File.ReadAllText("pacotes.json");
                Npacote.pac = JsonSerializer.Deserialize<List<Pacote>>(json);
            }
            else
            {
                Npacote.pac = new List<Pacote>();
            }
        }

        static void SalvarCrianca()
        {
            string json = JsonSerializer.Serialize(Ncrianca.crianca);
            File.WriteAllText("criancas.json", json);
        }

        static void CarregarCriancas()
        {
            if (File.Exists("criancas.json"))
            {
                string json = File.ReadAllText("criancas.json");
                Ncrianca.crianca = JsonSerializer.Deserialize<List<Crianca>>(json);
            }
            else
            {
                Ncrianca.crianca = new List<Crianca>();
            }
        }

        static void SalvarAdmin()
        {
            string json = JsonSerializer.Serialize(Nadmin.adm);
            File.WriteAllText("admins.json", json);
        }

        static void CarregarAdmin()
        {
            if (File.Exists("admins.json"))
            {
                string json = File.ReadAllText("admins.json");
                Nadmin.adm = JsonSerializer.Deserialize<List<Admin>>(json);
            }
            else
            {
                Nadmin.adm = new List<Admin>();
            }
        }

        static void SalvarCompras()
        {
            string json = JsonSerializer.Serialize(Ncompra.compras);
            File.WriteAllText("compras.json", json);
        }
        
        static void CarregarCompras()
        {
            if (File.Exists("compras.json"))
            {
                string json = File.ReadAllText("compras.json");
                Ncompra.compras = JsonSerializer.Deserialize<List<Compra>>(json);
            }
            else
            {
                Ncompra.compras = new List<Compra>();
            }
        }






    }
}

