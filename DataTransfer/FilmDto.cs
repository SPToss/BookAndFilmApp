using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataTransfer
{
    public class FilmDto
    {
        [XmlElement("Title")]
        public string Title { get; set; }
        [XmlElement("Distribution")]
        public string Distribution { get; set; }
        [XmlElement("ProductionCompany")]
        public string ProductionCompany { get; set; }
        [XmlElement("Type")]
        public string Type { get; set; }
        [XmlElement("Genres")]
        public string Genres { get; set; }
        [XmlElement("ReliseYear")]
        public string ReliseYear { get; set; }
        [XmlElement("Status")]
        public FilmStatus Status { get; set; }
        [XmlElement("SoundTrack")]
        public FilmSoundTrack SoundTrack { get; set; }
     }
}
