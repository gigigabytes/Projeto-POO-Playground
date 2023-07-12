class Responsavael{
    public int id { get; set;}
    public string nome { get; set}
    public string cpf { get; set}
    public int idade { get; set}
    public string contato { get; set}
    public int saldo { get; set}

}

class Crianca{
    public int id { get; set}
    public string nome { get; set}
    public int idade { get; set}
    public string genero { get; set}
    public string outros { get; set}
}

class Pacote{
    public int id { get; set}
    public string descricao { get; set}
    public string horas { get; set}
    public double valor { get; set}
    public override string ToString() { 
        return $"{id} - {descricao} - Duração:{horas} - Preço:{valor}";}
}

class Admin{
    public int id { get; set}
    public string senha { get; set}
}