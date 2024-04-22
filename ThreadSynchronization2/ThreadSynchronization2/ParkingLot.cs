using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSynchronization2
{
    public class ParkingLot
    {
        private int capacity;
        private List<Car> carsInLot = new List<Car>();

        public ParkingLot(int capacity)
        {
            this.capacity = capacity;
        }

        public bool TryEnter(Car car)
        {
            lock (carsInLot)
            {
                if (carsInLot.Count < capacity)
                {
                    carsInLot.Add(car);
                    car.EnterParkingLot();
                    return true;
                }
                    return false;
            }
        }

        public void Exit(Car car)
        {
            lock (carsInLot)
            {
                carsInLot.Remove(car);
                car.ExitParkingLot();
                Monitor.PulseAll(carsInLot);
            }
        }
    }
}
