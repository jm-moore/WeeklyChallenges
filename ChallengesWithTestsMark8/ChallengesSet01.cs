﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend -= subtrahend;
        }

        public int Add(int number1, int number2)
        {
            var answer = number1 + number2;
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            var smallestNum = (number1 < number2) ? number1 : number2;
            return smallestNum;
       
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 *= factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson != "")
            {
                return $"Hello, {nameOfPerson}!";
            }
            else
            {
                return "Hello!";
            }
            
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
