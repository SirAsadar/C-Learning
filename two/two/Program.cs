using System;
//Fizzbizz
namespace two
{
    class Program{
        static void Main(string[] args){
            for (int i = 1; i <= 100; i++) {
                Console.WriteLine(fizzBizz(i));
            }
        }
        private static String fizzBizz(int i){
            if(i % 3 == 0 && i % 5 == 0) {
                return "FizzBizz";
            }else if (i % 3 == 0) {
                return "Fizz";
            }else if (i % 5 == 0) {
                return "Bizz";
            }
            else {
                return i + "";
            }
        }
    }
}
