namespace S2TP2;

public class Document
{
    private static int Count;
    private int numEnr;
    private string titre;
    public int NumEnr    
    {
        get { return numEnr; }
        set { numEnr = value; }
    }
    public string Titre    
    {
        get { return titre; }
        set { titre = value; }
    }

    public Document(string T="X")
    {
        numEnr=++Count;
        titre = T;
    }

    public void description()
    {
        Console.WriteLine("Numéro d'enregistrement: "+NumEnr+" | Titre: "+Titre);
    }
}