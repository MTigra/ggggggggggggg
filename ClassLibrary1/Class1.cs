using System;
namespace ClassLibrary1
{
    public class Circuit
    {
        private double R;//activ resist
        private double L;//induct
        private double C;// emkost

        public double W { get; set; }

        public double ReactiveRes
        {
            get
            {
                return W * L - 1.0 / (W * C);
            }
        }
        //Full Resistance
        public double Z
        {
            get { return Math.Sqrt(R * R + (ReactiveRes * ReactiveRes)); }
        }

        public override string ToString()
        {
            return string.Format(this.C + " " + this.L + " " + this.R);
        }
    }
}