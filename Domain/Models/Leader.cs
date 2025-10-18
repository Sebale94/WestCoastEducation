namespace Domain.Models;

public class Leader:Teacher
{
    public DateTime HireDate { get; set; }

    public Leader(string firstName, string lastName, string phoneNumber, string personNummer, string knowledge, string responsible, DateTime hireDate)
    : base(firstName, lastName, phoneNumber, personNummer, knowledge, responsible)
    {
        HireDate = hireDate;
    }
    public Leader()
    {
    }

    public override string ToString()
    {
        return $"Anställningsdatum: {HireDate.ToShortDateString()}\n";
    }
    
}
