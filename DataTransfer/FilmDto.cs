using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public class FilmDto
    {
        public string Title { get; set; }
        public string Distribution { get; set; }
        public string ProductionCompany { get; set; }
        public string Type { get; set; }
        public string Genres { get; set; }
        public string ReliseYear { get; set; }
        public FilmStatus Status { get; set; }
        public FilmSoundTrack SoundTrack { get; set; }
     }
}
