using System.Xml.Serialization;

namespace RetailApp.Utility
{
    public static class XmlUtility
    {
        public static T XmlToClass<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(new StringReader(xml));
        }
    }
}