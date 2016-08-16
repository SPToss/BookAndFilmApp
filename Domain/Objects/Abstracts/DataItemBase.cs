using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects.Abstracts
{
    public abstract class DataItemBase
    {
        protected Status Status { get; private set; }

        protected T SetValue<T>(T t)
        {
            if (Status == Status.Dirty)
            {
                return t;
            }
            Status = Status.Dirty;
            return t;
        }

        protected abstract bool IsDirty();
    }
}
