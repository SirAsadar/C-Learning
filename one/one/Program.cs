using System;

namespace one{
    class Program{

        
        static void Main(string[] args) {
            String finalUnit;
            String origUnit;
            double origValue;
         
            Console.WriteLine("Enter the unit you'd like to convert to: ");
            finalUnit = Console.ReadLine();
            Console.WriteLine("Enter the original unit type: ");
            origUnit = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the value: ");
            String userInput = Console.ReadLine();
            origValue = Convert.ToDouble(userInput);
        
            Console.WriteLine("\n"+ convertUnit(finalUnit, origUnit, origValue)+ finalUnit);
        }

        public static double convertUnit(String finalUnit, String origUnit, double origValue) {

            double finalValue;
            
            if (finalUnit.Equals("ft")) {
                if (origUnit.Equals("in")) {
                    finalValue = origValue / 12;
                    return finalValue;
                }else if (origUnit.Equals("cm")) {
                    finalValue = origValue / 30.48;
                    return finalValue;
                }else if (origUnit.Equals("m")) {
                    finalValue = origValue * 3.28;
                    return finalValue;
                }
            }else if (finalUnit.Equals("in")) {
                if (origUnit.Equals("ft")) {
                    finalValue = origValue * 12;
                    return finalValue;
                }else if (origUnit.Equals("cm")) {
                    finalValue = origValue * 2.54;
                    return finalValue;
                }else if (origUnit.Equals("m")) {
                    finalValue = origValue * 39.3701;
                    return finalValue;
                }
            }else if (finalUnit.Equals("cm")) {
                if (origUnit.Equals("ft")) {
                    finalValue = origValue * 30.48;
                    return finalValue;
                }else if (origUnit.Equals("in")) {
                    finalValue = origValue * 0.393701;
                    return finalValue;
                }else if (origUnit.Equals("m")) {
                    finalValue = origValue * 100;
                    return finalValue;
                }
            }else if (finalUnit.Equals("m")) {
                if (origUnit.Equals("ft")) {
                    finalValue = origValue * 0.3048;
                    return finalValue;
                }else if (origUnit.Equals("in")) {
                    finalValue = origValue * 0.0254;
                    return finalValue;
                }else if (origUnit.Equals("cm")) {
                    finalValue = origValue * 0.01;
                    return finalValue;
                }
            }
            return 0.0;
        }
    }
}