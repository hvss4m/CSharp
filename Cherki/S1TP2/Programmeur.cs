namespace TP2;

public class Programmeur
{
    public int Id;
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Bureau;

    public Programmeur(int id, string nom, string prenom, int bureau)
    {
        Id = id;
        Nom = nom;
        Prenom = prenom;
        Bureau = bureau;
    }
    
    
}