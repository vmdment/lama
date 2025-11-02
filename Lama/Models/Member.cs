namespace Lama.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Celular { get; private set; }
        public string CorreoElectronico { get; set; }
        public DateTime? FechaIngreso { get; private set; }
        public string Direccion { get; set; }
        public int member { get; set; }
        public string Cargo { get; private set; }
        public string Rango { get; private set; }   
        public string Estatus { get; private set; }
        public DateTime? FechaNacimiento { get; private set; }
        public string Cedula { get; private set; }
        public string RH { get; private set; }
        public string EPS { get; private set; }
        public string Padrino { get; private set; }
        public string Foto { get; private set; }
        public string ContactoEmergencia { get; private set; }
        public string Ciudad { get; private set; }
        public string Moto { get; private set; }
        public int? AnoModelo { get; private set; }
        public string Marca { get; private set; }
        public int? CilindrajeCC { get; private set; }
        public string PlacaMatricula { get;  private set; }
        public DateTime? FechaExpedicionLicenciaConduccion { get; private set; }
        public DateTime? FechaExpedicionSOAT { get; private set; }

     public Member(int id, string nombre, string apellido, string celular, string correoElectronico, DateTime? fechaIngreso, string direccion, int member, string cargo, string rango, string estatus, DateTime? fechaNacimiento, string cedula, string rH, string ePS, string padrino, string foto, string contactoEmergencia, string ciudad, string moto, int? anoModelo, string marca, int? cilindrajeCC, string placaMatricula, DateTime? fechaExpedicionLicenciaConduccion, DateTime? fechaExpedicionSOAT)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
            CorreoElectronico = correoElectronico;
            FechaIngreso = fechaIngreso;
            Direccion = direccion;
            this.member = member;
            Cargo = cargo;
            Rango = rango;
            Estatus = estatus;
            FechaNacimiento = fechaNacimiento;
            Cedula = cedula;
            RH = rH;
            EPS = ePS;
            Padrino = padrino;
            Foto = foto;
            ContactoEmergencia = contactoEmergencia;
            Ciudad = ciudad;
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
