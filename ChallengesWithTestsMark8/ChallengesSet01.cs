using System;
using System.Collections.Generic;
using System.Globalization;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return (number1 < number2) ? number1 : number2;
            //or you can just do if else:

            //if(number1 < number2)
            //{
            //    return number1;
            //}
            //else
            //{
            //    return number2;
            //}
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson != "")  //this will apply to all the names they have listed in the unit tests
                                     //think of nameOfPerson as something they are able to change
                                     //you don't need to create those specific name values
            {
                return $"Hello, {nameOfPerson}!";
            }
            else
            {
                return $"Hello!"; //this will apply to the empty string ""
            }

            //you could do ternary as well:
            //return (nameOfPerson != "") ? $"Hello, {nameOfPerson}!" : $"Hello!";
        }

        public string GetHey()
        {
            return "HEY!";  //I was confused here because I didn't know what they expected to see
                            //I went to Solution Explorer and double clicked ChallengesSet01Tests.cs
                            //which pulled up all the unit test source code
                            //This told me they expected to see "HEY!"
        }
    }
}
