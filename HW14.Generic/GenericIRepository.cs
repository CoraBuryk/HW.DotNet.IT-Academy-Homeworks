using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW14.Generic
{
    interface IRepository<T>
    {
        public void Add(T motorcycle);
        public List<Moto> GetAll();
        public T GetById(int id);
        public void Delete(int id);
        public void Update(T motorcycle);
    }
}
