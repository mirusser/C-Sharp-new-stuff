using System;
using System.Threading.Tasks;
using What_s_new_in_cSharp_9;

//Top level Programs Basics
//in c# 9 you dont have to write namespace, main and all that stuff
//its all generating in the backgroung if you are not including the ususal stuff 
//in Program.cs making that wrting a consol app is like using a scrip language

Console.WriteLine("Hello world");

var doStuff = new DoStuff();
doStuff.Run();

//you can use async methods/task in Top level programs no problem
//this is just proof of concept
await MyAsyncMethod();

//args in top level programs is still there,
//its just hidden
Console.WriteLine(args[0]);

#region target typing
MyClass myClass = new()
{
    MyValue = "123"
};

MyClassWithConstructor myClassWithConstructor = new("12312");
#endregion


#region Improved Pattern Matching
ISomeInterface instance = new SomeClass();

#region Keywords
//not keyword
if (instance is not SomeClass)
{
    //do something here
}

//and/or keyword
if (instance is ISomeInterface and not SomeOhterClass)
{
    //do stuff here
}

if (instance is SomeClass or SomeOhterClass)
{
    //stuff here
}
#endregion

var myNumber = new Random().Next(1, 20);

if (myNumber is >= 0 and <= 10)
{
    Console.WriteLine("More than 0, less than 10");
}
else if (myNumber is > 10 and <= 20)
{
    Console.WriteLine("More than 10, less than 20");
}

//switch statements
Console.WriteLine("in switch statement");
switch (myNumber)
{
    case >= 0 and <= 10:
        Console.WriteLine("More than 0, less than 10");
        break;
    case > 10 and <= 20:
        Console.WriteLine("More than 10, less than 20");
        break;
    default:
        break;
}

//switch expression with patterns (it has to result a value)
var result = myNumber switch
{
    >= 0 and <= 10 => "More than 0, less than 10",
    > 10 and <= 20 => "More than 10, less than 20",
    _ => throw new NotImplementedException() // default
};

Console.WriteLine(result);
#endregion

async Task MyAsyncMethod()
{
    await Task.Yield();
}
