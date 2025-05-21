using Task1.Domain;
using Task1.Domain.Models;

List<Car> europeanCar = CarsData.Cars.Where(x => x.Origin == "Europe").ToList();

foreach (var car in europeanCar)
{
    Console.WriteLine($"The {car.Model} has origin in Europe");
}

Console.WriteLine("\n"); // => This line is just for separating the printlines

CarsData.LoadCars();

Func<Car, bool> moreCylinders = car => car.Cylinders > 6;
Func<Car, bool> fourCylindersAndHighHP = car => car.Cylinders == 4 && car.HorsePower > 110.0;

Action<Car> printCar = car => Console.WriteLine($"{car.Model}, Cylinders: {car.Cylinders}, HorsePower: {car.HorsePower}");

var result = CarsData.Cars.Where(moreCylinders).Concat(CarsData.Cars.Where(fourCylindersAndHighHP)).ToList();

foreach (var car in result)
{
    printCar(car);
}

Console.WriteLine("\n"); // => This line is just for separating the printlines 

var groupedCars = CarsData.Cars.GroupBy(car => car.Origin).Select(x => new { Origin = x.Key, Count = x.Count() });

foreach (var grouped in groupedCars)
{
    Console.WriteLine($"{grouped.Origin}: {grouped.Count} models");
}

Console.WriteLine("\n"); // => This line is just for separating the printlines 

Func<Car, bool> powerfulCar = car => car.HorsePower > 200;
Func<Car, double> carMpg = car => car.MilesPerGalon;

var powerfulCars = CarsData.Cars.Where(powerfulCar).ToList();

if (powerfulCars.Any())
{
    var minMpg = powerfulCars.Min(carMpg);
    var maxMpg = powerfulCars.Max(carMpg);
    var avgMpg = powerfulCars.Average(carMpg);

    foreach(var powerCar in powerfulCars)
    {
        Console.WriteLine($"Car with more than 200 HorsePower: {powerCar.Model}");
    }
    Console.WriteLine($"Lowest MilePerGalon: {minMpg}");
    Console.WriteLine($"Highest MilePerGalo: {maxMpg}");
    Console.WriteLine($"Average MilePerGalon: {avgMpg}");
}
else
{
    Console.WriteLine("No cars found with more than 200 HorsePower and valid MilePerGalon.");
}