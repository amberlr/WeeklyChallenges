using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word = word.ToLower();
                //Select goes thru and find the string in words
                //then grabs everything in lowercase and stores it in new list lc
                List<string> lc = words.Select(x => x.ToLower()).ToList();
                //looks thru lc list that has been converted to lower to see if it contains the word
                //.Contains return boolean
                containsWord = lc.Contains(word);
            }
            if(ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            //according to tests anything under 0 needs to return false and 1 is also not prime
            //so this is why I did num <= 1
            if (num <= 1)
            {
                return false;
            }
            //start at 2 since it's first prime number
            for (int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //all I had to do was loop thru the string in reverse so it would grab the LAST unique index..
            //otherwise it will just grab the first.. which is why I failed two of the tests
            //start at end of string by doing Length -1, to loop i needs to be greater than or equal to 0, then decrement by 1
            for(int i = str.Length - 1; i >= 0; i--)
            {
                if (str.IndexOf(str[i]) == str.LastIndexOf(str[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1; //changed from 0 to 1
                for (int j = i + 1; j < numbers.Length; j++) //may need to ask about this again sometime but I changed j = 0 to j = i + 1
                {
                    if (numbers[i] != numbers[j])
                    {
                        break; //drops out of the if statement
                    }
                    count++; //needed this out of the if loop
                }
                if (count > max)
                {
                    max = count;
                }
            }
            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0 || n > elements.Count)
            {
                return new double [0];
            }

            //pretty much this linq is doing a foreach loop, checking conditional, then converting to array
            return elements.Where(element => element % n == 0).ToArray();

            //Long way:
            List<double> result = new List<double>();

            for (int i = 0; i < elements.Count; i++) //tried i += n which doesn't work because i is based of index and n is count..
                                                     //meaning if n was 10.. i would be index 9 so they can't match to get right answer
            {
                if (elements[i] % n == 0) //mistake here was doing i % n.. I have to use the list in place of i
                {
                    result.Add(elements[i]);
                }
            }
            return result.ToArray();


        }
    }
}
