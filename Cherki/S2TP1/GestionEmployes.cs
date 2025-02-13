namespace S2TP1;

public class GestionEmployes
{
    private Employee[] Liste = new Employee[30];
    private int NombreEmp;

    public void Ajouter(Employee E)
    {
        if (NombreEmp < 30)
        {
            Liste[NombreEmp] = E;
            NombreEmp++;
        }
    }

    public void Supprimer(Employee E)
    {
        int index = Array.IndexOf(Liste, E);
        if (index >= 0)
        {
            for(int i=index; i<NombreEmp; i++)
            {
                Liste[i] = Liste[i + 1];
            }
            NombreEmp--; 
        }

    }

    public float SalaireTotal()
    {
        float SalaireTotal=0;
        foreach (Employee E in Liste)
        {
            if(E!=null){
                SalaireTotal += E.salaire;
            }
        }

        return SalaireTotal;
    }

    public float SalaireMoyen()
    {
        float SalaireMoy = this.SalaireTotal() / NombreEmp;
        return SalaireMoy;
    }


}