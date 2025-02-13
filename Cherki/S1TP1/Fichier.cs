namespace S1TP1;

public class Fichier
{
    public string Nom {get;set;}
    public string Extension { get; set; }
    public float Taille{ get; set; }

    public Fichier(string nom, string extension, float taille)
    {
        Nom = nom;
        Extension = extension;
        if (taille > 0)
        {
            Taille = taille;
        }
        else
        {
            Console.WriteLine("Veuillez inserer une valeur valide pour la taille");
        }
    }

    public void Renommer(string N)
    {
        Nom = N;
    }

    public void Modifier(float T)
    {
        if (T > 0)
        {
            Taille = T;
        }
        else
        {
            Console.WriteLine("Veuillez inserer une valeur valide pour la taille");
        }
    }
}