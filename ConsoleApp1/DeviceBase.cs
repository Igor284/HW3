namespace ConsoleApp1
{
    internal class DeviceBase
    {
        /// <summary>
        ///  Gets or sets Хеллоу американці.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  Gets or sets Хеллоу американці.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  Gets or sets Хеллоу американці.
        /// </summary>
        /// <returns>int Name. </returns>
        public int CompareTo(object o)
        {
            Device p = o as Device;
            if (p != null)
                return Name.CompareTo(p.Name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

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
    }
}