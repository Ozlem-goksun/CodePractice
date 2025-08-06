// Polymorphism
using Polymorphism;

List<object> vehicles = new List<object>();
vehicles.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfWheels = 4 });
vehicles.Add(new Motorcycle { Brand = "Harley" });

//vehicle inspection
foreach (var vehicle in vehicles)
{
    if (vehicle is Car)
    {
        var car = (Car)vehicle;
        car.Start();
    }
    else if (vehicle is Motorcycle)
    {
        var motorcycle = (Motorcycle)vehicle;
        motorcycle.Start();
    }
}