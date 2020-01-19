using System;

namespace RadiusCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
        }

        public static void Intro()
        {
            Console.WriteLine("Let't find the area of a circle! All values are in cm.");
            Console.WriteLine("What is the radius of the circle?");
            Console.ReadLine();

        }

        public static double FindArea(double radius)
        {
            double answer = Math.PI * radius;
            return answer; 
        }
    }
}
