using System;

namespace three{
    class Program{
        static void Main(string[] args) {
            Console.WriteLine("Enter a word!");
            String userInput = Console.ReadLine();
            Console.WriteLine(reverseString(userInput));
        }

        static String reverseString(String userInput) {
            String reverseWord = "";
            Char[] word = userInput.ToCharArray();
            for (int i = word.Length - 1; i > -1; i--) {
                reverseWord += word[i];
            }

            return reverseWord;
        }
    }
}
// h e l l o = 5;
// 0 1 2 3 4