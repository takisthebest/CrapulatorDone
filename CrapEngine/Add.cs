using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapEngine
{
    public class Add
    {
        //create a method that takes two numbers and returns the sum
        public int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            //creating a result to hold our sum
            int result = 0;
            //adds both numbers and stuffs the answer into our result
            result = firstNumber + secondNumber;
            //finally return the result
            return result;

        }

    }

    public class Mult
    {
        //mutliply the first number by the second number 
        public int MultTwoNumbers(int firstNumber, int secondNumber)
        {
            int result = 0;
            //we only need to change the math symbole in this part
            result = firstNumber * secondNumber;
            return result;

        }

    }

    public class From
    {
        // using the same structure as above, take the first number from the second number
        public int FromTwoNumbers(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber - secondNumber;
            return result;
        }
    }

    public class Into
    {
        // split the first number into groups of the second number (divide)
        public int IntoTwoNumbers(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber / secondNumber;
            return result;
        }
    }
}
