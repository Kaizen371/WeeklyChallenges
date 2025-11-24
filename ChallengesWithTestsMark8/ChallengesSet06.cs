using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words == null){return false;}
            bool containsWord = false;
            string[] caseWords;
            if (ignoreCase)
            {
                
                caseWords = words.Where(w => w != null).Select(w => w.ToLower()).ToArray();
                
                
            }
            else
            {
                caseWords = words.ToArray();
                
            }
            for (int i = 0; i < caseWords.Count(); i++)
            {
                if (caseWords[i] == word)
                {
                    containsWord = true;
                }
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var charArray = str.ToCharArray();
            var index = -1;
            
           for (int i = 0; i < charArray.Length; i++)
           {
               var found = false;
               for (int j = 0; j < charArray.Length; j++)
               {
                   if (i == j)
                   {
                       continue;
                   }
                   if (charArray[i] == charArray[j])
                   {
                       found = true;
                       break;
                   }
                   
               }

               if (!found)
               {
                   index = i;
               }
           }
                
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var currentCount = 1;
            var maxCount = 1;
            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentCount++;
                }
                else if (numbers[i] != numbers[i + 1])
                {
                    currentCount = 1;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n < 1)
            {
                return Array.Empty<double>();
            }
            
            
            var result = new double[elements.Count / n ];
            
            for (int i = n - 1; i < elements.Count(); i += n)
            {
                result[(i / n)] = elements[i];
            }
            return result;
        }
    }
}
