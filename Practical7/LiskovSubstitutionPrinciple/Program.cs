using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            MotorCycle motorCycle = new MotorCycle();

            DriveVehicle(car);
            DriveVehicle(motorCycle);
        }
        public static void DriveVehicle(Vehicle vehicle)
        {
            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();
        }
    }

    public abstract class Vehicle
    {
        public abstract void Start();
        public abstract void Drive();
        public abstract void Stop();

    }

    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving the Car...");
        }

        public override void Start()
        {
            Console.WriteLine("Starting the Car...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stoping the Car...");
        }
    }

    public class MotorCycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving the MotorCycle...");
        }

        public override void Start()
        {
            Console.WriteLine("Starting the MotorCycle...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stoping the MotorCycle...");
        }
    }

    
}
