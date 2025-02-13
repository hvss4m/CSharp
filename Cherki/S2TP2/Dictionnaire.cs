using System.ComponentModel;

namespace S2TP2;

public class Dictionnaire : Document
{
    private string langue;

    public string Langue
    {
        get { return langue; }
        set { langue = value; }
    }
    private int nbrMots;
    public int NbrMots    
    {
        get { return nbrMots; }
        set { nbrMots = value; }
    }

    public Dictionnaire(string T, string L, int N) : base(T)
    {
        langue = L;
        nbrMots = N;
    }

    public void description()
    {
        base.description();
        Console.WriteLine("     Langue: "+Langue+" | Nombre de definitions: "+NbrMots);
        
    }
    
    
}