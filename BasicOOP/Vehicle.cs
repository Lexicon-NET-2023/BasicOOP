using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    internal interface IDrivable
    {
        string Drive(int distance);
    }

    internal interface IStopable
    {
        void Stop();
    }

    internal abstract class AbstractVehicle : IDrivable
    {
        protected bool ProtectedBool;
        public abstract string Turn();

        public virtual string Drive(int distance)
        {
            return $"{this.GetType().Name} drove for {distance}";
        }
    }

    internal class Vehicle : AbstractVehicle
    {
        public string Brand { get; protected set; }

        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public override string Turn()
        {
            ProtectedBool = false;
            return "Turning";
        }
    }

    internal /*sealed*/ class Car  : Vehicle, IStopable 
    {
        public string Model { get; set; }
       
        public Car(string brand, string model) : base(brand) 
        {
            Model = model;
        }

        public /*sealed*/ override string Drive(int distance)
        {
            return $"{base.Drive(distance)} from car";
        }

        public void Stop()
        {
            //Do something!!
        }
    }

    internal class Audi : Car
    {
        public Audi(string model = "A4") : base("Audi", model)
        {
            
        }

        public string AudiSpecialMethod()
        {
            return "From Audi";
        }

        
    }
}
