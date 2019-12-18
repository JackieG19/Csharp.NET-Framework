/* using statement */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World");
		}
	}
}

/*
Meaning of the Main Syntax:

static: It means Main Method can be called without an object.

public: It is access modifiers which means the compiler can execute this from anywhere.

void: The Main method doesn’t return anything.

Main(): It is the configured name of the Main method.

String []args: For accepting the zero-indexed command line arguments. 
args is the user-defined name. So you can change it by a valid identifer. 
[] must come before the args otherwise compiler will give errors.
*/
