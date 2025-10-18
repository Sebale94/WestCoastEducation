using Domain.Models;
using WestCoast.App.InterfaceService;
using Persistance.Storages;
using System.IO.Pipes;
namespace WestCoast.Client;

class Program
{
    static void Main()
    {


        CourseService courseService =
           new($"{Environment.CurrentDirectory}/Data/CourseInfo.json");

        IList<Course> courses =

        [
            new Course
            {
                Titel = "Programmering 1",
                Classroom = true,
                StartDate = new DateTime(2024, 09, 01),
                EndDate = new DateTime(2025, 01, 15),
                Lenght = "20 veckor",
                Teacher = "Olga Jönsson",
                Grade = "VG"
            },

            new Course
            {
                Titel = "Webbutveckling 1",
                Classroom = false,
                StartDate = new DateTime(2024, 09, 01),
                EndDate = new DateTime(2025, 01, 15),
                Lenght = "20 veckor",
                Teacher = "Olga Jönsson",
                Grade = "G"
            },

        ];

        Console.WriteLine("On-Demand kurser\n");
        
        
        foreach (var c in courses)
        {
            Console.WriteLine(c);
            courseService.SaveCourses(courses);
        }


        List<Student> students =
        [
            new Student
            {
                FirstName = "Sebastian",
                LastName = "Aleryd",
                PersonNummer = "1994-10-21",
                PhoneNumber = "07399666787",
                Address = new Address
                {
                    AddressLine = "Stora Herrestad",
                    City = "Ystad",
                    ZipCode = 27155,
                    Email = "Sebastian.aleryd@gmail.com",
                }
            },
            new Student
            {
                FirstName = "Anna",
                LastName = "Lind",
                PersonNummer = "1996-03-15",
                PhoneNumber = "0701234567",
                Address = new Address
                {
                    AddressLine = "Kungsgatan 12",
                    City = "Stockholm",
                    ZipCode = 11122,
                    Email = "Anna.Lind@gmail.com",
                }
            }
        ];

        Console.WriteLine("Lista över Studenter\n");
        
        
        foreach (var s in students)
        {
            Console.WriteLine(s);
        }
       
        

    
        Teacher teacher = new Teacher ()
        {
            FirstName = "Olga",
            LastName = "Jönsson",
            PersonNummer = "1967-10-01",
            PhoneNumber = "07399666787",
            Responsible = "programmering",
            Knowledge = "Matte,programmering",
            
            Address = new Address
            {
                AddressLine = "Stora Herrestad",
                City = "Ystad",
                ZipCode = 27155,
                Email = "Olga.Jönsson@gmail.com",

            }
        };

        Admin admin = new Admin()
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
                ZipCode = 27155,
                Email = "Nisse.Erlandsson@gmail.com",
            }
        };

        Leader leader = new Leader()
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
                ZipCode = 27155,
                Email = "Kalle.Andersson@gmail.com",
            }
        };



       
        



    }
}
