namespace FinanKore.Dominio.Excepciones;

public class ExcepcionDominio : Exception
{
    public ExcepcionDominio(string mensaje) : base(mensaje) { }

    public ExcepcionDominio(string mensaje, Exception excepcionInterna)
        : base(mensaje, excepcionInterna) { }
}
