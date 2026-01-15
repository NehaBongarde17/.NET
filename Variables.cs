using System;

class Variables
{
	static void Main(string[] args)
	{
		//string variable
		string name = "John";
		Console.WriteLine(name);

		//int variable
		int myNum = 15;
		Console.WriteLine(myNum);

		//Without assigning value
		int num;
		num = 20;
		Console.WriteLine(num);

		//overwrite the pervious value
		int myNum1 = 30;
		myNum1 = 25;
		Console.WriteLine(myNum1);
		
		//other types variable
		double myDoubleNum = 2.99D;
		char myChar = 'N';
		bool myBool = true;
		Console.WriteLine(myDoubleNum);
		Console.WriteLine(myChar);
		Console.WriteLine(myBool);

		//constant
		//const int a = 12;
		//a = 17; show an error

		//display variables
		string str1 = "John";
		Console.WriteLine("Hello " + str1);

		//use + to add 2 strings
		string firstName = "John ";
		string lastName = "Ben";
		string fullName = firstName + lastName;
		Console.WriteLine(fullName);

		//multiple variables
		int x = 10,y = 20,z = 30;
		Console.WriteLine(x + y + z);

		//implicit casting
		Console.WriteLine("---casting---");
		int a = 12;
		double b = a;
		Console.WriteLine(a);
		Console.WriteLine(b);

		//explicit casting
		double n = 2.99;
		int m = (int)n;
		Console.WriteLine(n);
		Console.WriteLine(m);

		//use ReadLine
		Console.Write("Enter username:");
		string userName = Console.ReadLine();
		Console.WriteLine("Username is : " +userName);
		Console.Write("Enter age:");
		int age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Age is : " + age);
		

	}
}
