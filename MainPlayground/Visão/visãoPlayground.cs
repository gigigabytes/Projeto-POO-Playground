class Nresponsavel{
    public static List<Responsavel> responsavel = new List<Responsavel>();
    // public static Responsavel Login(int id, string senha){
    //     foreach (Responsavel obj in responsavel){
    //         if (obj.id == id && obj.senha == senha) return obj;
    //     return null;    
    //     }
    // }
    public static List<Responsavel> Listar(){
        return responsavel;
    }
    public static void Inserir(Responsavel c){
        int id = 0;
        foreach(Responsavel obj in responsavel){
            if (obj.id >id) id = obj.id;
        id++;
        c.id=id;
        responsavel.Add(c);    
        }
    }
}




class Ncrianca{}