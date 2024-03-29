﻿namespace DefiningClassesPartOne
{
    using System;

    public class Battery
    {
        private const double MIN_HOURS_IDLE = 1;
        private const double MAX_HOURS_IDLE = 2000;
        private const double MIN_HOURS_TALK = 1;
        private const double MAX_HOURS_TALK = 700;

        private double? hoursIdle;
        private double? hoursTalk;

        private string model;
        private BatteryType batteryType;

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (AreHoursValid(value, MAX_HOURS_IDLE, MIN_HOURS_IDLE))
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Hours idle cant be more than {0} and less than {1}", MAX_HOURS_IDLE, MIN_HOURS_IDLE));
                }
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (AreHoursValid(value, MAX_HOURS_TALK, MIN_HOURS_TALK))
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Hours talk cant be more than {0} and less than {1}", MAX_HOURS_TALK, MIN_HOURS_TALK));
                }
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        private bool AreHoursValid(double? hours, double? maxHours, double? minHours)
        {
            if (hours > minHours || hours < minHours)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
