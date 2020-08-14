using System;

namespace MadLib {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.Write("Enter word ");
            string word = GetInput();
            Console.WriteLine(word);
        }

        private static string GetInput() {
            string input = "";
            do {
                try {
                    input = Console.ReadLine();
                    if (input == "")
                        throw new ArgumentException("Please input a word");
                } catch (ArgumentException ae) {
                    Console.WriteLine("There was an error. " + ae.Message);
                }
            } while (input == "");

            return input;
        }
    }
}
