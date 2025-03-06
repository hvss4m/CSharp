namespace S3;

public abstract class Personnel: Personne
{
    private string bureau;
    private float salaire;

    public float Salaire
    {
        get { return salaire;}
        set { salaire = value; }
    }

    abstract public float calculerSalaire();
}