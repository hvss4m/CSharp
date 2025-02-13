namespace S2TP2;

public class Biblio
{
    private Document[] Liste = new Document[100];
    private int nbrDoc=0;

    public void Ajouter(Document D)
    {
        Liste[nbrDoc] = D;
        nbrDoc++;
    }

    public int nbrLivre()
    {
        int N=0;
        foreach (Document D in Liste)
        {
            if (D is Livre)
                N++;
        }

        return N;
    }

    public void AfficheDic()
    {
        foreach (Document D in Liste)
        {
            if (D is Dictionnaire)
            {
                Dictionnaire Doc = (Dictionnaire)D;
                Console.WriteLine("Titre: " + D.Titre+" ; Langue: "+Doc.Langue+" ; Nombre de définitions: "+ Doc.NbrMots);
            }
        }
    }

    public void tousLesAuteurs()
    {
        foreach (Document D in Liste)
        {
            if (D is Livre)
            {
                Livre L = (Livre) D;
                Console.WriteLine("Numéro d'enregistrement: "+L.NumEnr+" ; Auteur: "+L.Auteur);
            }
        }
    }

    public void toutesLesDescription()
    {
        foreach (Document D in Liste)
        {
            if (D is Livre)
            {
                Livre L = (Livre)D;
                L.description();
            }
            else if(D is Dictionnaire)
            {
                Dictionnaire Dic = (Dictionnaire)D;
                Dic.description();
            }
        }
    }

    static void Main(String[] args)
    {
        Livre L2 = new Livre("La Boîte à Merveilles", "Ahmed Sefrioui", 300);
        Document L1 = new Livre("Antigone","Inconnu" , 200);
        Dictionnaire D1 = new Dictionnaire("A Nous Le Monde", "Français", 500);
        Document D2 = new Dictionnaire("La Rousse", "Français", 800);

        Biblio B = new Biblio();
        
        B.Ajouter(L1);
        B.Ajouter(L2);
        B.Ajouter(D1);
        B.Ajouter(D2);
        
        //B.AfficheDic();

        //Console.WriteLine(B.nbrLivre());
        
        //B.tousLesAuteurs();
        
        B.toutesLesDescription();
    }
}