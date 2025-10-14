namespace Domain.Models;

public class Student(string firstName, string lastName, string phoneNumber, string personNummer) : Person(firstName, lastName, phoneNumber, personNummer)
{
    List<Student> Students = [];
    public override string ToString()
    {
        return $"Förnamn: {FirstName}\n" +
        $"Efternamn: {LastName}\n" +
        $"Telefonnummer: {PhoneNumber}\n" +
        $"Personnummer: {PersonNummer}\n";
    }
}
