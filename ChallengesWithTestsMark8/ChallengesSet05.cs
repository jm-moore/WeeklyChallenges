using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
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
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            var AscendingOrder = numbers.OrderBy(x => x).ToArray();
            return AscendingOrder.SequenceEqual(numbers);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }


        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string sentence = "";
            foreach (var w in words)
            {
                if (w.Trim().Length > 0)
                {
                    sentence += w.Trim() + " ";
                }
            }

            if (sentence.Length == 0)
            {
                return "";
            }
            return sentence.Trim() + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var result = new List<double>();
            if (elements == null || elements.Count == 0)
            {
                return result.ToArray();
            }
            for (int i = 3; i < elements.Count; i+=4)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = i + 1; x < nums.Length; x++)
                {
                    if (nums[i] + nums[x] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
