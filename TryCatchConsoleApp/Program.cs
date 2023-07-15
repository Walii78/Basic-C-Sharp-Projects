using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
             // Create a list of integers
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                try
                {
                    // Ask the user for a number to divide each number in the list by
                    Console.WriteLine("Enter a number to divide each number in the list by:");
                    int divisor = Convert.ToInt32(Console.ReadLine());

                    // Loop through each integer in the list and display the result after division
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int result = numbers[i] / divisor;
                        Console.WriteLine(numbers[i] + " divided by " + divisor + " is: " + result);
                    }
                }
                catch (DivideByZeroException)
                {
                    // Error message for dividing by zero
                    Console.WriteLine("Cannot divide by zero. Please enter a non-zero number.");
                }
                catch (FormatException)
                {
                    // Error message for invalid input (string)
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                finally
                {
                    // Message indicating program execution after the try/catch block
                    Console.WriteLine("The program has emerged from the try/catch block and continued with program execution.");
                }

                Console.ReadLine();
            }
        }
    }
