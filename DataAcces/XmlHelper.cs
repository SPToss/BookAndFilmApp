using System.Xml.Linq;
using System.Xml.Serialization;

namespace DataAcces
{
    public static class XmlHelper
    {
        public static T Deserialize<T> (XElement element)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(element.CreateReader());
        }
    }
}
