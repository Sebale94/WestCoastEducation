namespace Domain.Models;

public class Course
{
    public string Titel { get; set; } = "";
    public bool Classroom { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Lenght { get; set; } = "";
    readonly IList <Course> Courses = [];

    public Course(string titel, bool classroom, DateTime startdate, DateTime enddate, string lenght)
    {
        Titel = titel;
        Classroom = classroom;
        StartDate = startdate;
        EndDate = enddate;
        Lenght = lenght;
    }

    public Course()
    {
    }
    

    public override string ToString()
    {
        return $"Kursnamn: {Titel}\n" +
        $"Klassrum: {Classroom}\n" +
        $"Startdatum: {StartDate}\n" +
        $"Slutdatum: {EndDate}\n" +
        $"Kurs Längd:{Lenght}\n";
    }
}
