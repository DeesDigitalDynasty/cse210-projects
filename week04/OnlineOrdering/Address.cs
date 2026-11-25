using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // The single source of truth for "are we in the USA?"
    public bool IsInUSA()
    {
        return _country.Trim().ToUpper() == "USA"
            || _country.Trim().ToUpper() == "UNITED STATES";
    }

    // Returns all fields together, one per line, suitable for a shipping label.
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}