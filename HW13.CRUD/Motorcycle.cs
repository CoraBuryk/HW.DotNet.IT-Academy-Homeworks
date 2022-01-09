using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.CRUD
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }
        public override string ToString()
        {
            Log.Information("Progress of data output to the console");
            return $"ID: {Id}, Name {Name}, Model: {Model}, Year: {Year}, Odometer: {Odometer}";
        }
    }
}