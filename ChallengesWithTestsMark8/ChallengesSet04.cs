using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var x = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    x += numbers[i];
                } 
                else 
                {
                    x -= numbers[i];
                }
            }
            return x;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if (str1.Length < str2.Length && str1.Length < str3.Length && str1.Length < str4.Length)
            {
                return str1.Length;
            }
            else if (str2.Length < str1.Length && str2.Length < str3.Length && str2.Length < str4.Length)
            {
                return str2.Length;
            }
            else if (str3.Length < str1.Length && str3.Length < str4.Length && str3.Length < str2.Length)
            {
                return str3.Length;
            }
            else if (str1.Length == str2.Length && str1.Length < str3.Length && str1.Length < str4.Length)
            {
                return str1.Length;
            }
            else if (str2.Length == str3.Length && str2.Length < str1.Length && str2.Length < str4.Length)
            {
                return str2.Length;
            }
            else if (str1.Length == str2.Length && str2.Length == str3.Length && str3.Length < str4.Length)
            {
                return str1.Length;
            }
            else return str4.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 < number2 && number1 < number3 && number1 < number4)
            {
                return number1;
            }
            else if (number2 < number1 && number2 < number3 && number2 < number4)
            {
                return number2;
            }
            else if (number3 < number1 && number3 < number2 && number3 < number4)
            {
                return number3;
            }
            else if (number1 == number2 && number1 < number3 && number1 < number4)
            {
                return number1;
            }
            else 
            {
                return number4;
            }

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            var trueCoders = new Business();
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 == 0 || sideLength2 == 0 || sideLength3 == 0)
            {
                return false;
            }
            else if (sideLength1 > sideLength2 + sideLength3 && sideLength2 > sideLength1 + sideLength3 && sideLength3 > sideLength1 + sideLength2)
            {
                return true;
            } else return false;
        }

        public bool IsStringANumber(string input)
        {
            var answer = false;
            if (input == null)
            {
                return answer;
            }
            else if (input == "")
            {
                return answer;
            }
            var lettersAndSymbols = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '!', '@', '#', '$', '%', '^', '&', '*', '?' };
            for (int i = 0; i < lettersAndSymbols.Count; i++)
            {
                if (input.Contains(lettersAndSymbols[i]))
                {
                    return answer;
                }
            }
            answer = true;
            return answer;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullCounter = 0;
            var nonNullCounter = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullCounter++;
                }
                else if (objs[i] != null)
                {
                    nonNullCounter++;
                }
            }
            if (nullCounter > nonNullCounter)
            {
                return true;
            }
            else return false;
        }

        public double AverageEvens(int[] numbers)
        {
            //double empty = 0;
            //if (numbers == null)
            //{
            //    return empty;
            //}
            //var evensList = new List<double>();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        evensList.Add(numbers[i]);
            //    }
            //}
            //return Queryable.Average(evensList.AsQueryable());

            try
            {
                return numbers.Where(x => x % 2 == 0).Average();
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 1 || number == 0)
            {
                return 1;
            }
            if (number >= 2)
            {
                var factorial = number * Factorial(number - 1);
                return factorial;
            }
            return 0;
        }
    }
}
