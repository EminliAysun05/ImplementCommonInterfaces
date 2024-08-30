namespace Implement_common_interfaces;

public class Car : IComparable<Car>, ICloneable, IEquatable<Car>
{
    public string Name { get; set; } = null!;
    public int MaxMph { get; set; }
    public int Horsepower { get; set; }
    public decimal Price { get; set; }

   
    public object Clone()
    {
        return new Car
        {
            Name = Name,
            MaxMph = MaxMph,
            Horsepower = Horsepower,
            Price = Price
        };
    }

    public int CompareTo(Car? other)
    {
       if(other is null) throw new Exception("Is null");//NullReference exceptionda atmaq olar
       return Price.CompareTo(other.Price);
    }

    public bool Equals(Car? other)
    {
       if(other != null) return false;
       return Name == other?.Name &&
             MaxMph == other.MaxMph &&
           Horsepower == other.Horsepower &&
           Price == other.Price;
    }
    public override string ToString()
    {
        return $"Name-{Name}, MaxMph-{MaxMph}, HorsePower-{Horsepower}, Price - {Price}";
    }

}
