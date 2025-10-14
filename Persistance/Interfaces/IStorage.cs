
namespace Persistance.Interfaces;

public interface IStorage
{
    void WriteJson(string path, string data);
    string Read(string path);
}
