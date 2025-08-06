using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            var foundFalse = false;
            foreach (bool b in vals)
            {
                if (!b)
                {
                    foundFalse = true;
                    break;
                }
            }
            return foundFalse;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null){return false;}
            var oddSum = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers.ElementAt(i) % 2 != 0)
                {
                    oddSum += numbers.ElementAt(i);
                }
            }
            return oddSum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasNumbers = password.Any(char.IsNumber);
            
            return hasUpper && hasLower && hasNumbers;

        }

        public char GetFirstLetterOfString(string val)
        {
            char firstLetter = val[0];
            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            char lastLetter = val[^1];
            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0 || divisor == 0){ return 0; }
            return dividend / divisor;
            
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            int oddIndex = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds[oddIndex] = i;
                    oddIndex++;
                }
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
