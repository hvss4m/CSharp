namespace S2TP1;

public class Directeur
{
    private static Directeur instance;
    private GestionEmployes GE;

    public GestionEmployes ge
    {
        get { return GE;}
        set { GE = value; }
    }

    private Directeur()
    {
        GestionEmployes GE = new GestionEmployes();
    }
    
    public static Directeur Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Directeur();
            }
            return instance;
        }
    }

    public float getTotal()
    {
        return GE.SalaireTotal();
    }

    public float getMoyen()
    {
        return GE.SalaireMoyen();
    }

    public void setGestionEmployes(GestionEmployes ge)
    {
        GE = ge;
    }
    
    static void Main(string[] args)
    {
        GestionEmployes GE = new GestionEmployes();
        
        Employee A = new Employee("Houssam Cherki", 1200, "Vice directeur", new DateOnly(2000, 12, 12));
        Employee C = new Employee("Ahmed Cherki", 6535, "Vice directeur", new DateOnly(2000, 12, 12));
        Employee B = new Employee("Fati Cherki", 9288, "Vice directeur", new DateOnly(2000, 12, 12));
        
        GE.Ajouter(A);
        GE.Ajouter(C);
        GE.Ajouter(B);

        Directeur D = new Directeur();
        
        
        D.setGestionEmployes(GE);

        float T= D.getTotal();

        float M = D.getMoyen();
        
        
        
        Console.WriteLine(T);
        Console.WriteLine(M);
    }
    
}