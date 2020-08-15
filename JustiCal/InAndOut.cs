using JustiCal.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace JustiCal
{
    namespace Controller
    {
        class InAndOut
        {
            private static ModelClass Model;
            public InAndOut(ModelClass m)
            {
                Model = m;
            }
            public static void In(string filePath)
            {
                if (File.Exists(filePath))
                {
                    Console.WriteLine("Reading saved file");
                    Stream openFileStream = File.OpenRead(filePath);
                    BinaryFormatter deserializer = new BinaryFormatter();
                    Model.Academia = (Academia)deserializer.Deserialize(openFileStream);
                    openFileStream.Close();
                }
            }

            public static void Out()
            {
                Stream SaveFileStream = File.Create("SavedData.bin");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, Model.Academia);
                SaveFileStream.Close();
            }
        } 
    }
}
