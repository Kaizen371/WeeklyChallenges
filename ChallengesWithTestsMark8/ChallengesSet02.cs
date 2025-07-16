using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return(number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            var sum = numbers.Min() + numbers.Max() + 0;
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
            
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (int a in numbers)
            {
                sum += a;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (int a in numbers)
            {
                if (a % 2 == 0)
                {
                    sum += a;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int a in numbers)
            {
                sum += a;
            }

            return (sum % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number < 0) ? 0 : number / 2;
            
        }
    }
}
