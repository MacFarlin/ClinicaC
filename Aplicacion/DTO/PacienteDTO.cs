using Dominio.Value_Object; // Asegúrate de tener la referencia adecuada aquí

namespace Aplicacion.DTO
{
    public class PacienteDTO
    {
        public PacienteDTO(Guid id, string nombre, string apellido, DateTime fechaNacimiento, Estado.EstadoEnum estado)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Estado = estado;
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Estado.EstadoEnum Estado { get; set; }
    }
}