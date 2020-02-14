using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Plane : Flyable
    {
        public int NumberOfSeats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        private int numberOfStewardesses;

        public int NumberOfStewardesses
        {   
            get { return numberOfStewardesses; }
            set { numberOfStewardesses = value; }
        }

    }
}
