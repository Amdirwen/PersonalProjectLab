using System;
namespace PersonalProjectLab
{
    public class Calculations
    {

        public decimal CalculateInertia(int width, int height)
        {
            //Inertia = (width * height^3)/12
            decimal inertia = 0.00m;

            inertia = (decimal)((width * Math.Pow(height, 3)) / 12);
            return inertia;
        }

        public decimal CalculateDeflection(int load, int length, decimal modulus, decimal inertia)
        {
            //Deflection = (Load * Length^3)/(48 * modulus * inertia)
            decimal deflectionFull = 0.00m;
            decimal deflection = 0.00m;
            deflectionFull = ((decimal)(load * Math.Pow(length, 3)) / (48 * modulus * inertia));
            deflection = Math.Round(deflectionFull, 4);

            return deflection;
        }

        public decimal CalculateShear(int load)
        {
            //For a load in the middle of a beam, max shear = load/2
            decimal shear = 0.0m;
            shear = load / 2;

            return shear;
        }

        public decimal CalculateMoment(int load, int length)
        {
            //Maxium moment for a load on the center of a beam is (load * length)/4
            decimal moment = 0.0m;
            moment = (load * length) / 4;
            return moment;
        }
    }
}

