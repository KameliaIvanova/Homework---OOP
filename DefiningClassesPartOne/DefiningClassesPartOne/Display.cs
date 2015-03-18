namespace DefiningClassesPartOne
{
    using System;

    public class Display
    {
        private double? displaySize;
        private long numberOfColours;

        public Display(double? displaySize, long numberOfColours)
        {
            this.Size = displaySize;
            this.numberOfColours = Colours;
        }

        public double? Size
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                this.displaySize = value;
            }
        }

        public long Colours
        {
            get
            {
                return this.numberOfColours;
            }
            set
            {
                this.numberOfColours = value;
            }
        }
    }
}
