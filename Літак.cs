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
        return (FuelCapacity / FlightRange) * 1000;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("\n--- Інформація про літак ---");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Виробник: {Manufacturer}");
        Console.WriteLine($"Пасажиромісткість: {PassengerCapacity}");
        Console.WriteLine($"Максимальна швидкість: {MaxSpeed} км/год");
        Console.WriteLine($"Дальність польоту: {FlightRange} км");
        Console.WriteLine($"Ємність бака: {FuelCapacity} л");
        Console.WriteLine($"Екіпаж: {CrewCount} осіб");
        Console.WriteLine($"Витрати пального на 1000 км: {FuelConsumptionPer1000km():F2} л");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Airplane airplane = new Airplane();

        Console.Write("Введіть модель літака: ");
        airplane.Model = Console.ReadLine();

        Console.Write("Введіть виробника: ");
        airplane.Manufacturer = Console.ReadLine();

        Console.Write("Введіть пасажиромісткість: ");
        airplane.PassengerCapacity = int.Parse(Console.ReadLine());

        Console.Write("Введіть максимальну швидкість (км/год): ");
        airplane.MaxSpeed = double.Parse(Console.ReadLine());

        Console.Write("Введіть дальність польоту (км): ");
        airplane.FlightRange = double.Parse(Console.ReadLine());

        Console.Write("Введіть ємність бака (л): ");
        airplane.FuelCapacity = double.Parse(Console.ReadLine());

        Console.Write("Введіть кількість членів екіпажу: ");
        airplane.CrewCount = int.Parse(Console.ReadLine());

        airplane.DisplayInfo();
    }
}
