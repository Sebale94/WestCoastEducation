using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Address
{
    public string AddressLine { get; set; } = "";
    public string City { get; set; } = "";
    public int ZipCode { get; set; }
    public string Email { get; set; } = "";
    public Address(string addressLine, string city, int zipCode,string email)
    {
        AddressLine = addressLine;
        City = city;
        ZipCode = zipCode;
        Email = email;
    }

    public Address()
    {
    }

    public override string ToString()
    {
        return $"Adress: {AddressLine}\n" +
        $"Postnummer: {ZipCode}\n" +
        $"Stad: {City}\n" +
        $"E-post: {Email}";
    }
}
