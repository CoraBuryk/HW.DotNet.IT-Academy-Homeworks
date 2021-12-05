using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.CRUD
{
    class MotorcycleRepository : IMotorcycleRepository
    {
        private static List<Motorcycle> _moto = new();

        public List<Motorcycle> Moto
        {
            get => _moto;
            set => _moto = value;
        }

        public MotorcycleRepository(List<Motorcycle> motorcycles)
        {
            Log.Information("CRUD starts");
        }

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            Moto.Add(motorcycle);
            Log.Debug("CreateMotorcycle: motocycle" + motorcycle.Name + " is created");
        }

        public List<Motorcycle> GetMotorcycles()
        {
            Log.Debug("GetMotorcycles: ");
            return Moto;
        }

        public Motorcycle GetMotorcycleById(int idMoto)
        {
            var moto = Moto.Find(x => x.Id == idMoto);
            Log.Debug($"GetMotorcycleById: motorcycle {idMoto}");
            return moto;
        }

        public void DeleteMotorcycle(int id)
        {
            var moto = GetMotorcycleById(id);
            Moto.Remove(moto);
            Log.Debug($"DeleteMotorcycle: motorcycle {id} is deleted");
            
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            int index = Moto.FindIndex(i => i.Id == motorcycle.Id);
            Moto[index].Name = motorcycle.Name;
            Moto[index].Model = motorcycle.Model;
            Moto[index].Odometer = motorcycle.Odometer;
            Moto[index].Year = motorcycle.Year;
            Log.Debug("UpdateMotorcycle: motorcycle" + motorcycle.Id + " is updated");
        }
    }
}