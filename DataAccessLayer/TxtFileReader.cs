using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;

namespace Robo_Restaurant.Properties
{
    interface ISerializable<T>
    {
        string path { get; set; }
        T obj { get; set; }
        bool Serialize();
        T Deserialize();
    }
    public class JsonSerialization<T> : ISerializable<T>
    {
        public string path { get; set; }
        public T obj { get; set; }
        DataContractJsonSerializer jsonFormatter;
        public JsonSerialization(string path, T obj)
        {
            this.path = path;
            this.obj = obj;

            jsonFormatter = new DataContractJsonSerializer(typeof(T));
        }
        public bool Serialize()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, obj);
                return true;
            }
        }
        public T Deserialize()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                T newObject = (T)jsonFormatter.ReadObject(fs);
                return newObject;
            }
        }
    }
}

    //foreach (var line in lines)
    //{
    //    string[] entries = line.Split(',');

    //    Dish c = null;
    //    int diName = Convert.ToInt32(entries[0]);
    //    Dish.dishName dName = Dish.dishName.Borsch;

    //    if (diName == 1)
    //    {
    //        dName = Dish.dishName.Borsch;
    //    }
    //    if (diName == 2)
    //    {
    //        dName = Dish.dishName.Green_Borsch;
    //    }

    //    int Weigth = Convert.ToInt32(entries[1]);
    //    int timeOfPrep = Convert.ToInt32(entries[2]);

    //    int ingre = Convert.ToInt32(entries[3]);

    //    List<Ingredients> ingr = new List<Ingredients>();
    //    if (ingre == 1)
    //    {
    //        ingr = new List<Ingredients>
    //        {
    //            Basement.IngList[0],
    //            Basement.IngList[1],
    //            Basement.IngList[2],
    //            Basement.IngList[3],
    //            Basement.IngList[4],
    //            Basement.IngList[5]
    //        };
    //    }
    //    else if (ingre == 2)
    //    {
    //        ingr = new List<Ingredients>
    //        {
    //            Basement.IngList[0],
    //            Basement.IngList[1],
    //            Basement.IngList[2],
    //            Basement.IngList[4],
    //            Basement.IngList[5],
    //            Basement.IngList[6]
    //        };
    //    }

    //    int Price = Convert.ToInt32(entries[4]);

    //    try
    //    {
    //        c = new Dish(dName, Weigth, timeOfPrep, ingr, Price);
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex);
    //    }
    //    mm.AddSpec(c);
    //}
    //foreach( var ingdd in mm.dishes)
    //{
    //    Console.WriteLine(ingdd.dName + ingdd.Weight + ingdd.TimeOfPrep + ingdd.Price);
    //}

