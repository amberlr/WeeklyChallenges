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
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
            //bool containsUpper = password.Any(char.IsUpper);
            //bool containsLower = password.Any(char.IsLower);
            //bool containsNumber = password.Any(char.IsDigit);
        }

        public char GetFirstLetterOfString(string val)
        {
            return char.Parse(val.Substring(0, 1)); //since it wants the char we have to do char.Parse first
                                                    //we can use the substring method then provide index and length (I think?)
        }

        public char GetLastLetterOfString(string val)
        {
            return char.Parse(val.Substring(val.Length - 1)); //have to do -1 on length so it just grabs the last character
                                                              //in random string value
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
            throw new NotImplementedException();
            //array.Length - 1
            //array.Length(0, 1)

            
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
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
