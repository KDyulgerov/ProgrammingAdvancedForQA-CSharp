string input = Console.ReadLine();

Catalog catalog = new Catalog();

while (input != "end")
{
    string[] currentInput = input.Split("/").ToArray();
    string type = currentInput[0];
    string brand = currentInput[1];
    string model = currentInput[2];

    if (type == "Car")
    {
        int horsePower = int.Parse(currentInput[3]);

        Car car = new Car(brand, model, horsePower);
        catalog.Cars.Add(car);
        
    }
    else if (type == "Truck")
    {
        int weight = int.Parse(currentInput[3]);

        Truck truck = new Truck (brand, model, weight);
        catalog.Trucks.Add(truck);
    }

    input = Console.ReadLine();
}

if (catalog.Cars.Count > 0)
{
    List<Car> orderedCars = catalog.Cars.OrderBy(c => c.Brand).ToList();

    Console.WriteLine("Cars:");

    foreach (Car car in orderedCars)
    {
        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
    }
}

if (catalog.Trucks.Count > 0)
{
    List<Truck> orderedTrucks = catalog.Trucks.OrderBy(c => c.Brand).ToList();

    Console.WriteLine("Trucks:");

    foreach (Truck truck in orderedTrucks)
    {
        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
    }
}

