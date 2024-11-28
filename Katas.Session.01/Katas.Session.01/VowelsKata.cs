using System;
using System.Linq;

namespace Katas.Session._01;

public static class VowelsKata
{
    /// <summary>
    /// This method counts number of vowels in the given string
    /// We will consider a, e, i, o, u as vowels for this Kata (but not y).
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static int CountVowels(string input)
    {
        char[] vowels = ['a', 'e', 'i', 'o', 'u'];
        int count = 0;

        foreach (char letter in input.ToCharArray())
        {
            if (vowels.Contains(letter)) count++;
        }

        return count;
    }
}

