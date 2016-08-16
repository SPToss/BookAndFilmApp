using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public enum FilmStatus : byte
    {
        Watched = 0,
        ToWatch = 1,
        Interupted = 2,
        OnHold = 4,
        Canceled = 8
    }
}
