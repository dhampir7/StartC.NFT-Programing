﻿/*4.1.5.2 정적 메서드*/

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            return;
        }

        Console.WriteLine(args[0]);
        Console.WriteLine(args[1]);
    }
}