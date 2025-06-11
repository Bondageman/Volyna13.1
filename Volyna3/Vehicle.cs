using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volyna3
{
    public abstract class Vehicle : ICloneable, IComparable<Vehicle>
    {
        protected Dictionary<string, object> properties = new Dictionary<string, object>();

        public object this[string key]
        {
            get => properties.ContainsKey(key) ? properties[key] : null;
            set => properties[key] = value;
        }

        public abstract string GetInfo();

        public virtual object Clone()
        {
            var copy = (Vehicle)MemberwiseClone();
            copy.properties = new Dictionary<string, object>(this.properties);
            return copy;
        }

        public virtual int CompareTo(Vehicle other)
        {
            // За замовчуванням сортуємо за ціною
            if (this["Price"] is double price1 && other["Price"] is double price2)
                return price1.CompareTo(price2);
            return 0;
        }

        public override string ToString()
        {
            return GetInfo();
        }


    }
}
