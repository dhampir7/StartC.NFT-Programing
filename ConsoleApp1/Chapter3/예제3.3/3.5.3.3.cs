﻿/*3.5.3.3 goto 문*/

using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			int n = 0;

		LOOP:
			n++;
			if (n > 1000)
			{
				goto LOOPEXIT;
			}

			if ((n % 2) != 0) goto LOOP;

			sum += n;
			goto LOOP;

		LOOPEXIT:
			Console.WriteLine(sum);
		}
    }
}