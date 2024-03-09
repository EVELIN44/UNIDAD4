

    class Car : Vehicle
    {
        public string Brand { get; set; }

        // Constructor
        public Car(string model, int year, string brand)
        {
            Model = model;
            Year = year;
            Brand = brand;
        }

        // Método
        public void Sound()
        {
            Console.WriteLine("Rooom!");
        }
    }

    

