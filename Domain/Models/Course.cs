namespace Domain.Models;

public class Course
{
    public string Titel { get; set; } = "";
    public bool Classroom { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Lenght { get; set; } = "";
    public string Teacher { get; set; } = "";
    public string Grade { get; set; } = "";
   
    


    public Course(string titel, bool classroom, DateTime startdate, DateTime enddate, string lenght, string teacher, string grade)
    {
        Titel = titel;
        Classroom = classroom;
        StartDate = startdate;
        EndDate = enddate;
        Lenght = lenght;
        Teacher = teacher;
        Grade = grade;
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
        $"Kurs Längd:{Lenght}\n" +
        $"Lärare: {Teacher}\n" +
        $"Kurs betyg: {Grade}\n";
    }


}
