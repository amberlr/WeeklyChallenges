using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();

            //for (int i = 0; i < elements.Count; i += n)
            //{
            //    return elements[i].ToList;
            //}

            //return elements.Where((x, i) => i % n == 0).ToArray();
        }
    }
}
