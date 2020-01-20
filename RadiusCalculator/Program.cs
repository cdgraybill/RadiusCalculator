using System;

namespace RadiusCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string askQuestion = "Let's find the area of a circle. What's the radius?";
            TalkToUser(askQuestion);
            double userInput = double.Parse(Console.ReadLine());

            userInput = FindArea(userInput);
            Console.WriteLine($"The area of the circle is {userInput}. Press any key.");
            Console.ReadLine();

            askQuestion = "Let's calculate a circumference. Enter a radius.";
            TalkToUser(askQuestion);
            double circumference = double.Parse(Console.ReadLine());

            circumference = FindArea(circumference);
            Console.WriteLine($"The circumference of the circle is {circumference}.");
            Console.ReadLine();
        }

        public static double FindArea(double radius)
        {
            double answer = Math.PI * Math.Pow(radius, 2);
            return answer; 
        }

        public static double FindCircumference(double radius)
        {
            double answer = 2 * Math.PI * radius;
            return answer;
        }

        public static void TalkToUser(string dialouge)
        {
            Console.WriteLine(dialouge);
        }
    }
}
