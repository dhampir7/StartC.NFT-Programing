﻿/*3.5.3.3 goto 문*/

using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int x = 2; x < 10; x ++)
			{
				for (int y = 1; y < 10; y ++)
				{
					Console.WriteLine(x + "*" + y + " = " + (x * y));

					if (x == 5 && y == 8) goto LOOP_EXIT;
				}
			}

		LOOP_EXIT:;
		}
    }
}