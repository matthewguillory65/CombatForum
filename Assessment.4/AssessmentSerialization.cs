﻿using System.IO;
using System.Xml.Serialization;

namespace Assessment._4
{
    class AssessmentSerialization<T>
    {
        
            public static string folderName = @"Save\";
            public static void Serialize(string filename, T data)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                Directory.CreateDirectory(folderName);
                TextWriter writer = new StreamWriter(folderName + filename + ".xml");
                serializer.Serialize(writer, data);
                writer.Close();
            }

            
            public static T Deserialize(string fileName)
            {
                T data;
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextReader reader = new StreamReader(folderName + fileName + ".xml");
                data = (T)serializer.Deserialize(reader);
                reader.Close();
                return data;
            }
        }
}
