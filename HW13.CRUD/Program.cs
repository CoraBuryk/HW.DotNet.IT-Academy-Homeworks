using HW13.CRUD;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Hour)
    .CreateLogger();

Log.Information("The program starts");
int id = 0;
try
{
    List<Motorcycle> moto = new();
    moto.Add(new Motorcycle { Id = 1, Name = "Ducati", Model = "Scrambler Icon Dark", Odometer = 3500, Year = 2015 });
    moto.Add(new Motorcycle { Id = 2, Name = "Harley-Davidson", Model = "Sportster Sport 1200", Odometer = 8950, Year = 2003 });
    moto.Add(new Motorcycle { Id = 3, Name = "Yamaha", Model = "YZR-M1", Odometer = 2100, Year = 2013 });

    IMotorcycleRepository motorcycleRepository = new MotorcycleRepository(moto);

    var motocycles = motorcycleRepository.GetMotorcycles();
    foreach (var motorCycle in motocycles)
    {
        Console.WriteLine(motorCycle.ToString());
    }

    Console.Write("Enter ID: ");
    id = Convert.ToInt32(Console.ReadLine());
    var findMoto = motorcycleRepository.GetMotorcycleById(id);
    Console.WriteLine(findMoto.ToString());

    var newMoto = new Motorcycle { Id = 4, Name = "Aprilia", Model = "MANA 850", Odometer = 5600, Year = 2007 };
    motorcycleRepository.CreateMotorcycle(newMoto);
    Console.WriteLine(newMoto.ToString());

    Console.Write("Moto's ID to delete: ");
    id = Convert.ToInt32(Console.ReadLine());
    motorcycleRepository.DeleteMotorcycle(id);

    var update = motorcycleRepository.GetMotorcycleById(4);
    update.Odometer = 30000;
    update.Year = 2004;
    motorcycleRepository.UpdateMotorcycle(update);
    Console.WriteLine(update.ToString());

    motocycles = motorcycleRepository.GetMotorcycles();
    foreach (var motocycle in motocycles)
    {
        Console.WriteLine(motocycle.ToString());
    }
}
catch (Exception ex)
{
    ex = new MotorcycleNotFoundException($"{id} is not found");
    Log.Error(ex.Message);
    Log.Error(ex.StackTrace);
}
finally
{
    Log.Information("The program ends");
    Log.CloseAndFlush();
}