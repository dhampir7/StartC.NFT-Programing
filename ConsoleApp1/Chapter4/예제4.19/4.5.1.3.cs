﻿/*4.5.1.3 델리게이트*/

using System;

public class Disk
{
    public int Clean(object arg)
    {
        ConsoleApplication1.WriteLine("작업 실행");
        return 0;
    }
}

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Disk disk = new Disk();

            FuncDelegate cleanFunc = new FuncDelegate(disk.Clean);
            FuncDelegate workFunc = disk.Clean();

            disk.Clean(null);   // Clean 메서드를 직접 호출
            cleanFunc(null);    // 델리게이트 인스턴스를 통해 Clean 메서드를 호출
        }
    }
}