using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects.Abstracts
{
    public abstract class DataItemBase
    {
        protected DataItemBase()
        {
            Status = Status.Clean;
        }

        public Status Status { get; set; }

        protected void SetValue<T>(ref T field, T value)
        {
            if(Status == Status.New)
            {
                field = value;
                return;
            }

            if (EqualityComparer<T>.Default.Equals(field, value)) return;
            if(!EqualityComparer<T>.Default.Equals(field, default(T)))
            {
                Status = Status.Dirty;
            }
            field = value;
        }

        public abstract bool IsDirty();

        public void SetAsNew()
        {
            if(Status != Status.Deleted)
            {
                Status = Status.New;
            }
        }

        public void SetAsDeleted()
        {
            Status = Status.Deleted;
        }

        public void SetAsDirty()
        {
            Status = Status.Dirty;
        }

        public void SetAsSaved()
        {
            Status = Status.Saved;
        }


    }
}
