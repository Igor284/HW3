using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IelectricProduct
    {
        string Name { get; }
        double Price { get; }
        double Weight { get; }

    }
    public interface IComparer
    {
        int CompareTo(object comfy);
    }


    public abstract class Comfy : IelectricProduct
    {
        private readonly double price;
        private readonly double weight;

        protected Comfy(double price, double weight)
        {
            this.price = price;
            this.weight = weight;
        }

        public abstract string Name { get; }
        public double Price => this.price;
        public double Weight => this.weight;


        public int CompareTo(object comfy)
        {
            var s = comfy as Comfy;
            return s != null ? this.Name.CompareTo(s.Name) : throw new Exception("Hernya");
        }
    }

    public class Appliances
    {
        public Manufacturer[] Manufacturer { get; set; }
    }
    public enum Manufacturer
    {
        Bosch,
        Braun,
        Toshiba,
        Siemens,
        Rowenta,
        Samsung,
        Lg,
        Indesit
    }


    public class ComfyComparer : IComparer
    {
        public int CompareTo(object comfy) { return 0; }

        public int Compare(object first, object second)
        {
            var x = first as Comfy;
            var y = second as Comfy;

            if (x.Name.Length < y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length > y.Name.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }

    class Device : IComparable
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public double Prise { get; set; }
        public int CompareTo(object o)
        {
            Device p = o as Device;
            if (p != null)
                return this.Name.CompareTo(p.Name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

        public String ToString()
        {
            return "Name: " + this.Name + " Weight: " + this.Weight + " Price: " + this.Prise;
        }

    }
    class PeopleComparer : IComparer<Device>
    {
        public int Compare(Device p1, Device p2)
        {
            if (p1.Name.Length > p2.Name.Length)
                return 1;
            else if (p1.Name.Length < p2.Name.Length)
                return -1;
            else
                return 0;
        }



        class Program
        {

            static Device Search(Device[] devices, String name)
            {
                foreach (Device p in devices)
                {
                    if (p.Name.Equals(name))
                        return p;
                }
                return null;
            }

            static void Main(string[] args)
            {

                Device Washer = new Device { Name = "Bill", Weight = 34, Prise = 2500 };
                Device ElectricStove = new Device { Name = "Tom", Weight = 23, Prise = 3000 };
                Device Drill = new Device { Name = "Alice", Weight = 21, Prise = 5000 };

                Device[] devices = new Device[] { Washer, ElectricStove, Drill };
                Array.Sort(devices);



                Console.WriteLine(Search(devices, "Tom").ToString());

            }
        }
    }
}



