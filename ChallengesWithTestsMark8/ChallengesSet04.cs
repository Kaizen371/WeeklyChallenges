using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
           
            string[] words = {str1, str2, str3, str4};
            
            int shortestLength = words.Min(w => w.Length);
            return shortestLength;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = {number1, number2, number3, number4};
             int smallestNumber = numbers.Min();
             return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength2) && (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            //is first char + or - if is remove 
            //if there is commam, replace with nothing
            //if one . replace with nothing
            if (input == null || input == String.Empty){return false;}
            var firstChar = input.ToCharArray()[0];
            if (firstChar == '-')
            {
                input = input.Substring(1);
            }
            input = input.Replace(",", "");

            var dotCount = input.Where(c => c == '.').Count();
            if (dotCount > 1)
            {
                return false;
            }
            input = input.Replace(".", "");
            return input.All(c => char.IsDigit(c));


        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null)
            {
                return true;
            }

            var nullCount = objs.Where(c => c == null).Count();
            
            return nullCount > objs.Length / 2;
            
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
                
            }
            double average = 0;
            var evens = numbers.Where(x => x % 2 == 0);

            if (evens.Any() && evens.Sum() != 0)
            {
                average = evens.Average();
            }
            

            return average;
            
        }

        public int Factorial(int number)
        {
            if (number < 0) { throw new ArgumentOutOfRangeException(); }
            var factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
