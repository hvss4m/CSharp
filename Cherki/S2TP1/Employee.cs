
namespace S2TP1;

public class Employee
{
    private string Nom;
    private float Salaire;
    private string Poste;
    private DateOnly DateEmb;

    public Employee(string nom, float salaire, string poste, DateOnly dateEmb)
    {
        Nom = nom;
        Salaire = salaire;
        Poste = poste;
        DateEmb = dateEmb;
    }

    public string nom
    {
        get { return Nom; }
        set { Nom = value; }
    }
    public float salaire
    {
        get { return Salaire; }
        set { Salaire = value; }
    }
    public string poste
    {
        get { return Poste; }
        set { Poste = value; }
    }
    public DateOnly dateEmb
    {
        get { return DateEmb; }
        set { DateEmb = value; }
    }
}