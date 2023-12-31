﻿/*4.4.2.2 연산자 오버로드*/

using System;

public class Kilogram
{
    double mass;

    public Kilogram(double value)
    {
        this.mass = value;
    }

    public Kilogram Add(Kilogram target)
    {
        return new Kilogram(this.mass + target.mass);
    }

    public override string ToString()
    {
        return mass + "kg";
    }

    public static Kilogram operator + (Kilogram op1, Kilogram op2)
    {
        return new Kilogram(op1.mass + op2.mass);
    }
}


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kilogram 타입 사용 예제
            Kilogram kg1 = new Kilogram(5);
            Kilogram kg2 = new Kilogram(10);

            Kilogram kg3 = kg1 + kg2;
            Console.WriteLine(kg3); // 출력 결과: 15kg
        }
    }
}