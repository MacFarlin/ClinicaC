using Dominio.Value_Object;
namespace Dominio.Entidades
{
    public class Paciente
    {
        private Identificador id;
        private Nombre nombre;
        private Apellido apellido;
        private FechaNacimiento fechaNacimiento;
        private Estado estado; // Nuevo atributo

        public Paciente(Guid id, string nombre, string apellido, DateTime fechaNacimiento, Estado.EstadoEnum estado)
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.apellido = new Apellido(apellido);
            this.fechaNacimiento = new FechaNacimiento(fechaNacimiento);
            this.estado = new Estado(estado);
        }

        public Guid Id => this.id.GetValor();
        public string Nombre => this.nombre.GetValor();
        public string Apellido => this.apellido.GetValor();
        public DateTime FechaNacimiento => this.fechaNacimiento.GetValor();
        public Estado.EstadoEnum GetEstado => this.estado.GetValor();

        public void ActualizarNombre(string nombre)
        {
            this.nombre = new Nombre(nombre);
        }
        public void ActualizarApellido(string apellido)
        {
            this.apellido = new Apellido(apellido);
        }
        public void ActualizarFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = new FechaNacimiento(fechaNacimiento);
        }

        // Métodos de ESTADO
        public void ActualizarEstado(Estado.EstadoEnum nuevoEstado)
        {
            this.estado = new Estado(nuevoEstado);
        }
        public void Borrar()
        {
            this.estado = new Estado(Estado.EstadoEnum.Inactivo);
        }
    }
}