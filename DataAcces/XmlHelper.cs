using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using log4net;
using System;

namespace DataAcces
{
    public static class XmlHelper
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(FilmDao));
        public static T Deserialize<T> (XElement element) where T : new()
        {
            T result = new T();
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                result = (T)serializer.Deserialize(element.CreateReader());
            }
            catch(Exception e)
            {
                Log.Error($"Error occured while deserialize {element} to type {typeof(T)} : {e}");
            }
            return result;
        }
        public static XElement SerializeToXElement<T>(T t)
        {
            var doc = new XDocument();
            using (XmlWriter writer = doc.CreateWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, t);
            }
            return doc.Root;
        }
    }

}
