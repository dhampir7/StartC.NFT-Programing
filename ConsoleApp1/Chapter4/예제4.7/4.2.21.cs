﻿/*4.2.1 정보 은닉*/

class Circle
{
    public double pi = 3.14;
    // 이하 구현 생략
}

class Program
{
    static void Main(string[] args)
    {
        Circle o = new Circle();
        o.pi = 3.14159;             // 쓰기
        double piValue = o.pi;      // 읽기
}