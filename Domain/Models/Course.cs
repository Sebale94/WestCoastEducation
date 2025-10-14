namespace Domain.Models;

public class Course
{
    public string Titel { get; set; }
    public bool Classroom { get; set; }
    public DateTime Startdate { get; set; }
    public DateTime Enddate { get; set; }
    public string Lenght { get; set; }
    List<Course> Courses = [];

    public Course(string titel, bool classroom, DateTime startdate, DateTime enddate, string lenght)
    {
        Titel = titel;
        Classroom = classroom;
        Startdate = startdate;
        Enddate = enddate;
        Lenght = lenght;
    }

    public override string ToString()
    {
        return $"Kursens namn: {Titel}\n" +
        $"Klassrum: {(Classroom ? "Ja" : "Nej")}\n" +
        $"Startdatum: {Startdate.ToShortDateString()}\n" +
        $"Slutdatum: {Enddate.ToShortDateString()}\n" +
        $"Längd: {Lenght}\n";
    }
}
