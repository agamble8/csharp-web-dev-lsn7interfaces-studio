using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        void spinDisc();

        void insertDisc();

        void ejectDisc();

        void storeData();

        void writeData();

        void readData();

    }
}
