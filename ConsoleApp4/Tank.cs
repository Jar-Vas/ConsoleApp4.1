using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Tank
    {
        private decimal volume;
        private string material;
        private bool isFull;

        public Tank (decimal volume)
        {
            this.volume = volume;
        }
        public Tank(decimal volume, string material)
        {
            this.volume = volume;
            this.material = material;
        }
        public Tank(decimal volume, string material, bool isFull)
        {
            this.volume = volume;
            this.material = material;
            this.isFull = isFull;
        }

        public decimal Volume
        {
            get { return volume; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Volume cannot be negative");
                volume = value;
            }
        }
        public string Material
        {
            get { return material; }
            set { this.material = value; }
        }
        public bool IsFull
        {
            get { return isFull; }
            set { this.isFull = value; }
        }

        public void SetFull(bool isFull) { this.isFull = isFull; } // dont need exeption 

    }
}
