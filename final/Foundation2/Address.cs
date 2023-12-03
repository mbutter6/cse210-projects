public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public bool IsInUSA()
    {
        return Country.ToUpper() == "USA";
    }

    public string GetAddressString()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}
