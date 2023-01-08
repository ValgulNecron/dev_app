using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YamlDotNet.Serialization;

namespace restaurantClasse
{
    public static class MonGenerique
    {
        public static void WriteXML<T>(T unObj)
        {
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(T));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Restaurant.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, unObj);
            file.Close();
        }

        public static void WriteXML<T>(T unObj, string nomObjet)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//" + nomObjet + ".xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, unObj);
            file.Close();
        }
        // la meme chose mes en jso
        public static void WriteJSON<T>(T unObj)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Restaurant.json";
            System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(unObj));
        }
        public static void WriteJSON<T>(T unObj, string nomObjet)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//" + nomObjet + ".json";
            System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(unObj));
        }
        // la meme chose en yaml and yanq
        public static void WriteYAML<T>(T unObj)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Restaurant.yaml";
            var serializer = new Serializer();
            using (var writer = new System.IO.StreamWriter(path))
            {
                serializer.Serialize(writer, unObj);
            }
        }
        public static void WriteYAML<T>(T unObj, string nomObjet)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//" + nomObjet + ".yaml";
            var serializer = new Serializer();
            using (var writer = new System.IO.StreamWriter(path))
            {
                serializer.Serialize(writer, unObj);
            }
        }
      
    }
}
