namespace Domain.Models;

public class Address(string addressLine, string city, int zipCode)
{
    public string AddressLine { get; set; } = addressLine;
    public string City { get; set; } = city;
    public int ZipCode { get; set; } = zipCode;
}
