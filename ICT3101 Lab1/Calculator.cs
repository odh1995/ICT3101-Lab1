using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Lab1
{
    public class Calculator
    {
        public Calculator() { }
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
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
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
            return (num1 / num2);
        }
        public double MTBF(double MTTF, double MTTR)
        {
            return (MTTF + MTTR);
        }
        public double Availability(double MTTF, double MTBF)
        {
            return Math.Round(((MTTF / MTBF) * 100), 1);
        }
        public double CurrentFailureIntensity(double initialFailureIntensity, double averageNumFailureTimeT, double totalNumFailure)
        {
            return Math.Round((initialFailureIntensity * (1 - (averageNumFailureTimeT / totalNumFailure))), 0);
        }
        public double AverageNumberofExpectedFailure(double totalNumFailure, double initialFailureIntensity, double time)
        {
            return Math.Round(totalNumFailure * (1 - Math.Exp(((initialFailureIntensity / totalNumFailure) * time * -1) )), 0);
        }
        public double CurrentFailureIntensityInLOG(double FailureIntensityDecay, double initialFailureIntensity, double averageNumFailure)
        {
            return Math.Round((initialFailureIntensity * Math.Exp(-1 * FailureIntensityDecay * averageNumFailure)), 2);
        }
        public double NumberofExpectedFailureAfterTimeInLOG(double FailureIntensityDecay, double initialFailureIntensity, double time)
        {
            return Math.Round(((1/FailureIntensityDecay) * Math.Log((initialFailureIntensity * FailureIntensityDecay * time) + 1)), 0);
        }
    }
}
