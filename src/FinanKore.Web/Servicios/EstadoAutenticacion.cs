namespace FinanKore.Web.Servicios;

public sealed class EstadoAutenticacion
{
    public UsuarioRegistradoDto? Usuario { get; set; }
    public bool Autenticado => Usuario is not null;
}
