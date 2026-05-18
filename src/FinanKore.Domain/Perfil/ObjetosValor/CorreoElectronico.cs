using FinanKore.Dominio.Excepciones;

namespace FinanKore.Dominio.Perfil.ObjetosValor;

public sealed class CorreoElectronico : Comun.ObjetoValor
{
    public string Valor { get; }

    public CorreoElectronico(string valor)
    {
        if (string.IsNullOrWhiteSpace(valor))
            throw new ExcepcionDominio("El correo electrónico no puede estar vacío.");

        if (!valor.Contains('@') || valor.Length < 5)
            throw new ExcepcionDominio("El formato del correo electrónico no es válido.");

        Valor = valor.Trim().ToLowerInvariant();
    }

    public static implicit operator string(CorreoElectronico correo) => correo.Valor;
    public static implicit operator CorreoElectronico(string valor) => new(valor);

    protected override IEnumerable<object> ObtenerComponentesIgualdad()
    {
        yield return Valor;
    }

    public override string ToString() => Valor;
}
