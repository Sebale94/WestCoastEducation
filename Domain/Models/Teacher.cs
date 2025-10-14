namespace Domain.Models;

public class Teacher : Person

{
    public string Knowledge { get; set; }
    public string Responsible { get; set; }

    public Teacher()
    {
    }

    public Teacher(string firstName, string lastName, string phoneNumber, string personNummer, string knowledge, string responsible) : 
    base(firstName, lastName, phoneNumber, personNummer)
    {
        Knowledge = knowledge;
        Responsible = responsible;
    }

    public override string ToString()
    {
        return $"{Knowledge}\n" +
        $"{Responsible}\n";
    }
}
