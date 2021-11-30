using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.CRUD
{
    public interface IMotorcycleRepository
    {
        List<Motorcycle> GetMotorcycles();
        public Motorcycle GetMotorcycleById(int id);
        public void CreateMotorcycle(Motorcycle motorcycle);
        public void DeleteMotorcycle(int id);
        public void UpdateMotorcycle(Motorcycle motorcycle);
    }
}