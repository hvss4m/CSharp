namespace TP2;

public class ConsoCafe
{
    private int _NoSemaine;
    public int NoSemaine
    {
        get { return _NoSemaine; }
        set { _NoSemaine = value; }
    }

    private int _ProgId;
    public int ProgId
    {
        get { return _ProgId; }
        set { _ProgId = value; }
    }

    private int _NbTasses;
    public int NbTasses
    {
        get { return _NbTasses; }
        set { _NbTasses = value; }
    }

    public ConsoCafe(int noSemaine, int progId, int nbTasses)
    {
        _NoSemaine = noSemaine;
        _ProgId = progId;
        _NbTasses = nbTasses;
    }
}