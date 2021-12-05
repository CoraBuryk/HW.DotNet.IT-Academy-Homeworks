using HW14.Generic;
using Serilog;

Log.Logger = new LoggerConfiguration()
   .MinimumLevel.Debug()
   .WriteTo.Console()
   .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Minute)
   .CreateLogger();

Log.Information("The program starts");

try
{
    MotorcycleRepository motorcycles = new MotorcycleRepository();
    motorcycles.Add(new Moto { Id = 1, Name = "Ducati", Model = "Scrambler Icon Dark", Odometer = 3500, Year = 2015 });
    motorcycles.Add(new Moto { Id = 2, Name = "Harley-Davidson", Model = "Sportster Sport 1200", Odometer = 8950, Year = 2003 });
    motorcycles.Add(new Moto { Id = 3, Name = "Yamaha", Model = "YZR-M1", Odometer = 2100, Year = 2013 });

    motorcycles.Print();
    Moto newMoto = new Moto { Id = 4, Name = "Aprilia", Model = "MANA 850", Odometer = 5600, Year = 2007 };
    motorcycles.Add(newMoto);
    motorcycles.Print();
    Console.WriteLine(motorcycles.GetById(newMoto.Id));
    newMoto.Name = "Suzuki";
    newMoto.Model = "GSX R1000";
    newMoto.Odometer = 0;
    newMoto.Year = 2021;
    motorcycles.Update(newMoto);
    motorcycles.Print();
    Thread.Sleep(80 * 1000);
    motorcycles.Delete(newMoto.Id);
    motorcycles.Print();
    Moto newMoto1 = new Moto { Id = 5, Name = " ", Model = " ", Odometer = 5600, Year = 2007 };
    Log.Information($"End program");
}
catch (Exception ex)
{
    Log.Error(ex, "Something go wrong");
}
finally
{
    Log.CloseAndFlush();
}