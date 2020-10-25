using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        public string MusicFormat { get; set; }
        int Capacity = 700;
        static string DiscType = "CD";
        int Rpm = 2000;

        public CD(string musicFormat, string name, string contents) : base(name, contents)
        {
            MusicFormat = musicFormat;
        }
        
        public void spinDisc()
        {
            Console.WriteLine("The " + DiscType + " spins at a rate of " + Rpm + " rpm.");
        }

        public void insertDisc()
        {
            Console.WriteLine("The " + DiscType + " is inserted into the CD drive.");
        }

        public void ejectDisc()
        {
            Console.WriteLine("The " + DiscType + " is ejected from the CD drive.");
        }

        public void storeData()
        {
            Console.WriteLine(Name + " " + DiscType + " stores " + MusicFormat + " files.");
        }

        public void writeData()
        {
            Console.WriteLine("Laser writes " + Capacity + " megabytes of data to the " + DiscType + ".");
        }

        public void readData()
        {
            Console.WriteLine("Laser reads the " + DiscType + ".");
        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
