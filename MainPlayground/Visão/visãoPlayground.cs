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
            if (obj.id > id) id = obj.id;
        id++;
        c.id = id;
        responsavel.Add(c);
        
    } //Responsavel tem atualizar senha e contato
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
            if (obj.id > id) id = obj.id;
        id++;
        b.id = id;
        crianca.Add(b);
        
    } //Criança tem atualizar pois pode ser removida
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
            if (obj.id > id) id = obj.id;
        id++;
        p.id = id;
        pac.Add(p);
        
    } // Tem atualizar
}

class Ncompra
{
    public static List<Compra> compra = new List<Compra>();

    public static List<Compra>Listar()
    {
        return compra;
    }

    public void Inserir(Compra compra)
    {
        int id = 0;
        foreach (Compra obj in compra)
            if (obj.id>id) id= obj.id;
        id++;
        compra.id=id;
        compra.Add(compra);    
    } //Compra tem atualizar pois será possível cancelar compra
}

class Nadmim
{
    public static List<Admin> adm = new List <Admin>();

    public static List<Admin>Listar()
    {
        return adm;
    }

    public static void Inserir(Admin adm)
    {
        int id = 0;
        foreach (Admin obj in adm)
            if (obj.id>id) id = obj.id;
        id++;
        adm.id = id;
        adm.Add(adm);   
    }// Admin tem atualizar:Senha
}