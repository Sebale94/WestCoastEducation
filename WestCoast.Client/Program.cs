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




        List<Student> students = new()
        {
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
                    ZipCode = 27155
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
                    ZipCode = 11122
                }
            }
        };
        
        Console.WriteLine("Lista över Studenter\n");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
       
        

    
        Teacher teacher = new Teacher ()
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
                 ZipCode = 27155
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
                    ZipCode = 27155
                }
        };



        List<Course> courses = new()
        {
            new Course
            {
                Titel = "Programmering 1",
                Classroom = true,
                StartDate = new DateTime(2024, 09, 01),
                EndDate = new DateTime(2025, 01, 15),
                Lenght = "20 veckor"
            },
            new Course
            {
                Titel = "Webbutveckling 1",
                Classroom = false,
                StartDate = new DateTime(2024, 09, 01),
                EndDate = new DateTime(2025, 01, 15),
                Lenght = "20 veckor"
            },

        };
        
        Console.WriteLine("Lista över Kurser\n");
        foreach (var course in courses)
        {
            Console.WriteLine(course);
        }



        courseService.SaveCourses(courses[0]);
        

        
    }
}
