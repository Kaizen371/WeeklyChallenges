using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNumber = startNumber + 1;
            while (nextNumber % n != 0)
            {
                nextNumber++;
            }
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers is null){return false;}
            if(numbers.Length == 0){return false;}
            for (int i = 0; i  < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
           if (numbers is null){return 0;}
            bool lastNumberEven = false;
            var sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (lastNumberEven)
                {
                    sum += numbers[i];
                }
                lastNumberEven = numbers[i] % 2 == 0;
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words is null){return string.Empty;}
            var filter = words.Select(word => word.Trim()).Where(word => word.Length != 0);
            var sentence = string.Join(" ", filter);
            if (sentence.Length == 0)
            {
                return string.Empty;
            }
            else
            {
                return $"{sentence}.";
            }

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements is null){return System.Array.Empty<double>();}
            var element = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                element.Add(elements[i]);
            }
            return element.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
