using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Serilog;

namespace HW14.Generic
{
    class MotorcycleRepository : IRepository<Moto>
    {
        private List<Moto> _rep;

        public MotorcycleRepository()
        {
            Log.Information($"MotoRepository start");
            _rep = MotoProvider.Motorcycles;
        }

        public void Add(Moto motorcycle)
        {
            Log.Information($"CreateMotorcycle: motocycle" + motorcycle.Name + " is created");
            _rep.Add(motorcycle);
        }
        public List<Moto> GetAll()
        {
            Log.Information($"GetAll: ");
            return _rep;
        }
        public Moto GetById(int id)
        {
            Log.Information($"GetMotorcycleById: motorcycle {id}");
            return _rep.Find(x => x.Id == id);
        }
        public void Delete(int id)
        {
            Log.Information($"DeleteMotorcycle: motorcycle {id} is deleted");
            _rep.Remove(_rep.Find(x => x.Id == id));
        }
        public void Update(Moto motorcycle)
        {
            int index = _rep.FindIndex(x => x.Id == motorcycle.Id);
            Log.Information($"UpdateMotorcycle: motorcycle" + motorcycle.Id + " is updated");
            _rep[index] = motorcycle;
        }
        public void Print()
        {
            Log.Information($"PrintAll:");
            int counter = 1;
            Console.WriteLine("Moto");
            foreach (Moto moto in _rep)
            {
                Console.WriteLine($"{counter} {moto}");
                counter++;
            }
        }
    }
}
