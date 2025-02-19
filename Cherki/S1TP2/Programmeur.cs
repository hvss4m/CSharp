namespace TP2;

public class Programmeur
{
    private int _Id;
    public int Id
    {
        get { return _Id;}
        set { _Id = value; }
    }

    private string _Nom;
    public string Nom
    {
        get { return _Nom;}
        set { _Nom = value; }
    }

    private string _Prenom;
    public string Prenom
    {
        get { return _Prenom;}
        set { _Prenom = value; }
    }
    private int _Bureau;
    public int Bureau
    {
        get { return _Bureau;}
        set { _Bureau = value; }
    }

    public Programmeur(int id, string nom="X", string prenom="X", int bureau=0)
    {
        _Id = id;
        _Nom = nom;
        _Prenom = prenom;
        _Bureau = bureau;
    }

    public void Afficher()
    {
        Console.WriteLine("ID: "+Id);
        Console.WriteLine("Nom: "+Nom);
        Console.WriteLine("Prenom: "+Prenom);
        Console.WriteLine("Bureau: "+Bureau);
    }
    
    
}