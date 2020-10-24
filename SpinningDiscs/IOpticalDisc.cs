using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    interface IOpticalDisc
    {
        const Boolean isShiny = true; 
        void spinDisc();

        void insertDisc();

        void ejectDisc();

        void storeData();

        void writeData();

        void readData();

    }
}
