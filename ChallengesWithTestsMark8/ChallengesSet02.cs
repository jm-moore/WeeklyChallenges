using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
           return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var answer = (str1.Length < str2.Length) ? str1.Length : str2.Length;
            return answer;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            } else return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            } else return numbers.Where(x => x % 2 == 0).Sum();
        }
        
        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Sum() % 2 != 0)
            {
                return true;   
            } 
            else return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var list = new List<long>();
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.Count();
        }
    }
}
