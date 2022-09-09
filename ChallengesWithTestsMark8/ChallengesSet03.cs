using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var v in vals)
            {
                if (v == false)
                {
                    return true;
                }
                
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            if (numbers.Sum() % 2 != 0)
            {
                return true;
            } else return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool IsLower = false;
            bool isNumber = false;
            foreach (var ch in password)
            {
                if (char.IsUpper(ch))
                {
                    isUpper = true;
                }
                if (char.IsLower(ch))
                {
                    IsLower = true;
                }
                if (char.IsNumber(ch))
                {
                    isNumber = true;
                }
            }
            if (IsLower && isUpper && isNumber)
            {
                return true;
            }
            else return false;
        }

        public char GetFirstLetterOfString(string val)
        {
                return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var oddsBelow100 = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i < 100 & i % 2 != 0)
                {
                    oddsBelow100.Add(i);
                }
            }
            return oddsBelow100.ToArray();
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
