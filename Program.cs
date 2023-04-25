using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Dict dict = new Dict();
            dict.AddWord();
            dict.AddWord();
            dict.AddWord();
            SerialiseDict(dict);
        }

        static void SerialiseDict(Dict dict)
        {
            FileStream file = new FileStream("X.xml", FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Dictionary<string, List<string>>));
            xmlSerializer.Serialize(file, dict.Translations);
            file.Close();
            Console.WriteLine("Serialized successfully!!!");
        }
    }
}
