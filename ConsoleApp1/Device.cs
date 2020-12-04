namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Device : IComparable
    {
        /// <summary>
        ///  Gets or sets Хеллоу американці.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  Gets or sets Хеллоу американці.
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        ///  Gets or sets Хеллоу американці.
        /// </summary>
        public double Prise { get; set; }

        /// <summary>
        ///  Gets or sets Хеллоу американці.
        /// </summary>
        /// <returns></returns>


        public int CompareTo(object o)
        {
            Device p = o as Device;
            if (p != null)
                return Name.CompareTo(p.Name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

        public String ToString()
        {
            return "Name: " + this.Name + " Weight: " + this.Weight + " Price: " + this.Prise;
        }

    }
}



