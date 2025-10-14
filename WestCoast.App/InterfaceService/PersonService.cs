using Domain.Models;
using WestCoast.App.Interfaces;

namespace WestCoast.App.InterfaceService;

public class PersonService: ICreatPerson
{
    private readonly Person person;
    private readonly List<Person> _persons = [];

    public void AddPerson(Person person)
    {
        _persons.Add(person);
    }

    public IList<Person> FetchPersons()
    {
        return _persons;
    }
}
