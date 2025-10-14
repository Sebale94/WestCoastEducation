using Domain.Models;
using WestCoast.App.InterfaceService;
using Persistance.Storages;
namespace WestCoast.Client;

class Program
{
    static void Main()
    {
        PersonService services = new();


        services.AddPerson(new Student
        {
            FirstName = "Sebastian",
            LastName = "Aleryd",
            Address = "Ystad",
            PersonNummer = "1994-10-21",
            City = "Ystad",
            PhoneNumber = "07399666787",
            ZipCode = 27156,
        });

        Console.WriteLine("Lista över studeranade\n");

        foreach (var person in services.FetchPersons())
        {
            Console.WriteLine(person);
        }

        services.AddPerson(new Teacher
        {
            FirstName = "Olga",
            LastName = "Jönsson",
            Address = "Svedala",
            PersonNummer = "1967-10-01",
            City = "Svedalagatan 1",
            PhoneNumber = "07399666787",
            ZipCode = 27156,
            Responsible = "Matte",
            Knowledge = "Matte,idrott"
        });

        services.AddPerson(new Admin
        {
            FirstName = "Nisse",
            LastName = "Erlandsson",
            Address = "Götet",
            PersonNummer = "1956-10-01",
            City = "Göteborg",
            PhoneNumber = "0739532935",
            ZipCode = 23523,
            Responsible = "Träsöjd",
            Knowledge = "Idrott,Träslöjd",
            HireDate = new DateTime(2025, 10, 1)
        });

        services.AddPerson(new Leader
        {
            FirstName = "Kalle",
            LastName = "Andersson",
            Address = "Stora Herrestad",
            PersonNummer = "1934-01-01",
            City = "Ystad",
            PhoneNumber = "0132103201",
            ZipCode = 27155,
            Responsible = "Syslöjd",
            Knowledge = "Svenska,Syslöjd",
            HireDate = new DateTime(1994, 01, 01)
        });


        var course = new Course(
            "Matte",
            true,
            new DateTime(2025, 10, 1),
            new DateTime(2026, 10, 1),
            "52 Veckor"
        );



       

        FileStorage.WriteJson<Course>($"{Environment.CurrentDirectory}/Data/CourseInfo.json", [course]);


        
    }
}
