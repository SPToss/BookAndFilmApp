using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public sealed class FilmDto : DataItemBase
    {
        public string Name
        {
            set
            {
                Name = SetValue(value); 
            }
            get
            {
                return Name;
            }
        }

        protected override bool IsDirty()
        {
            return Status == Status.Dirty;
        }
    }
}
