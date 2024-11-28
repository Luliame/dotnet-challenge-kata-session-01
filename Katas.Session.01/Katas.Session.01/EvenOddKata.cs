using System;

namespace Katas.Session._01;

public static class EvenOddKata
{
    /// <summary>
    /// This method take an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static string EvenOrOdd(int input) => input % 2 == 0 ? "Even" : "Odd";
}
