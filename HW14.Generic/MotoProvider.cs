using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14.Generic
{
    static class MotoProvider
    {
       public static List<Moto> Motorcycles;
        static MotoProvider()
        {
           Log.Information($"MotorcycleRepositoryProvider constructor");
           Motorcycles = new List<Moto>();
        }
    }
}
