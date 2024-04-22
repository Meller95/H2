using ThreadSynchronization2;
using System;
using System.Threading;

namespace ThreadSynchronization2
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot(15); // 15 parkeringsplasser
            for (int i = 0; i < 20; i++) // 20 biler
            {
                Car car = new Car(i);
                int parkTime = 1000 * (i + 1);
                Thread carThread = new Thread(() => car.SimulateCar(parkingLot, parkTime));
                carThread.Start();
            }
        }
    }
}
