using System;
using System.Linq;

namespace Katas.Session._01;

public static class MinMaxKata
{
    /// <summary>
    /// This method return the min and max value from the given input string. All numbers in the given string are separated by a space
    /// Examples Input: "1 2 3 4 5"   =>  Output: "5 1"
    /// Output string must be two numbers separated by a single space, and highest number is first.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string ComputeMinMax(string input)
    {
        return input.Split(" ").Aggregate((res, curr) =>
        {
            int min = 0, max = 0;
            string[] results = res.Split(" ");

            max = int.Parse(results[0]);
            min = int.Parse(results[results.Length > 1 ? 1 : 0]);

            if (int.TryParse(curr, out int parsed))
            {
                if (parsed < min)
                    min = parsed;
                if (parsed > max)
                    max = parsed;
            }

            return $"{max} {min}";
        });
    }
}
