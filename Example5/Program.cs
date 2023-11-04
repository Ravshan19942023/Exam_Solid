public interface IPrinter
{
    void Print();
    void Scan();
    void Photocopy();
}



public class AllInOneDevice : IPrinter
{
    public interface IPrint
    {
        public void Print();
    }

    public interface IScan 
    {
        public void Scan();
    }

    public interface IPhotocopy
    {
        public void Photocopy();
    }
}

public class PrinterOnlyDevice : IPrinter
{
   

    public interface IPrint
    {
       public void Print()
    }

    
}

public class ScannerOnlyDevice : IPrinter
{
    public void Photocopy()
    {
        throw new NotImplementedException();
    }

    public void Print()
    {
        throw new NotImplementedException();
    }

    public void Scan()
    {
        // Scan something.
    }
}
   
