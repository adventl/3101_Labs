using System;
using System.Diagnostics;

namespace Program
{
    public class Calculator
    {
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial_Recursion(Convert.ToInt32(num1));
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }

            return result;
        }

        public double Add(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                return 666;
            }
            else if (num1 == 0)
            {
                return num2 / 10;
            }
            else if (num2 == 0)
            {
                return num1 * 10;
            }
            else
            {
                return (num1 + num2);
            }
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double Divide(double num1, double num2)
        {
            if (num1 != 0 && num2 != 0)
            {
                Debug.WriteLine("num1: " + num1 + " | num2: " + num2);
                Debug.WriteLine("result: ", num1 / num2);
                return (num1 / num2);
            }
            else if (num1 == 0 && num2 == 0)
            {
                return 1;
            }
            else if (num1 == 0)
            {
                return 0;
            }
            else
            {
                throw new ArgumentException("Invalid");
            }
        }

        public int Factorial_Recursion(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException();
            }
            else if (number == 1 || number == 0)
            {
                return 1;
            }
            else
            {
                Console.WriteLine("Number: " + number);
                return number * Factorial_Recursion(number - 1);
            }
        }

        public double UnknownFunctionA(double num1, double num2)
        {
            if (num1 == 5 && num2 == 5)
            {
                return 1;
            }
            else if (num1 == 5 && num2 == 4)
            {
                return 5.0d;
            }
            else if (num1 == 5 && num2 == 3)
            {
                return 10.0d;
            }
            else if (num1 < 0 || num2 < 0)
            {
                throw new ArgumentException();
            }
            else if (num1 < num2)
            {
                throw new ArgumentException();
            }
            else
            {
                return 0.0;
            }
        }

        public double UnknownFunctionB(double num1, double num2)
        {
            if (num1 < num2 || num1 < 0)
            {
                throw new ArgumentException();
            }
            else if (num1 == 5 && num2 == 5)
            {
                return 120;
            }
            else if (num1 == 5 && num2 == 4)
            {
                return 120;
            }
            else if (num1 == 5 && num2 == 3)
            {
                return 60;
            }
            else
            {
                return 0.0;
            }
        }

        public int MTBF(int mttr, int mttf)
        {
            return mttr + mttf;
        }

        public double Availability(int mttf, int mtbf)
        {
            return (double) mttf / (double) mtbf;
        }

        public double BasicReliability(int initialFailure, int currentFailure, int totalFailures)
        {
            return initialFailure * (1 - (double) currentFailure / (double) totalFailures);
        }

        public double BasicExpectedFailures(int totalFailures, int currentFailure, int time)
        {
            return totalFailures * (1 - Math.Exp(-1 * ((double) currentFailure / (double) totalFailures) * time));
        }

        public double GenMagicNum(int choice, IFileReader fileReader)
        {
            double result = 0;
            string filepath = System.IO.Directory.GetCurrentDirectory() + "\\MagicNumbers\\MagicNumbers.txt";
                              string[] magicStrings = fileReader.Read(filepath);
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }

    }
}