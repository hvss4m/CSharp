namespace S1TP1;

public class Repertoire
{
    private string Nom;
    private int Nbr_fichiers;
    private Fichier[] Tab=new Fichier[30];

    public Repertoire(string nom="Repertoire", int nbrFichiers=0)
    {
        Nom = nom;
    }

    public void Afficher()
    {
        Console.WriteLine("Répertoire: "+Nom);
        foreach(Fichier F in Tab)
        {
            if (F != null)
            {
                Console.WriteLine("Fichiers:");
                Console.WriteLine(F.Nom);
            }
        }
    }

    public int Rechercher(string N)
    {
        int indice = 0;
        foreach (Fichier F in Tab)
        {
            if (F != null && F.Nom == N) 
                return indice;
            indice++;
        }
        return -1;
    }

    public void Ajouter(Fichier F)
    {
        if (Nbr_fichiers < 30)
        {
            Tab[Nbr_fichiers] = F;
            Nbr_fichiers++;
            Console.WriteLine(F.Nom+ " ajouté avec succés");
        }
        else
        {
            Console.WriteLine("Le répertoire est plein");
        }

    }

    public void Rechercher1(string ext)
    {
        foreach (Fichier F in Tab)
        {
            if(F!=null && F.Extension==ext)
                Console.WriteLine(F.Nom);
        }
    }

    public void Supprimer(string N)
    {
        int x = this.Rechercher(N);
        if (x > -1)
        {
            for (int i = x; i < Nbr_fichiers; i++)
                Tab[i] = Tab[i + 1];
            Console.WriteLine("Element supprimé avec succés");
        }
    }

    public float getTaille()
    {
        float Total=0;
        foreach (Fichier F in Tab)
        {
            if(F!=null)
                Total += F.Taille;
        }

        Total = Total / 1024;
        return Total;
    }

    static void Main(string[] args)
    {
        Repertoire Rep = new Repertoire("Houssam");
        Fichier F = new Fichier("File", "pdf", 50000);
        Fichier A = new Fichier("Notes", "csv", 12689);
        Rep.Ajouter(F);
        Rep.Ajouter(A);
        /*Rep.Afficher();
        int x = Rep.Rechercher("Notes");
        Console.WriteLine(x);
        Rep.Rechercher1("csv");
        Rep.Supprimer("File");
        Rep.Afficher();*/

        float Total = Rep.getTaille();
        Console.WriteLine(Total);

    }

}