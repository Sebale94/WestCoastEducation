namespace Persistance.Storages;

using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;
using Persistance.Interfaces;

public class FileStorage: IStorage
{
    public static IEnumerable<T> ReadJson<T>(string path)
    {
        throw new NotImplementedException();
    }

    public static void WriteJson<T>(string path, string data)
    {
        File.WriteAllText(path, data);
    }

    public string Read(string path)
    {
        return File.ReadAllText(path);
    }

 

}
