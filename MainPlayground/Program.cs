﻿using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;


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
            Responsavel responsavel = new Responsavel();
            Crianca crianca = new Crianca();
            Pacote pac = new Pacote();


            Console.WriteLine("Bem vindo ao playground!\n");
            int op = 100;
            while (op != 0) 
            {
                
                    if (usuarioLogado == null)
                    {
                        op = MenuVisitante();
                        switch(op)
                        {
                            case 1: CriarConta();break;
                            case 2: Login();break;
                            case 3: LoginAdmin();break;
                        }
                    }

                    else if (adminLogado != null)
                    {
                        op = MenuAdmin();
                        switch(op)
                        {
                            case 1: ListarPacote(); break;
                            case 2: InserirPacote();break;
                            case 3: AtualizarPacote();break;
                            case 4: ExcluirPacote();break;
                            case 5: ListarResponsavel();break;
                            case 6: CriarConta();break;
                            case 7: AtualizarUsuario();break;
                            case 8: ExcluirUsuario();break;
                            case 99: SairSistema();break;
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
            Console.WriteLine("Id de acesso");
        }

        static void InserirAdmin()
        {
            Console.WriteLine("Informe Nome");
            string n = Console.ReadLine();
            Console.WriteLine("Informe senha:");
            string s = Console.ReadLine();
            Admin a = new Admin{ nome = n, senha = s};
            Nadmin.Inserir(a);
            Console.WriteLine("Conta Criada");
        }
        static void LoginAdmin()
        {
            Console.WriteLine("Informe id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe senha:");
            string senha = Console.ReadLine();
            adminLogado = Nadmin.Login(id,senha);
            if (adminLogado == null)
            {
                Console.WriteLine("Id ou senha incorreta");
            }
            else{Console.WriteLine("Bem vindo");}
        }
        
        static void Login()
        {
            Console.WriteLine("Área de login");
            Console.WriteLine("Informe id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a senha");
            string senha = Console.ReadLine();
            usuarioLogado = Nresponsavel.Login(id,senha);
            // usuarioLogado = Nresponsavel.Login(id, senha);
            if (usuarioLogado == null)
            {
                Console.WriteLine("Usuário ou senha incorretos");
            }
            else{ Console.WriteLine("Bem vindo(a)");}

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
            Console.WriteLine("|99 - Sair  |");
            Console.WriteLine("|                     |");

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

        public static void AtualizarUsuario()
        {
            ListarResponsavel();
            Console.WriteLine("Informe o id para atualizar\n");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe nova senha");
            string s = Console.ReadLine();
            Console.WriteLine("Informe contato");
            string c = Console.ReadLine();
            Responsavel responsavel = new Responsavel {id = id , senha = s, contato = c };
            Nresponsavel.Atualizar(responsavel);
        }

        public static void ExcluirUsuario()
        {
            ListarResponsavel();
            Console.WriteLine("Infome o id para excluir:");
            int id = int.Parse(Console.ReadLine());
            Responsavel responsavel = new Responsavel {id = id};
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
            Pacote pac = new Pacote {id = id, descricao = s, horas = p, valor = v};
            Npacote.Atualizar(pac);
            Console.WriteLine("Informações atualizadas\n");
        }

        public static void ExcluirPacote()
        {
            ListarPacote();
            Console.WriteLine("Infome o id para excluir:");
            int id = int.Parse(Console.ReadLine());
            Pacote pac = new Pacote {id = id};
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
        public static int MenuVisitante()
        {
            Console.WriteLine("-----------Opções--------");
            Console.WriteLine("| 01 - Cadastrar      |");
            Console.WriteLine("| 02 - Login     |");
            return int.Parse(Console.ReadLine());

        }
        static void SairSistema()
        {
            SalvarResponsalvel();
            SalvarPacote();
            SalvarCrianca();
            SalvarAdmin();
            usuarioLogado = null;
        }

        static void SalvarResponsalvel()
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
            File.WriteAllText("admins.json",json);
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






    }
}

