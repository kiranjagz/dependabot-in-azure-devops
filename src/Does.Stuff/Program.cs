using Does.Stuff.With.Logic;
using Does.Stuff.With.Logic.Services;
using System;

namespace Does.Stuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOne = 27.0;
            var numberTwo = 23.0;

            var addition = new Addition();
            var subtraction = new Subtraction();

            var addTwoNumbers = addition.AddTwoNumbers(numberOne, numberTwo);
            var subtractTwoNumbers = subtraction.SubtractTwoNumbers(numberOne, numberTwo);

            var result = new
            {
                subtractTwoNumbers = new
                {
                    numberOneValue = numberOne,
                    numberTwoValue = numberTwo,
                    subtractionResults = subtractTwoNumbers
                },
                addTwoNumbers = new
                {
                    numberOneValue = numberOne,
                    numberTwoValue = numberTwo,
                    additionResults = addTwoNumbers
                },
            };

            Console.WriteLine($"{Newtonsoft.Json.JsonConvert.SerializeObject(result, Newtonsoft.Json.Formatting.Indented)}");

            Console.ReadLine();
        }
    }
}
