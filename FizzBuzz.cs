using System;

namespace Code.Kata {
    public class FizzBuzz {

        public FizzBuzz() { }
        
        public string Check(int valueToCheck) {
            string result = "";

            if (valueToCheck % 3 == 0) {
                result = "Fizz";
            }

            if (valueToCheck % 5 == 0) {
                result += "Buzz"; // Note the concatination
            }
            return (result.Length > 0) ? result : valueToCheck.ToString();
        }

        public int Count(int countTo) {
            int result = 0;
                
            for (int i = 1; i <= countTo; i++) {    
                Console.WriteLine(Check(i));
                result++;
            }
            Console.WriteLine($" result is: {result}");
            return result;
        }
    }
}