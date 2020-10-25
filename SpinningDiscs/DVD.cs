using System;
namespace SpinningDiscs
{
    public class DVD: BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        public string VideoFormat { get; set; }
        int Rpm = 7000;
        int Capacity = 4;
        string DiscType = "DVD";
        public DVD(string videoFormat, string name, string contents) : base(name, contents)
        {
            VideoFormat = videoFormat;
        }

        public void spinDisc()
        {
            Console.WriteLine("The " + DiscType + " spins at a rate of " + Rpm + " rpm.");
        }

        public void insertDisc()
        {
            Console.WriteLine("The " + DiscType + " is inserted into the DVD player.");
        }

        public void ejectDisc()
        {
            Console.WriteLine("The " + DiscType + " is ejected from the DVD player.");
        }

        public void storeData()
        {
            Console.WriteLine(Name + " " + DiscType + " stores " + VideoFormat + " files.");
        }

        public void writeData()
        {
            Console.WriteLine("Laser writes " + Capacity + " gigabytes of data to the " + DiscType + ".");
        }

        public void readData()
        {
            Console.WriteLine("Laser reads the " + DiscType + ".");
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
