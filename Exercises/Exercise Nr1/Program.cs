using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise_Nr1
{/*Please write console app. 
  * User should be able to input hours and minutes of the analogue clock.
    Program must calculate lesser angle in degrees between hours arrow and minutes arrow
    and provide output in the console window.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your hours from 0 to 12");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your minutes from 0 to 60");
            int minutes = int.Parse(Console.ReadLine());

            double hourDegree = (hours * 30) + (minutes * 30 / 60);
            double minutesDegree = minutes * 6;

            double difference = Math.Abs(hourDegree - minutesDegree);
            if (difference > 180)
            {
                difference = 360 - difference;
            }

            Console.WriteLine("Your angle betweent hours and minutes is: {0}", difference);
        }
    }
}