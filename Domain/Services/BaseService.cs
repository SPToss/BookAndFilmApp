using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Objects;
using Domain.Objects.Abstracts;

namespace Domain.Services
{
    public abstract class BaseService<T>  where T : IDataObject, new()
    {
        protected T Item;

        protected BaseService() : this(new T()) { }

        public BaseService(T item)
        {
            Item = item;
        }

        public abstract void LoadData();

        public bool IsDirty()
        {
            return Item.IsDirty();
        }
    }
}
