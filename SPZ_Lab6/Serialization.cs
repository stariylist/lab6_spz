using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace SPZ_Lab6.Model
{
    class Serialization
    {
       static string path = "MyHotel.json";//путь
       static public void Serialize()//метод сериализации
        {
            var json = new DataContractJsonSerializer(typeof(List<Room>));
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                json.WriteObject(file, Hotel.Rooms);
            }
        }
    }
}
