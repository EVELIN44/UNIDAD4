
namespace AppClaseVehicle
{
    internal class PrincipalProgram

    {
        static void Main()
        {
            // Crear una instancia de la clase derivada
            Car myCar = new Car("Sedán", 2022, "Toyota");

            // Llamar a métodos de la clase base
            myCar.MostrarDetalles();

            // Llamar a métodos de la clase derivada
            myCar.Sound();
        }
    }

}
