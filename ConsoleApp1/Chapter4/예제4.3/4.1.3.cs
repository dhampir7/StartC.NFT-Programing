﻿/*4.1.3 생성자*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("person 객체 생성되기 전.");
            Person person = new Person();
            Console.WriteLine("person 객체 생성된 후.");
        }
    }

    class Person
    {
        string name;

        public Person()
        {
            name = "홍길동";
            Console.WriteLine("생성자 호출");
        }
    }

}