using System;

class StringF
{
	static void Main(string[] args)
	{
		string str = "Hello welcome to C# coding program";
		Console.WriteLine("The Length of string : " + str.Length);
		Console.WriteLine("The string in lowercase : " + str.ToLower());
		Console.WriteLine("The string in uppercase : " + str.ToUpper());

		//string concatenation
		string firstName = "John";
		string lastName = " Doe";
		string name = string.Concat(firstName,lastName);
		Console.WriteLine(name);
		
		//adding 2 strings
		string x = "10";
		string y = "20";
		string z = x + y;
		Console.WriteLine(z);

		//interpolation
		//string fName = "John";
		//string lName = "Doe";
		//string fullName = $" My full name is : {fName} {lName}";
		//Console.WriteLine(fullName);

		//access string
		string myStr = "Hello";
		Console.WriteLine(myStr[1]);
		Console.WriteLine(myStr.IndexOf("l"));
		int charPos = myStr.IndexOf("H");
		string subStr = myStr.Substring(charPos);
		Console.WriteLine(subStr);
		
		//Special character
		string txt = "C# is a \"Object-Oriented Language\".";
		Console.WriteLine(txt);
		string txt1 = "It\'s alright.";
		Console.WriteLine(txt1);
		string txt2 = "The character \\ is blackslash.";
		Console.WriteLine(txt2);
			
	}
}