using System;

namespace MadLib {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.Write("Enter word ");
            string word = GetInput(); // Calls GetInput() method to get input from the user
            Console.WriteLine("You entered" + word); // displays wntered word
        }

        private static string GetInput() {
            string input = "";
            do { // loops through inpput looking for valid input from user
                try { // attempts to get input from user. 
                    input = Console.ReadLine();
                    if (input == "") // Trows an error if inout isn't valid
                        throw new ArgumentException("Please input a word");
                } catch (ArgumentException ae) { // catches error from the try block
                    Console.WriteLine("There was an error. " + ae.Message);
                }
            } while (input == ""); // loops if input is left blank

            return input; // returns value of the input variable
        }
    }
}
