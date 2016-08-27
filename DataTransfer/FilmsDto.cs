using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataTransfer
{
    [XmlRoot("Films")]
    public class FilmsDto
    {
        [XmlArray("FilmSerie")]
        public List<FilmSeriesDto> FilmSeries { get; set; }
    }
}
