using System;

class Operators
{
	static void Main(string[] args)
	{
		//Arithmetic operators
		Console.WriteLine(2+2);
		Console.WriteLine(2-2);
		Console.WriteLine(2*2);
		Console.WriteLine(2/2);
		Console.WriteLine(2%2);
		int a = 2,b = 1;
		a++;
		b--;
		Console.WriteLine(a);
		Console.WriteLine(b);

		//Assignment operators
		int x = 10;
		x += 5;
		Console.WriteLine("x += 5 -> " + x);
		x -= 3;
		Console.WriteLine("x -= 3 -> " + x);
		x *= 2;
		Console.WriteLine("x *= 2 -> " + x);
		x /= 4;
		Console.WriteLine("x /= 4 -> " + x);
		x %= 3;
		Console.WriteLine("x %= 3 -> " + x);

		int y = 5;
		y &= 3;
		Console.WriteLine("y &= 3 -> " + y);
		y |= 2;
		Console.WriteLine("y |= 2 -> " + y);
		y ^= 1;
		Console.WriteLine("y ^= 1 -> " + y);
		y <<= 1;
		Console.WriteLine("y <<= 1 -> " + y);
         	y >>= 1;
		Console.WriteLine("y >>= 1 -> " + y);
		
	}
}