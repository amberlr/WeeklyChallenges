using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //first we have to create these two buckets (variables) to store the evens and odds into
            int evenNum = 0;
            int oddNum = 0;

            //loop through the array with a foreach
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    //we are adding evens in the array so +=
                    //make sure when you are doing this.. the variable on the left is the bucket you are adding the numbers to
                    evenNum += num; 
                }
                else
                {
                    //we are subtracting odds in array so -=
                    oddNum -= num;
                }
            }
            //add them together at the end
            return evenNum + oddNum;

            //if you want to linq and lambda stuff you can do below!:
            //return numbers.Where(num => num % 2 == 0).Sum() - numbers.Where(num => num % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //created a new list and added each string to the list
            List<string> stringList = new List<string>();
            stringList.Add(str1);
            stringList.Add(str2);
            stringList.Add(str3);
            stringList.Add(str4);

            //converted list to array so I could use .Length
            string[] str = stringList.ToArray();

            //str.Min() does not work on its own - I had to use a lambda to look loop through the length?
            return str.Min(s => s.Length);

            //return stringList.Min().Count(); //this did not work for some reason.. not sure why
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //create new list to add the integers to it
            List<int> intList = new List<int>();
            intList.Add(number1);
            intList.Add(number2);
            intList.Add(number3);
            intList.Add(number4);

            //use .Min() method to get smallest number
            return intList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            //all I had to do was initialize the property in the business class for the Name. You would do the class value
            //which is biz then dot notation Name = biz.Name
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //if you add two sides and they are less than or equal.. it is false I guess
            //is there an easier way to do this? how can I return true? I did greater than and equal to, but not all of them passed
            if(sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1) 
            {
                return false;
            }
            return true;
        }

        public bool IsStringANumber(string input)
        {
            //nullcheck first
            if (input == null)
            {
                return false;
            }

            //create a double variable
            //double num; //leaving this out for now since underscore works

            //double.TryParse includes int - I input the string input and output it as a double
            //why does double.TryParse also work for int?
            if (double.TryParse(input, out _)) //so I guess you can just do underscore instead of creating double num.. why does underscore work?
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //more than half of the elements in array must be null to be true 
            //otherwise false
            //think array.Length / 2 if elements are null?
            //need to make some kind of loop to go thru each element in array

            var nullValues = 0;

            //continue keyword is like a break

            foreach (var value in objs)
            {
                if (value == null)
                {
                    nullValues++; //just counting nulls
                }
            }
            //if nulls in the array are greater than other types in array divide length of array by 2
            return nullValues > (objs.Length / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            //determine average number by sum of evens / by length
            //newArray.Sum() / newArray.Length;
            //recognize even by num % 2 == 0 
            
            //test requires null check
            if (numbers == null)
            {
                return 0;
            }

            //create variables for sum (all of the elements in array)
            //example: 1, 2, 4, 5, 6, 8, 4
            //sum evens is = 24
            //counter = 5
            //24 / 5 = 4.8
            double sum = 0;
            double counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                //locate even numbers in array
                if(numbers[i] % 2 == 0)
                {
                    //total elements in array incremented
                    counter++;
                    //sum here are the even numbers in the array summed up
                    sum += numbers[i];
                }
            }
            //need to check for sum being 0, this includes empty array and only odd nums in array
            if(sum == 0)
            {
                return 0;
            }
            //once it goes thru the if statement in the for loop to locate the evens 
            //it takes sum of all evens and divides it by the counter (total elements think of counter as 'count')
            return sum / counter;
        }

        public int Factorial(int number)
        {
            //factorial is a number that is multiplied by its previous number
            //meaning.. if number = 2 then we go 2 * 1 because 1 was previous number
            //then we would plug 3 into number and multiply by 2 which was answer to previous factorial
            if(number < 0)
            {
                //don't need to use return
                throw new ArgumentOutOfRangeException("number");
            }
            if(number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1); 
        }
    }
}
