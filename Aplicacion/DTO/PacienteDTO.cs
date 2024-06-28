using Dominio.Value_Object;

namespace Aplicacion.DTO
{
    public class PacienteDTO
    {
        public PacienteDTO(Guid guid, string Nombre, string Apellido, DateTime FechaNacimiento, Estado.EstadoEnum Estado)
        {
        }
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Estado.EstadoEnum Estado { get; set; }
    }
}
