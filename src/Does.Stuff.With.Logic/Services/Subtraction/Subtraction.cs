using System;
using System.Collections.Generic;
using System.Text;

namespace Does.Stuff.With.Logic.Services
{
    public class Subtraction : ISubtraction
    {
        public double SubtractTwoNumbers(double numberOne, double numberTwo)
        {
            return numberOne - numberTwo;
        }
    }
}
