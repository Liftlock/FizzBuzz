using System;
using System.Net.Sockets;

namespace Code.Kata {

    public class FizzBuzz {

        public FizzBuzz() { }
        public string Check(int valueToCheck) {
            string result = "";

            if (valueToCheck % 3 == 0) {
                result "Fizz";
            }
            if (valueToCheck % 5 == 0) {
                result "Buzz";
            }
            if (valueToCheck % 15 == 0) {
                result "FizzBuzz";
            }
            return result;
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