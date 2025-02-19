namespace TP2;

public class Projet
{
    private string Code;
    private string Sujet;
    private int Duree;
    private int NbrProg;
    private Programmeur[] Tab = new Programmeur[30];
    private ConsoCafe[] ListeConso = new ConsoCafe[100];
    private int NbrConso;

    public Projet(string code, string sujet, int duree)
    {
        Code = code;
        Sujet = sujet;
        if (duree > 0)
        {
            Duree = duree;
        }
        NbrProg = 0;
    }

    public void Ajouter(Programmeur P)
    {
        if (NbrProg<30)
        {
            Tab[NbrProg] = P;
            NbrProg++;
            //Console.WriteLine("Programmeur "+P.Nom+" "+P.Prenom+" ajouté avec succés");
        }
        else
        {
            Console.WriteLine("Le groupe du projet est plein");
        }
    }

    public void Rechercher(string nom)
    {
        bool x=false;
        foreach (Programmeur P in Tab)
        {
            if (P != null && P.Nom == nom)
            {
                P.Afficher();
                x = true;
                break;
            }
        }
        if(x==false)
            Console.WriteLine("Ce programmeur n'existe pas dans ce projet");
    }

    public void AfficherAll()
    {
        bool x = false;
        foreach (Programmeur P in Tab)
        {
            if (P != null)
            {
                P.Afficher();
                Console.WriteLine("==============================");
                x = true;
            }
        }
        if(x==false)
            Console.WriteLine("Ce projet ne contient aucun programmeur");
        
    }

    public void Supprimer(Programmeur P)
    {
        int index = Array.IndexOf(Tab, P);
        if (index >= 0)
        {
            for(int i=index; i<NbrProg; i++)
            {
                Tab[i] = Tab[i + 1];
            }
            NbrProg--; 
        }
    }

    public void AjouterConso(ConsoCafe C)
    {
        bool x = false;
        foreach (Programmeur P in Tab)
        {
            if (P.Id == C.ProgId)
            {
                ListeConso[NbrConso] = C;
                x = true;
                NbrConso++;
                break;
            }
        }
        if(x=false)
            Console.WriteLine("Ce programmeur n'existe pas");
        
    }

    public void ChangeBureau(Programmeur P, int B)
    {
        foreach (Programmeur Q in Tab)
        {
            if (P == Q)
            {
                Q.Bureau = B;
                break;
            }
        }
    }

    public void TassesPerWeek(int N)
    {
        int Conso = 0;
        foreach (ConsoCafe C in ListeConso)
        {
            if (C!=null && C.NoSemaine == N)
                Conso += C.NbTasses;
        }

        Console.WriteLine("Le nombre des tasses consommées durant la semaine "+N+" est "+Conso);
    }

    static void Main(String[] args)
    {
        Projet P = new Projet("1","Application", 5);
        
        Programmeur H = new Programmeur(1, "Cherki", "Houssam", 12);
        Programmeur A = new Programmeur(2, "Berkoukt", "Amine", 17);
        Programmeur L = new Programmeur(3, "Ranbouk", "Lamia", 33);
        
        ConsoCafe C = new ConsoCafe(1, 1, 15);
        ConsoCafe D = new ConsoCafe(1, 2, 15);
        ConsoCafe E = new ConsoCafe(2, 3, 15);
        ConsoCafe F = new ConsoCafe(1, 4, 15);

        P.Ajouter(A);
        P.Ajouter(H);
        P.Ajouter(L);
        //P.Supprimer(A);
        
        //P.AfficherAll();
        
        P.AjouterConso(C);
        //P.AjouterConso(F);
        P.AjouterConso(E);
        P.AjouterConso(D);
        P.TassesPerWeek(2);
    }
    
}