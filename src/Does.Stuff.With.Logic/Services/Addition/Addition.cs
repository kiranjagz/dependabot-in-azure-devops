using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Does.Stuff.With.Logic.Services
{
    public class Addition : IAddition
    {
        public double AddTwoNumbers(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
