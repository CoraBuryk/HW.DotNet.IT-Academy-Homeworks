using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14.Generic
{
    internal class Moto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }

        public Moto()
        {

        }

        public Moto(int id, string name, string model, int year, int odometer)
        {
            Log.Information($"MotoRepository start");
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(model))
            {
                throw new Exception("Empty name/model");
            }
            Id = id;
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }
        public override string ToString()
        {
            Log.Information($"Motorcycle.ToString()");
            return ($"ID: {Id}, Name: {Name}, Model: {Model}, Year: {Year},Odometer: {Odometer}");

        }
    }
}