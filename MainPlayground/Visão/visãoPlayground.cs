using System;
using System.Collections.Generic;

class Nresponsavel
{
    public static List<Responsavel> responsavel = new List<Responsavel>();
    // public static Responsavel Login(int id, string senha){
    //     foreach (Responsavel obj in responsavel){
    //         if (obj.id == id && obj.senha == senha) return obj;
    //     return null;    
    //     }
    // }
    public static List<Responsavel> Listar()
    {
        return responsavel;
    }
    public static void Inserir(Responsavel c)
    {
        int id = 0;
        foreach (Responsavel obj in responsavel)
        {
            if (obj.id > id) id = obj.id;
            id++;
            c.id = id;
            responsavel.Add(c);
        }
    }
}


class Ncrianca
{
    public static List<Crianca> crianca = new List<Crianca>();
    public static List<Crianca> Listar()
    {
        return crianca;
    }
    public static void Inserir(Crianca b)
    {
        int id = 0;
        foreach (Crianca obj in crianca)
        {
            if (obj.id > id) id = obj.id;
            id++;
            b.id = id;
            crianca.Add(b);
        }
    }
}

class Npacote
{
    public static List<Pacote> pac = new List<Pacote>();

    public static List<Pacote> Listar()
    {
        return pac;
    }
    public static void Inserir(Pacote p)
    {
        int id = 0;
        foreach (Pacote obj in pac)
        {
            if (obj.id > id) id = obj.id;
            id++;
            p.id = id;
            pac.Add(p);
        }
    }
}