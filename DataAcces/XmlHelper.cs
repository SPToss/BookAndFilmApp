using System.Xml;
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
        public static XElement SerializeToXElement(object o)
        {
            var doc = new XDocument();
            using (XmlWriter writer = doc.CreateWriter())
            {
                XmlSerializer serializer = new XmlSerializer(o.GetType());
                serializer.Serialize(writer, o);
            }
            return doc.Root;
        }
    }

}
