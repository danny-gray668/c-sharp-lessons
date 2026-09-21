//=======================================================
//              Section 0: Method Calls 
//=======================================================
// HelloWorld();
// WorkWithIntegers();
// OrderPrecedence();
// WorkWithDoubles();
// WorkWithDecimals();
TupleTraining();

//=======================================================
//              Section 1: Hello World 
//=======================================================
void HelloWorld()
{
    ////////////// Section 1 //////////////////////
    // Basics
    Console.WriteLine("Hello World!!");

    string aFriend = "Jack";
    Console.WriteLine("Hello " + aFriend);
    aFriend = "Sophia";
    Console.WriteLine("Hello " + aFriend);
    Console.WriteLine($"Hello {aFriend}");

    ////////////// Section 2 //////////////////////
    // Declaratives and Calling
    string firstFriend = "Joe";
    string secondFriend = "Brad";

    Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
    Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");

    ////////////// Section 3 //////////////////////
 
    // Trimming 
     string greeting = "      Hello World!       ";
    Console.WriteLine($"[{greeting}]");

    string trimmedGreeting = "";
    trimmedGreeting = greeting.TrimStart();
    Console.WriteLine($"[{trimmedGreeting}]");
    trimmedGreeting = greeting.TrimEnd();
    Console.WriteLine($"[{trimmedGreeting}]");
    trimmedGreeting = greeting.Trim();
    Console.WriteLine($"[{trimmedGreeting}]");

    // Simple Text Formatting
    Console.WriteLine(greeting.ToUpper());
    Console.WriteLine(greeting.ToLower());

    // Replacing
    string sayHello = "Hello World!";
    Console.WriteLine(sayHello);
    sayHello = sayHello.Replace("Hello", "Greetings");
    Console.WriteLine(sayHello);

    // Contains
    string songLyrics = "You say goodbye, and I say hello";
    Console.WriteLine(songLyrics.Contains("goodbye"));
    Console.WriteLine(songLyrics.Contains("greetings"));
}

//=======================================================
//              Section 2: Numbers 
//=======================================================
////////////////////// Section 1 //////////////////////
void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);
}

////////////////////// Section 2 //////////////////////
void OrderPrecedence()

{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine("d = " + d);

    int e = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine("e = " + e);

    int f = 3;
    int g = 2;
    int h = f / g;
    Console.WriteLine("h = " + h);
    Console.WriteLine("Here it is important to note that 'h' is actually 2/3.");
    Console.WriteLine("Integer Math Returns Integers. Always.");
    Console.WriteLine("");
    Console.WriteLine("");

    int a2 = 7;
    int b2 = 4;
    int c2 = 3;
    int d2 = (a2 + b2) / c2;
    int e2 = (a2 +b2) % c2;
    Console.WriteLine($"Quotent: {d2}");
    Console.WriteLine($"Remainder: {e2}");
 

    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

    int what = max + 3;
    Console.WriteLine($"Example Overflow: {what}");
}

////////////////////// Section 2 //////////////////////
void WorkWithDoubles()
{
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine($"Double Value for d: {d}");
    
    double a2 = 19;
    double b2 = 23;
    double c2 = 8;
    double d2 = (a2 + b2) / c2;
    Console.WriteLine($"Double Value for d2: {d2}");
    
    double max = double.MaxValue;
    double min = double.MinValue;

    Console.WriteLine($" he range of double is {min} to {max}");

    double third = 1.0 / 3.0;
    Console.WriteLine($"1.0/3.0 as doubles is:  {third}");
}

////////////////////// Section 2 //////////////////////
void WorkWithDecimals()
{

    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of the decimal type is {min} to {max}"); 

    Console.WriteLine($"Integer Value of 1/3 = {(1/3)}");
    
    double a = 1.0;
    double b = 3.0;
    Console.WriteLine($"Double Value of 1/3 = {(a / b)}");

    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine($"Decimal Value of 1/3 = {(c /d)}");

    double rad = 2.50;
    double area = Math.PI * (rad * rad);
    Console.WriteLine($"The are of a circle with a radius of {rad}cm will have an area of {area}cm^2");

}

//=======================================================
//              Section 2: Numbers 
//=======================================================
////////////////////// Section 1 //////////////////////
void TupleTraining()
{
    Console.WriteLine($"Tuple Training Ready to Begin!");

}