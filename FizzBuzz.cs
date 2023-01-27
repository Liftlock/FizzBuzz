﻿using System;
using System.Net.Sockets;

namespace Code.Kata
{

    public class FizzBuzz
    {

        public FizzBuzz() { }
        public string Check(int valueToCheck)
        {
            if (valueToCheck % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (valueToCheck % 3 == 0)
            {
                return "Fizz";
            }
            if (valueToCheck % 5 == 0)
            {
                return "Buzz";
            }
            return valueToCheck.ToString();
        }

        public int Count(int countTo) {
            int result = 0;
                
            for (int i = 1; i <= countTo; i++) {    
                Console.WriteLine(Check(i));
                result++;
            }

            return result;
        }
    }



}


