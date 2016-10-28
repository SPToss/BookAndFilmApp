using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects.Abstracts
{
    public abstract class ListBase<T> where T : DataItemBase, new()
    {
        protected T ItemList;

        protected ListBase() : this(new T()) { }

        protected ListBase(T itemList)
        {
            ItemList = itemList;
        }
    }
}
