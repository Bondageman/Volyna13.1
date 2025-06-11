using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volyna3
{
    public class Plane : Vehicle
    {
        public Plane()
        {
            properties["Price"] = 0.0;
            properties["Speed"] = 0.0;
            properties["Year"] = 0;
            properties["Height"] = 0.0;
            properties["Passengers"] = 0;
        }

        public override string GetInfo()
        {
            return $"Plane: {properties["Price"]}$, Speed: {properties["Speed"]}km/h, Year: {properties["Year"]}, " +
                   $"Height: {properties["Height"]}m, Passengers: {properties["Passengers"]}";
        }

        public override object Clone()
        {
            var clone = new Plane();
            foreach (var kvp in properties)
                clone[kvp.Key] = kvp.Value;
            return clone;
        }

        public override string ToString()
        {
            return GetInfo();
        }


    }
}
