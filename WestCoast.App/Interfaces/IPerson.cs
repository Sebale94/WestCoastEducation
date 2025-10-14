using Domain.Models;
namespace WestCoast.App.Interfaces;

public interface ICreatPerson
{
    void AddPerson(Person person);
    IList<Person> FetchPersons();
    
}
