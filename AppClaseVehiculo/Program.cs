

    // Clase base
    class Vehicle
{
       public string Model { get; set; }
       public int Year { get; set; }

    // Método
    public void MostrarDetalles()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
    }
}

