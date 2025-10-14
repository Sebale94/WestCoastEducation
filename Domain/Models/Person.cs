namespace Domain.Models;

public abstract class Person
{
    protected string FirstName { get; set; }
    protected string LastName { get; set; }
    protected string PhoneNumber { get; set; }
    protected string PersonNummer { get; set; }
    Address? Address { get; set; }

    public Person(string firstName, string lastName, string phoneNumber, string personNummer)
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
        $"Adress: {Address}\n" +
        $"Telefonnummer: {PhoneNumber}\n" +
        $"Personnummer: {PersonNummer}\n";
      
    }
}
