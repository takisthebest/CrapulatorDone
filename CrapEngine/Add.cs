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
}
