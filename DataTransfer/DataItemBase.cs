using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public class DataItemBase
    {
        public Status Status { get; private set; }

        protected T SetValue<T>(T t)
        {
            if (Status == Status.Dirty)
            {
                return t;
            }
            Status = Status.Dirty;
            return t;
        }
    }
}
