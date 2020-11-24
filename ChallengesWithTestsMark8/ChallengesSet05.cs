using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            //((100 / 5) + 1 * 5 = 105! 
            return ((startNumber / n) + 1) * n;
            
            //int q = startNumber / n;
            //int n1 = n * startNumber;
            //int n2 = (startNumber * n) > 0 ? (n * (q + 1)) : (n * (q - 1));
            //if (Math.Abs(startNumber - n1) < Math.Abs(startNumber - n2))
            //{
            //    return n1;
            //}
            //return n2;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //created for loop to go thru the whole array
            for(int i = 0; i < businesses.Length; i++)
            {
                //I kept trying to do businesses. and was wondering why the class options weren't pulling up..
                //it's an array so I have to do businesses[i]. to pull them up
                if(businesses[i].TotalRevenue == 0)
                {
                    //if you look at the test cases they just want to know if something is 0 and if it is, change the name
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            //test requires null check and array empty
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }
            
            //we already have values and expect particular boolean so we can't sort the array..
            //do a for loop with .Length - 1 so it looks at the index
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                //we want to see if successor has greater value that predeccesor.. 
                //if it does, it is false since it's not ascending
                if(numbers[i] > numbers[i+ 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            //throw new NotImplementedException();
            //have to start at first even number in array
            //then any odd number that follows the even numbers will be added together
            //so sum up all odds AFTER first even

            //1, 2, 2, 3, 4 }, 5)
            //2 + 3

            var sum = 0;
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            for (int i = 1; i < numbers.Length; i++) // i - 1 would not work unless we set i = 1 
            {
                if (numbers[i - 1] % 2 == 0) //so i - 1 is just checking the index to see if it is an even number
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //how do I remove whitespace and empty strings?
            //i need if statement for empty arrays and null array
            //maybe foreach loop for all the weird strings

            string sentence = "";

            //nullcheck first
            if(words == null)
            {
                return "";
            }
            foreach (var word in words)
            {
                //trim removes white space before string and after string
                if(word.Trim().Length > 0) //string greater than 0 it removes the whitespace
                {
                    //not sure why we have to add extra space at end, but I tried without and it doesn't work
                    //pretty much we are adding the trimmed strings to the sentence bucket and adding space at end
                    sentence += word.Trim() + " "; //removed front and back of spaces on a string
                }
            }
            
            //empty array check, but have to include it under foreach loop
            //first test fails even when using words string above foreach loop
            if(sentence.Length == 0)
            {
                return "";
            }
            //substring with 0 means beginning and length -1 will actually cut off the extra space we added above
            sentence = sentence.Substring(0, sentence.Length - 1);
            //add period at the end
            sentence += ".";
            return sentence;
            
            
            //words = words.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray(); //this removed empty strings like "" and " "
            //var result = string.Join(" ", words);
            //return result + '.'; //returns period at end of sentence

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            //throw new NotImplementedException();
            if(elements == null)
            {
                //if I just do 0.. it won't work because it will want to convert an int to double
                return new double[0];
            }
            //should ask more about this..
            return elements.Where((t, i) => (i % 4) == 3).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
