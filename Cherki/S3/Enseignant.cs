namespace S3;

public class Enseignant : Personnel
{
    private float primeDeplacement;
    private int heureSup;
    private string grade;
    private int volumeHoraire;
    private Dictionary<string, List<Etudiant>> Groupe=new Dictionary<string, List<Etudiant>>();
    
    public override float calculerSalaire()
    {
        switch (grade)
        {
            case "PA": return (heureSup + volumeHoraire) * 300 + primeDeplacement;
            case "PH": return (heureSup + volumeHoraire) * 350 + primeDeplacement;
            case "PES": return (heureSup + volumeHoraire) * 400 + primeDeplacement;
            default: return -1;
        }
    }

    public void AjouterEtud(Etudiant E, string G)
    {
        if (!Groupe.ContainsKey(G))
        {
            Groupe[G] = new List<Etudiant>();
        }
        Groupe[G].Add(E);
        
    }
    
    
}