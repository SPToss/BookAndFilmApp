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
        protected string filePath;
        protected BaseService(string file) : this(new T(),file)
        {
            filePath = file;
            LoadData();       
        }

        public BaseService(T item, string file)
        {
            Item = item;
            filePath = file;
        }

        public abstract void LoadData();

        public abstract void SaveData();

        public bool IsDirty()
        {
            return Item.IsDirty();
        }

        public int GetAllItemsCount()
        {
            return Item.CountAllElements();
        }
    }
}
