using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HW13.CRUD
{
    sealed class MotorcycleNotFoundException : Exception
    {
        public MotorcycleNotFoundException()
        {

        }
        public MotorcycleNotFoundException(string? message)
            : base(message)
        {

        }
        protected MotorcycleNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}