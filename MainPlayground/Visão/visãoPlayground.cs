using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
[XmlRoot("Responsavel")]
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
            if (obj.id > id)
            {
                id = obj.id;
            }
        }
        id++;
        c.id = id;
        responsavel.Add(c);
    }

//     public static void Salvar()
//     {
//         XmlSerializer xml = new XmlSerializer(typeof(List<Responsavel>));
//     }

//     public static void Abrir()
//     {
//         XmlSerializer xml = new XmlSerializer(typeof(List<Responsavel>));
//         StreamReader f = null;
//         try
//         {
//             f = new StreamReader ("resplist.xml");
//             responsavel = (List<Responsavel>)xml.Deserialize(f);
//         }

//         catch
//         {
//             responsavel = new List<Responsavel>();
//         }

//         finally
//         {
//             if  (f!= null)f.Close();
//         }

//     }
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
            if (obj.id > id) 
            {
                id = obj.id;
            }
            
        }
        id++;
        b.id = id;
        crianca.Add(b);
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

    // public static void Salvar()
    // {
    //     XmlSerializer xml = new XmlSerializer(typeof(List<Pacote>));


    //     using (StreamWriter f = new StreamWriter("pacote.xml"))
    //     {
    //         xml.Serialize(f,pac);
    //     }
    // }

    // public static void Abrir()
    // {
    //     XmlSerializer xml = new XmlSerializer(typeof(List<Pacote>));
    //     StreamReader f = null;

    //     try 
    //     {
    //         f = new StreamReader("pacote.xml");
    //         pac = (List<Pacote>) xml.Deserialize(f);
    //     }

    //     catch
    //     {
    //         pac = new List<Pacote>();
    //     }

    //     finally
    //     {
    //         if (f != null) f.Close();
    //     }
    // }
}


