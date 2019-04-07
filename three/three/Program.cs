using System;

namespace three{
    class Program{
        static void Main(string[] args) {
            Console.WriteLine("Enter a word!");
            String userInput = Console.ReadLine();
            reverseString(userInput);
        }

        static void reverseString(String userInput) {
            Char[] word = userInput.ToCharArray();
            for (int i = word.Length - 1; i > -1; i--) {
                Console.Write(word[i]);
            }
        }
    }
}
// h e l l o = 5;
// 0 1 2 3 4