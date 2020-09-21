using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args, int weight)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Int32.Parse(Console.ReadLine());
            
            
            if(age <= 20)
            {
                Console.WriteLine("You are too young to use the calculator");
            }else if(age >= 60)
            {
                Console.WriteLine("you are too old to use the calculator");
            }
            else
            {
                double height;
                Console.WriteLine("Enter your height:");
                height = double.Parse(Console.ReadLine());
                Console.WriteLine($"your height is {height} meters.");

            }
            {
                Console.WriteLine("What is your is weight?");
                double weight = Console.ReadLine();




            }else if (weight >= 19) 
            {
                Console.ReadLine("Underweight");


            }
            else if (weight >= 25)
            {
                Console.ReadLine("")
            }


            
            

            


        }
    }
}
