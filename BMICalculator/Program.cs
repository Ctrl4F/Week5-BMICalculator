using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Int32.Parse(Console.ReadLine());


            if (age <= 20)
            {
                Console.WriteLine("You are too young to use the calculator");
            }
            else if (age >= 60)
            {
                Console.WriteLine("you are too old to use the calculator");
            }
            else
            {
                double height;
                double weight;
                Console.WriteLine("Enter your height:");
                height = double.Parse(Console.ReadLine());
                Console.WriteLine($"your height is {height} meters.");
                Console.WriteLine("How much do you weight?");

                weight = Double.Parse(Console.ReadLine());
                Console.WriteLine($"You weight {weight} kg.");
                double BMI;
                double height2 = height * height;
                BMI = weight / height2;
                Console.WriteLine($"Your BMI is {BMI} (kg/m2).");

                if (BMI < 19)
                {
                    Console.WriteLine("You are Underweight.");
                }
                else if (BMI <= 24.9)
                {
                    Console.WriteLine("You are Normal Weight.");
                }
                else if (BMI <= 29.9)
                {
                    Console.WriteLine("You are Overweight.");
                }
                else if (BMI > 30)
                {
                    Console.WriteLine("You Are Unhealthy");
                }














            }
        }
    }
}
