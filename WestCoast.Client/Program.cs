using Domain.Models;
using WestCoast.App.InterfaceService;
using Persistance.Storages;
namespace WestCoast.Client;

class Program
{
    static void Main()
    {

         CourseService courseService =
            new($"{Environment.CurrentDirectory}/Data/CourseInfo.json");


        var person = new Student()
        {
            FirstName = "Sebastian",
            LastName = "Aleryd",
            PersonNummer = "1994-10-21",
            PhoneNumber = "07399666787",

            Address = new Address
            {
                AddressLine = "Stora Herrestad",
                City = "Ystad",
                ZipCode = 27155
            }
        };
        Console.WriteLine("Lista över studeranade\n");

        foreach (var p in new List<Person> { person })
        {
            Console.WriteLine(person);
        }

    
        var person1 = new Teacher ()
        {
            FirstName = "Olga",
            LastName = "Jönsson",
            PersonNummer = "1967-10-01",
            PhoneNumber = "07399666787",
            Responsible = "Matte",
            Knowledge = "Matte,idrott",
                
                Address = new Address
                {
                    AddressLine = "Stora Herrestad",
                    City = "Ystad",
                    ZipCode = 27155
                }
        };

        var person2 = new Admin()
        {
            FirstName = "Nisse",
            LastName = "Erlandsson",
            PersonNummer = "1956-10-01",
            PhoneNumber = "0739532935",
            Responsible = "Träsöjd",
            Knowledge = "Idrott,Träslöjd",
            HireDate = new DateTime(2025, 10, 1),

                Address = new Address
                {
                    AddressLine = "Stora Herrestad",
                    City = "Ystad",
                    ZipCode = 27155
                }
        };

        var person3 = new Leader()
        {
            FirstName = "Kalle",
            LastName = "Andersson",
            PersonNummer = "1934-01-01",
            PhoneNumber = "0132103201",
            Responsible = "Syslöjd",
            Knowledge = "Svenska,Syslöjd",
            HireDate = new DateTime(1994, 01, 01),

                Address = new Address
                {
                    AddressLine = "Stora Herrestad",
                    City = "Ystad",
                    ZipCode = 27155
                }
        };



        var course = new Course()
        {
            Titel = "C#",
            Classroom = true,
            StartDate = new DateTime(2024, 10, 01),
            EndDate = new DateTime(2025, 06, 01),
            Lenght = "9 Månader"


        };
        
        Console.WriteLine("Lista över Kurser\n");

        foreach (var c in new List<Course> { course })
        {
            Console.WriteLine(course);
        }

        
        courseService.SaveCourses(course);
        

        
    }
}
