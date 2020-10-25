using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD myCD = new CD("MP3", "Little Lights", "Kate Rusby songs");
            DVD myDVD = new DVD("VCD", "The Princess Bride", "Princess bride video chapters");
            myCD.ReportInfo();
            myCD.spinDisc();
            myCD.insertDisc();
            myCD.ejectDisc();
            myCD.storeData();
            myCD.writeData();
            myCD.readData();

            myDVD.ReportInfo();
            myDVD.spinDisc();
            myDVD.insertDisc();
            myDVD.ejectDisc();
            myDVD.storeData();
            myDVD.writeData();
            myDVD.readData();

            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
