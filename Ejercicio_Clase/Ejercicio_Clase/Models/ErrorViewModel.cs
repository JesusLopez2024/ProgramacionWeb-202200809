namespace Ejercicio_Clase.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
public class EstadoCuenta
{
    public string Nombre { get; set; }
    public string NumeroCuenta { get; set; }
    public string Fecha { get; set; }
    public string Ciudad { get; set; }
    public string Pais { get; set; }
    public List<Transaccion> Transacciones { get; set; }
}

public class Transaccion
{
    public string Concepto { get; set; }
    public decimal Monto { get; set; }
}