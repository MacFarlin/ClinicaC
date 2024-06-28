namespace Dominio.Value_Object
{
    public class FechaNacimiento
    {
        private DateTime valor;

        public FechaNacimiento(DateTime valor)
        {
            this.valor = valor;
            this.debeSerMayorA18Anios(valor);
        }

        private void debeSerMayorA18Anios(DateTime valor)
        {
            DateTime hoy = DateTime.Today;  // Obtiene la fecha actual sin la hora.
            int edad = hoy.Year - valor.Year;  // Calcula la edad inicial.

            // Verifica si la fecha de nacimiento es posterior a la fecha actual en el año.
            // Si es así, resta un año de la edad, porque aún no ha tenido su cumpleaños este año.
            if (valor.Date > hoy.AddYears(-edad))
            {
                edad--;
            }

            if (edad < 18)
            {
                throw new Exception("Debe ser mayor de 18 años.");
            }
        }
        public DateTime GetValor()
        {
            return this.valor;
        }
    }
}
