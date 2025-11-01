namespace Lama.Domain
{
    public class Member
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Moto { get; private set; }
        public int? AnoModelo { get; private set; }
        public string Marca { get; private set; }
        public int? CilindrajeCC { get; private set; }
        public string PlacaMatricula { get;  private set; }
        public DateTime? FechaExpedicionLicenciaConduccion { get; private set; }
        public DateTime? FechaExpedicionSOAT { get; private set; }

        public Member(int id, string nombre, string apellido, string moto, int? anoModelo, string marca, int? cilindrajeCC, string placaMatricula, DateTime? fechaExpedicionLicenciaConduccion, DateTime? fechaExpedicionSOAT)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Moto = moto;
            AnoModelo = anoModelo;
            Marca = marca;
            CilindrajeCC = cilindrajeCC;
            PlacaMatricula = placaMatricula;
            FechaExpedicionLicenciaConduccion = fechaExpedicionLicenciaConduccion;
            FechaExpedicionSOAT = fechaExpedicionSOAT;
        }

    }
}
