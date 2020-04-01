# The basics of C#.

C# vs .NET

- C# is a programming language.
- .NET is a framework. 

It consists of a run-time environment (CLR) and a class library that is use for building applications.

CLR - Common Language Runtime

When compiling an application, C# compiler compiles the code to IL (Intermediate Language) code. 
IL code is platform agnostics, which makes it possible to a take a C# program on a different computer 
with different hardware architecture and operating system and run it. For this to happen, it need CLR. 
When you run a C# application, CLR compiles the IL code into the native machine code for the computer on which it is running. 
This process is called (JIT) Just-in-time Compilation.

Architecture of .NET Applications 

In terms of architecture, an application written with C# consists of building blocks called classes. 
A class is a container for data (attributes) and methods (functions). Attributes represent the state of the application. 
Methods include code. They have logic. That's where it implement our algorithms and write code.

A namespace is a container for related classes. So as your application grows in size, 
you may want to group the related classes into various namespaces for better maintainability.

As the number of classes and namespaces even grow further, you may want to physically separate related namespaces into 
separate assemblies. An assembly is a file (DLL or EXE) that contains one or more namespaces and classes. 
An EXE file represents a program that can be executed. A DLL is a file that includes code that can be re-used across 
different programs.
___
The next following Repos:

2. [Primitive Types and Expressions](https://github.com/JackieG19/PrimitiveTypes-and-Expressions)
3. [Non-Primitive Types](https://github.com/JackieG19/Csharp-NonPrimitive-Types)
4. [Control Flow](https://github.com/JackieG19/Csharp-Control-Flow)
5. [Arrays and Lists](https://github.com/JackieG19/Csharp-Arrays-and-Lists)
6. [Date and Time](https://github.com/JackieG19/Csharp-Date-and-Time)
7. [Working with Text](https://github.com/JackieG19/Csharp-Working-with-Text)
8. [Working with Files](https://github.com/JackieG19/Csharp-Working-with-Files)
9. [Debugging Applications](https://github.com/JackieG19/Csharp-Debugging-Applications)
___
**Part 2 of [Fundamentals of C#](https://github.com/JackieG19/Fundamentals-Of-Csharp-Part2)**
