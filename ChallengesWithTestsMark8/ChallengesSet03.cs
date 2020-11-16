using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false) //I didn't have an == to false which was causing it to fail
                {
                    return true;
                }
                //is there a way to do ternary for this if statement?
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null || numbers.Count() == 0) 
            {
                return false;
            }
            //if(numbers.Sum() % 2 != 0) 
            //{
            //    return false;
            //}
            //return numbers.Sum() % 2 == 0;

            return numbers.Sum() % 2 == 0 ? false : true; //can do ternary instead
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //created a bool variable to for upper case, lower case, and digit
            bool containsUpper = password.Any(char.IsUpper);
            bool containsLower = password.Any(char.IsLower);
            bool containsNumber = password.Any(char.IsDigit);

            //if statement that if you want true.. you need to include all of the variables I created above
            if(containsUpper && containsLower && containsNumber) 
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            //do char.Parse so it looks at the character in the string.. 
            //0 would be the starting point (beginning of string)
            //the 1 would be the first character in the string
            return char.Parse(val.Substring(0, 1));
        }

        public char GetLastLetterOfString(string val)
        {
            //did .Length - 1 because I only want the last character of the entirety of the string
            return char.Parse(val.Substring(val.Length - 1));
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0) //had to do this to include divisor being 0
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            //to get odds: number % 2 != 0
            //need to get values below 100 - so number < 100
            //could I do a number / 2 to technically get the odds like I could evens? or do I need to do / 2 + 1 since it doesn't do decimal?
            //50 odd numbers under 100 so technically I can just divide by 2 from 100?

            //is there a way to do this with random numbers in array although the unit test does not require it?
            int[] numbers = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99 };
            foreach(int num in numbers) 
            {
                if (num % 2 != 0) 
                {
                    return numbers;
                }
            }
            return numbers;
            //not sure how to convert this into linq
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++) //easier way to do this?
            {
                words[i] = words[i].ToUpper();
            }
            //did a for loop that would go thru all elements in the string and uppercase them
        }
    }
}
