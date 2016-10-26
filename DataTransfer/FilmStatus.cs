using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataTransfer
{
    public enum FilmStatus : byte
    {
        [XmlEnum(Name = "Watched")]
        Watched = 0,
        [XmlEnum(Name = "ToWatch")]
        ToWatch = 1,
        [XmlEnum(Name = "Interupted")]
        Interupted = 2,
        [XmlEnum(Name = "OnHold")]
        OnHold = 4,
        [XmlEnum(Name = "Canceled")]
        Canceled = 8
    }
}
