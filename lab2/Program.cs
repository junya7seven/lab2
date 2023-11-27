using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Naming naming = new Naming("Жесткий диск", "WD Blue", 1000, "SATA III 6 Гбит/с");
            HDD hdd = new HDD("Жесткий диск", "WD Blue", 1000, "SATA III 6 Гбит/с", 7200);
            hdd.DisplayInfo();
        }
    }

    public class Naming
    {
        public string Firm { get; set; }
        public string Name { get; set; }
        public int Memory { get; set; }
        private string InterfaceType { get; set; }

        public Naming(string firm, string name, int memory, string interfaceType)
        {
            Firm = firm;
            Name = name;
            Memory = memory;
            InterfaceType = interfaceType;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Firm: {Firm}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Memory: {Memory}gb");
            Console.WriteLine($"Interface: {InterfaceType}");
        }
    }

    public class HDD : Naming
    {
        public int RPM { get; set; }

        public HDD(string firm, string name, int memory, string interfaceType, int rpm)
            : base(firm, name, memory, interfaceType)
        {
            RPM = rpm;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"RPM: {RPM}");
        }
    }
}
