using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    abstract class ParkingMeter
    {
        public int money;
        public bool weekend;
        public int timeParked;

        public int InsertCoin(int money, bool weekend, int timeParked)
        {
            if (weekend)
            {
                return calculateParkingRate(timeParked);
            }
            else
            {
                return calculateParkingRate(timeParked);
            }
        }
        public abstract int calculateParkingRate(int timeParked);
    }
    class WeekendParkingRate : ParkingMeter
    {
        public override int calculateParkingRate(int timeParked)
        {
            return 2 * timeParked;
        }
    }
    class WeekdaysParkingRate : ParkingMeter
    {
        public override int calculateParkingRate(int timeParked)
        {
            return 1 * timeParked;
        }
    }
}
