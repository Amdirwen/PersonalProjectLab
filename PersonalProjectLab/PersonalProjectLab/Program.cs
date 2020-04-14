using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {

            //Introduction
            Console.WriteLine("This program is to help you calculate deflection and maximum shear stress and moments of a centrally located load on a simply supported, rectangular beam in US customary units.");
            Console.WriteLine(); //blank for readability

            //create loop to run continuously if user wants to continue
            bool shouldContinue = true;
            
            while (shouldContinue)
            {
                //define variables
                decimal modulus;
                int height;
                int width;
                int load;
                decimal inertia;
                int length;
                decimal deflection;
                deflection = 0;
                decimal shear;
                shear = 0;
                decimal moment;
                moment = 0;
                int material;
                string input = "";

                //get dimensions

                Console.WriteLine(); //blank for readability
                Console.WriteLine("First, let's specifiy the dimensions of the beam.");
                Console.WriteLine(); //blank for readability
                Console.WriteLine("How long is the beam in inches?");
                input = Console.ReadLine();
                length = int.Parse(input);

                Console.WriteLine("What is the height of the beam in inches?");
                input = Console.ReadLine();
                height = int.Parse(input);

                Console.WriteLine("What is the width of the base of the beam in inches?");
                input = Console.ReadLine();
                width = int.Parse(input);

                Console.WriteLine("What is the beam made out of? If its wood, type 1. If its steel, type 2.");
                input = Console.ReadLine();
                material = int.Parse(input);


                if (material == 1)
                {
                    modulus = (decimal)(1.8 * Math.Pow(10, 6));
                }

                else
                {
                    modulus = (decimal)(26 * Math.Pow(10, 6));
                }

                Console.WriteLine("What is the weight of the load placed on the middle of the beam in lbs?");
                input = Console.ReadLine();
                load = int.Parse(input);

                //calculate moment of inertia

                Calculations calculations = new Calculations();

                inertia = calculations.CalculateInertia(width, height);
                deflection = calculations.CalculateDeflection(load, length, modulus, inertia);
                shear = calculations.CalculateShear(load);
                moment = calculations.CalculateMoment(load, length);

                Console.WriteLine(); //blank for readability
                Console.WriteLine("The deflection will be " + deflection + " inches. Note that this is only for the load, it does not include the deflection from the weight of the beam.");
                Console.WriteLine("The maximum shear stress in the beam will be " + shear + " lbs.");
                Console.WriteLine("The maximum moment in the beam will be " + moment + " in-lbs.");
                Console.WriteLine(); //blank for readability


                //loop code
                Console.WriteLine("Would you like to continue?");
                Console.WriteLine("Press 1 to run another calculation. Press 2 to quit.");
                string wantContinue = Console.ReadLine();

                if (wantContinue == "2")
                {
                    shouldContinue = false;
                }
            }
            Console.WriteLine(); //blank for readability
            Console.WriteLine("Have a nice day!");
        }

    }
}