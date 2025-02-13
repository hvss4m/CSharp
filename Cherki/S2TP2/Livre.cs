namespace S2TP2;

public class Livre : Document
{
    private string auteur;

    public string Auteur
    {
        get { return auteur; }
        set { auteur = value; }
    }
    private int nbrPages;
    public int NbrPages
    {
        get { return nbrPages; }
        set { nbrPages = value; }
    }

    public Livre(string T="X", string A="Inconnu", int N=0) : base(T)
    {
        auteur = A;
        nbrPages = N;
    }
    
    public void description()
    {
        base.description();
        Console.WriteLine("     Auteur: "+Auteur+" | Nombre de definitions: "+NbrPages);
        
    }
}