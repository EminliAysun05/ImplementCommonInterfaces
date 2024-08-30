using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_common_interfaces
{
    public class CarComparer : IComparer<Car>
    {
        public enum CompareField
        {
            Name,
            MaxMph,
            HorsePower,
            Price
        }
        public CompareField SortBy { get; set; } = CompareField.Name;
        public int Compare(Car? x, Car? y)
        {
           
            switch (SortBy)
            {
                case CompareField.Name:
                    return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
                case CompareField.MaxMph:
                    return x.MaxMph.CompareTo(y.MaxMph);
                case CompareField.HorsePower:
                    return x.Horsepower.CompareTo(y.Horsepower);
                case CompareField.Price:
                    return x.Price.CompareTo(y.Price);
                default:
                    throw new ArgumentOutOfRangeException(nameof(SortBy), $"Not expected value: {SortBy}");
            }
        }

    }
}
