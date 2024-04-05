using System.Security.Cryptography.X509Certificates;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "dog";
            int dogAge = 10;
            char dogChar = 'd';
            bool isDog = true;
            double ageInDays = 3658;
            decimal ageInMinutes = 5267520.992762M;
            Console.WriteLine($"Dog name is {dogName}, his Age in years is: {dogAge}");
            Console.WriteLine($"His Age in Days is {ageInDays}, his Age in minutes is: {ageInMinutes} and First char of his name is {dogChar}");
            Console.WriteLine($"My Pet is: " + (isDog ? "dog" : "cat"));
        }
    }
}
