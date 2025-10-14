namespace Domain.Models;

public class Student
{
    public Address Address { get; set; } = new Address();
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string PersonNummer { get; set; } = "";

    public Student() { }

    public Student(string firstName, string lastName, string phoneNumber, string personNummer)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        PersonNummer = personNummer;
    }

    public override string ToString()
    {
        return $"Förnamn: {FirstName}\n" +
        $"Efternamn: {LastName}\n" +
        $"Telefonnummer: {PhoneNumber}\n" +
        $"Personnummer: {PersonNummer}\n" +
        $"Adress: {Address}\n";
    }
}

