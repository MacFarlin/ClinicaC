using Aplicacion.DTO;
using Aplicacion.Servicios;
using Persistencia_de_Datos;
using Dominio.Value_Object;

namespace Presentacion.Consola
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Instanciar el repositorio en memoria
            DoctorRepositorioEnMemoria doctorRepositorio = new DoctorRepositorioEnMemoria();

            // Instanciar el servicio de aplicación
            IDoctorServicio doctorServicio = new DoctorServicio(doctorRepositorio);

            // Ejemplo de uso del servicio
            // Listar doctores
            var doctores = doctorServicio.ListarDoctores();
            foreach (var doctor in doctores)
            {
                Console.WriteLine($"ID: {doctor.Id}, Nombre: {doctor.Nombre}, Apellido: {doctor.Apellido}");
            }

            // Registrar un nuevo doctor
            DoctorDTO nuevoDoctor = new DoctorDTO(
                Guid.NewGuid(), "Ana", "López", DateTime.Now, Estado.EstadoEnum.Activo);
            doctorServicio.RegistrarDoctor(nuevoDoctor);

            // Mostrar información actualizada
            Console.WriteLine("\nDoctores actualizados:");
            doctores = doctorServicio.ListarDoctores();
            foreach (var doctor in doctores)
            {
                Console.WriteLine($"ID: {doctor.Id}, Nombre: {doctor.Nombre}, Apellido: {doctor.Apellido}");
            }

            Console.ReadLine(); // Para mantener la consola abierta
        }
    }
}