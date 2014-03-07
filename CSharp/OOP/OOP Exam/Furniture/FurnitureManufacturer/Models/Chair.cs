﻿namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }
            private set
            {
                if (value <= 0)
                {
                    base.LessOrEqualToZeroException(this.NumberOfLegs.GetType().Name);
                }

                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            string baseValue =  base.ToString();
            return string.Format("{0}Legs: {1}",
                                   baseValue,
                                   this.numberOfLegs);
        }
    }
}
