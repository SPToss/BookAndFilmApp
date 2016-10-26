using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataTransfer
{
    public class FilmSeriesDto
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Category")]
        public string Category { get; set; }
        [XmlArray("Films"), XmlArrayItem("Film")]
        public List<FilmDto> Films { get; set; }


    }
}
