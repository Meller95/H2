using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSynchronization2
{
    public class Car
    {
        public int Id { get; set; }

        public Car(int id)
        {
            Id = id;
        }

        public void EnterParkingLot()
        {
            Console.WriteLine($"Car {Id} entered the parking lot");
        }

        public void ExitParkingLot()
        {
            Console.WriteLine($"Car {Id} exited the parking lot");
        }

        public void SimulateCar(ParkingLot parkingLot, int parkTime)
        {
            while (true)
            {
                lock (parkingLot)
                {
                    while (!parkingLot.TryEnter(this))
                    {
                        Monitor.Wait(parkingLot);
                    }
                }

                Thread.Sleep(parkTime);

                parkingLot.Exit(this);

                Thread.Sleep(parkTime);
            }
        }
    }
}
