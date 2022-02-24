using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        const int MY_CONST = 42;
        Console.WriteLine(MY_CONST);
    }

    public static IEnumerable<int> StateMachineTest(int a, int b)
    {
        int c = a;
        for (int i = 0; i < 10; i++)
        {
            c += b;
            yield return c;
        }
    }

    public static void LocalVariableTest()
    {
        var kvp = KeyValuePair.Create(1, 2);
        Console.WriteLine(kvp.Key);
    }
}