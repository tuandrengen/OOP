using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Abstract methods resides in abstract classes and has no implementation
    // Abstract methods MUST be overridden in non-abstract child classes.
    abstract class ParkingMeter // Abstract class
    {
        public int money { get; set; }
        public bool weekend { get; set; }
        public int minutesParked { get; set; }

        public int InsertCoin(int money, bool weekend, int minutesParked)
        {
            if (weekend)
            {
                WeekendParkingRate ParkingRateWeekend = new WeekendParkingRate();
                return ParkingRateWeekend.calculateParkingRate(minutesParked);
            }
            else
            {
                WeekdaysParkingRate ParkingRateWeekday = new WeekdaysParkingRate();
                return ParkingRateWeekday.calculateParkingRate(minutesParked);
            }
        }
        public abstract int calculateParkingRate(int timeParked); // Abstract method
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
    class WeekendParkingRate : ParkingMeter // Inherited from an abstract class
    {
        public override int calculateParkingRate(int timeParked) // Abstract method - Added implementation
        {
            return 2 * timeParked;
        }
    }
    class WeekdaysParkingRate : ParkingMeter // Inherited from an abstract class
    {
        public override int calculateParkingRate(int timeParked) // Abstract method - Added implementation
        {
            return 1 * timeParked;
        }
    }
}
