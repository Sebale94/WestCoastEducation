namespace Domain.Models;

public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string PersonNummer { get; set; }
    Address? Address { get; set; }

    public Person(string firstName, string lastName, string phoneNumber, string personNummer)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        PersonNummer = personNummer;
    }
}
