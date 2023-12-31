using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Nresponsavel
{
    public static List<Responsavel> responsavel = new List<Responsavel>();
    public static Responsavel Login (int id, string senha)
    {
        foreach (Responsavel obj in responsavel)
        {
            if (obj.id == id && obj.senha == senha) return obj;
              
        }
        return null;
    }
    public static List<Responsavel> Listar()
    {
        return responsavel;
    }

    public static Responsavel Listar(int id)
    {
        foreach(Responsavel obj in responsavel)
        {
            if(obj.id == id) return obj;
        }
        return null;
    }
    public static void Inserir(Responsavel c)
    {
        int id = 0;
        foreach (Responsavel obj in responsavel)
        {
            if (obj.id > id)
            {
                id = obj.id;
            }
        }
        id++;
        c.id = id;
        responsavel.Add(c);
    }

    public static void Excluir(Responsavel c)
    {
        Responsavel obj = Listar(c.id);
        if (obj != null) responsavel.Remove(obj);
    }

    public static void Atualizar(Responsavel c)
    {
        Responsavel obj = Listar(c.id);
        if (obj != null)
        {
            obj.senha = c.senha;
            obj.contato = c.contato;
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
    public static Crianca Listar(int id)
    {   
        
       foreach(Crianca obj in crianca)
        {
            if (obj.id == id) return obj;
        }
        return null;
    }
    public static void Inserir(Crianca b)
    {
        int id = 0;
        foreach (Crianca obj in crianca)
        {
            if (obj.id > id) 
            {
                id = obj.id;
            } 
        }
        id++;
        b.id = id;
        crianca.Add(b);
    }

     public static void Excluir(Crianca b)
    {
        Crianca obj = Listar(b.id);
        if (obj != null) crianca.Remove(obj);
    }

     public static void Atualizar(Crianca b)
    {
        Crianca obj = Listar(b.id);
        if (obj != null)
        {
            obj.outros = b.outros;
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
            if (obj.id > id)
            {
                id = obj.id;
            } 
        }
        id++;
        p.id = id;
        pac.Add(p);
    }

    public static Pacote Listar (int id)
    {
        foreach(Pacote obj in pac)
        {
            if (obj.id == id) return obj;
        }
        return null;
    }

    public static void Atualizar(Pacote pac)
    {
        Pacote obj = Listar(pac.id);
        if (obj != null)
        {
            obj.descricao = pac.descricao;
            obj.valor = pac.valor;
            obj.horas = pac.horas;
        }
    }

    public static void ExcluirPacote(Pacote p)
    {
        Pacote obj = Listar(p.id);
        if (obj != null) pac.Remove(obj);
    }

}
//
class Ncompra
{
    public static List<Compra> compras = new List<Compra>();
     public static List<Compra> Listar()
    {
        return compras;
    }
    public static void Inserir(Compra c)
    {
        int id = 0;
        foreach (Compra obj in compras)
        {
            if (obj.idcompra > id)
            {
                id = obj.idcompra;
            } 
        }
        id++;
        c.idcompra = id;
        compras.Add(c);
    }

    public static Compra Listar (int id)
    {
        foreach(Compra obj in compras)
        {
            if (obj.idcompra == id) return obj;
        }
        return null;
    }

    public static void Atualizar(Compra compras)
    {
        Compra obj = Listar(compras.idcompra);
        if (obj != null)
        {
            obj.idresponsavel = compras.idresponsavel;
        }
    }

    public static void ExcluirCompra(Compra c)
    {
        Compra obj = Listar(c.idcompra);
        if (obj != null) compras.Remove(obj);
    }


}
//

class Nadmin
{
    public static List<Admin> adm = new List<Admin>();
    public static Admin Login (int id,string senha)
    {
        foreach(Admin  obj in adm)
        {
            if (obj.id == id && obj.senha == senha) return obj;
        }
        return null;
    }

    public static List<Admin> Listar()
    {
        return adm;
    }

    public static Admin Listar(int id)
    {
        foreach(Admin obj in adm)
        {
            if (obj.id == id) return obj;
        }
        return null;
    }

    public static void Inserir(Admin a)
    {
        int id = 0;
        foreach (Admin obj in adm)
        {
            if (obj.id > id)
            {
                id = obj.id;
            }
        }
        id++;
        a.id=id;
        adm.Add(a);
    }

    public static void Excluir (Admin a)
    {
        Admin obj = Listar(a.id);
        if(obj!= null) adm.Remove(obj);
    }

    public static void Atualizar(Admin a)
    {
        Admin obj = Listar(a.id);
        if (obj != null)
        {
            obj.senha = a.senha;
        }
    }
}


