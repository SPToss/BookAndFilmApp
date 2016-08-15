using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public enum Status : byte
    {
        New = 0,
        Saved = 1,
        Dirty = 2,
    }
}
