using System.Xml.Serialization;

namespace DataTransfer
{
    public enum  FilmSoundTrack
    {
        [XmlEnum(Name = "Dubbing")]
        Dubbing = 0,
        [XmlEnum(Name = "Lector")]
        Lector = 1,
        [XmlEnum(Name = "Subtitles")]
        Subtitles = 2,
        [XmlEnum(Name = "Oryginal")]
        Oryginal = 4
    }
}
