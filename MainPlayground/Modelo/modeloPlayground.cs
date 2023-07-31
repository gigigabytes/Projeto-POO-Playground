using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
class Responsavel
{
    public List<Crianca> Criancas { get; set; }
    public int id { get; set; }
    public string nome { get; set; }
    public string cpf { get; set; }
    public int idade { get; set; }
    public string contato { get; set; }
    public string senha { get; set; }


    public override string ToString() { return $"Id:{id} - Nome:{nome} - Contato:{contato} "; }

}

class Crianca
{
    public List<Crianca> Criancas { get; set; }
    public int idresponsavel {get;set;}
    public int id { get; set; }
    public string nome { get; set; }
    public int idade { get; set; }
    public string genero { get; set; }
    public string outros { get; set; }

    public override string ToString() { return $"Id:{id}Nome: {nome}, Idade: {idade}, Id responsavel: {idresponsavel}"; }
}

class Pacote
{
    public List<Pacote> pacs { get; set; }
    public int id { get; set; }
    public string descricao { get; set; }
    public string horas { get; set; } // Ajustar para período
    public double valor { get; set; }
    public override string ToString()
    {
        return $"{id} - {descricao} - Período:{horas} - Preço: R${valor} reais";
    }

   
}

class Admin
{
    public int id { get; set; }
    public string nome { get; set; }
    public string senha { get; set; }

    public override string ToString() { return $"{id} - {nome}"; }
}

class Compra
{
    public int idcompra {get;set;}
    public int idresponsavel { get; set; }
    public int idpacote { get; set; }
    
    public DateTime data { get; set; }
    
    public override string ToString() { return $"Dia da compra {data}, Id compra: {idcompra}, Comprado por: {idresponsavel}, Pacote comprado: {idpacote};"; }
}

class Recreacao
{
    public DateTime entrada { get; set; }
    public DateTime saida { get; set; }

    public override string ToString()
    {
        return $"Entrada:{entrada} - Saída {saida}";
    }
}




