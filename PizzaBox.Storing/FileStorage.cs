using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaBox.Storing
{
  public class FileStorage
  {
    //private readonly string _path = @"store.xml";
    //private readonly string _path = @"crusts.xml";

    public void WriteToXml<T>(List<T> data, string test) where T : class
    {
      using (var writer = new StreamWriter(test))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        serializer.Serialize(writer, data);
      }
    }

    public IEnumerable<T> ReadFromXml<T>( string test2) where T : class
    {
      using (var reader = new StreamReader(test2))
      {
        var serializer = new XmlSerializer(typeof(List<T>));

        return serializer.Deserialize(reader) as IEnumerable<T>;
      }
    }
  }
}
