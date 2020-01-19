using System;

namespace RadiusCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string askForRadius = "Let's find the area of a circle. What's the radius?";
            TalkToUser(askForRadius);
            double area = double.Parse(Console.ReadLine());

            area = FindArea(area);
            Console.WriteLine($"The area of the circle is {area}.");
        }

        public static double FindArea(double radius)
        {
            double answer = Math.PI * (radius * radius);
            return answer; 
        }

        public static void TalkToUser(string dialouge)
        {
            Console.WriteLine(dialouge);
        }
    }
}
