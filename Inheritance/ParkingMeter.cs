using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Abstract methods resides in abstract classes and has no implementation
    // Abstract methods MUST be overridden in non-abstract child classes.
    abstract class ParkingMeter
    {
        public int money;
        public bool weekend;
        public int timeParked;

        public int InsertCoin(int money, bool weekend, int timeParked)
        {
            if (weekend)
            {
                WeekendParkingRate ParkingRateWeekend = new WeekendParkingRate();
                return ParkingRateWeekend.calculateParkingRate(timeParked);
            }
            else
            {
                WeekdaysParkingRate ParkingRateWeekday = new WeekdaysParkingRate();
                return ParkingRateWeekday.calculateParkingRate(timeParked);
            }
        }
        public abstract int calculateParkingRate(int timeParked);
        public bool IsEnough(int money, int cost)
        {
            if (money >= cost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
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
