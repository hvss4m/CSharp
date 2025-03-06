namespace S3;

public class Directeur : Personnel
{
    private float PrimeDeplacement;
    private static Directeur instance;

    public static Directeur GetInstance()
    {
        if (instance == null)
        {
            instance = new Directeur();
        }

        return instance;
    }
    
    public override float calculerSalaire()
    {
        return base.Salaire + PrimeDeplacement;
    }
}