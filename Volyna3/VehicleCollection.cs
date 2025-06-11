using System;
using System.Collections.Generic;
using System.Linq;

namespace Volyna3
{
    internal class VehicleCollection
    {
        private Queue<Vehicle> vehicleQueue = new Queue<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicleQueue.Enqueue(vehicle);
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            return vehicleQueue;
        }

        public void CloneSelected(int selectedIndex)
        {
            if (selectedIndex < 0 || selectedIndex >= vehicleQueue.Count)
                return;

            var list = vehicleQueue.ToList();
            var selectedVehicle = list[selectedIndex];
            var cloned = (Vehicle)((ICloneable)selectedVehicle).Clone();

            vehicleQueue.Enqueue(cloned);
        }

        public void SortQueueByPrice()
        {
            var sorted = vehicleQueue.OrderBy(v => v["Price"] is double d ? d : 0).ToList();

            vehicleQueue.Clear();
            foreach (var v in sorted)
            {
                vehicleQueue.Enqueue(v);
            }
        }
    }
}
