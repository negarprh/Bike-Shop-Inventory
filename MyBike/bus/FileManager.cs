using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Diagnostics.Metrics;

namespace MyBike.bus
{
    public class FileManager
    {
        private static String xmlFilePath = @"../../../data/Bikes.xml";

        public static void WriteToXmlFile(List<Bike> listOfBikes)
        {
            XmlWriter xmlWriter = XmlWriter.Create(xmlFilePath);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bike>));

            xmlSerializer.Serialize(xmlWriter, listOfBikes);

            xmlWriter.Close();
        }

        public static List<Bike>? ReadFromXmlFile()
        {
            List<Bike>? listFromFile = new List<Bike>();

            StreamReader streamReader = new StreamReader(xmlFilePath);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Bike>));

            listFromFile = (List<Bike>)xmlSerializer.Deserialize(streamReader);

            streamReader.Close();

            if (listFromFile != null)
                return listFromFile;
            else return null;

        }

    }
}

