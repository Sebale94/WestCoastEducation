using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Admin : Teacher
{
    public DateTime HireDate { get; set; }

    public Admin(string firstName, string lastName, string phoneNumber, string personNummer, string knowledge, string responsible, DateTime hireDate)
    : base(firstName, lastName, phoneNumber, personNummer, knowledge, responsible)
    {
        HireDate = hireDate;
    }
    public Admin()
    {
    }

    public override string ToString()
    {
        return $"Anställningsdatum: {HireDate.ToShortDateString()}\n";
    }
}
