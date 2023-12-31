﻿/*4.4.2.1 메서드 오버로드*/

using System;

class Mathematics
{

    public int Abs(int value)
    {
        return (value >= 0) ? value : -value;
    }

    public double Abs(double value)
    {
        return (value >= 0) ? value : -value;
    }

    public decimal Abs(decimal value)
    {
        return (value >= 0) ? value : -value;
    }
}

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();

            Console.WriteLine(math.Abs(-5)); // 출력 결과 5
            Console.WriteLine(math.Abs(-10.052)); // 출력 결과 10.052
            Console.WriteLine(math.Abs(20.01m)); // 출력 결과 20.01
        }
    }
}