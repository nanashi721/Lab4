using System;

class Airplane
{
    public string Model;
    public string Manufacturer;
    public int PassengerCapacity;
    public double MaxSpeed;
    public double FlightRange;
    public double FuelCapacity;
    public int CrewCount;

    public double FuelConsumptionPer1000km()
    {
        if (FlightRange == 0) return 0;
        return FuelCapacity / (FlightRange / 1000);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Модель літака: {Model}");
        Console.WriteLine($"Виробник: {Manufacturer}");
        Console.WriteLine($"Кількість пасажирів: {PassengerCapacity}");
        Console.WriteLine($"Максимальна швидкість: {MaxSpeed} км/год");
        Console.WriteLine($"Дальність польоту: {FlightRange} км");
        Console.WriteLine($"Об'єм пального: {FuelCapacity} літрів");
        Console.WriteLine($"Екіпаж: {CrewCount} осіб");
        Console.WriteLine($"Витрати пального на 1000 км: {FuelConsumptionPer1000km():F2} л");
    }
}
