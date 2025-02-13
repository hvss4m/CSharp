namespace TP2;

public class Projet
{
    private string Code;
    private string Sujet;
    private int Duree;
    private int NbrProg;
    private Programmeur[] Tab = new Programmeur[30];

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
                Console.WriteLine("ID: "+P.Id);
                Console.WriteLine("Nom: "+P.Nom);
                Console.WriteLine("Prenom: "+P.Prenom);
                Console.WriteLine("Bureau: "+P.Bureau);
                x = true;
            }
        }
        if(x==false)
            Console.WriteLine("Ce programmeur n'existe pas dans ce projet");
    }

    static void Main(String[] args)
    {
        Projet P = new Projet("1","Application", 5);
        Programmeur H = new Programmeur(1, "Cherki", "Houssam", 12);
        Programmeur A = new Programmeur(2, "Berkoukt", "Amine", 17);
        Programmeur L = new Programmeur(3, "Ranbouk", "Lamia", 33);
        
        P.Ajouter(A);
        P.Ajouter(H);
        P.Ajouter(L);
        
        P.Rechercher("Cherki");
    }
    
}