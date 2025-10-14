namespace Domain.Models;

public class Address
{
    public string AddressLine { get; set; } = "";
    public string City { get; set; } = "";
    public int ZipCode { get; set; }

    public Address(string addressLine, string city, int zipCode)
    {
        AddressLine = addressLine;
        City = city;
        ZipCode = zipCode;
    }

    public Address()
    {
    }

    public override string ToString()
    {
        return $"{AddressLine}, {ZipCode} {City}";
    }
}
