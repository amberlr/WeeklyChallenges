using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c); //all I had to do to pass isaletter and isnotaletter
                                     //char.IsLetter(); is a method I can use to inidicate whether the letter is actually a letter
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers is null || numbers.Count() == 0) //should always do null check first. you can do is or ==
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();

            //IEnumerable means it is a collection
            //Could be an array or a list
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length; //we can do the two below instead
            //var list = new List<int> { str1.Length, str2.Length };
            //return list.Min();
        }

        public int Sum(int[] numbers)
        {
            //int sum = numbers.Sum();
            if(numbers == null) //null did not work with the line above it.. why?
            {
                return 0;
            }
            return numbers.Sum(); //did this instead of using sum which i initialized at the top
            
            ////if you don't want to use linq - try below foreach
            //int sum = 0;
            //foreach(var num in numbers) 
            //{
            //    sum += sum;
            //}
            //return sum;

            ////if you want to do for loop
            //for(int i = 0; i < numbers.Length; i++) 
            //{
            //    sum += numbers[i];
            //}
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) //so my issue was that I had this portion in the for loop.. and I also had to put this up top
            {
                return 0;
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum = sum + numbers[i];
                }
            } return sum;

            ////if you want to do linq.. include below with nullcheck
            //return numbers.Where(num => num % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Sum() % 2 != 0) //can do number.Sum here instead of making a variable int sum = numbers.Sum();
            {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //if(number < 0) 
            //{
            //    return 0;
            //}
            //return number / 2;

            return number < 0 ? 0 : number / 2;
        }
    }
}
