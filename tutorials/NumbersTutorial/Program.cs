//=======================================================
//              Section 0: Method Calls 
//=======================================================
// HelloWorld();
// WorkWithIntegers();
OrderPrecedence();

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
    // Calling Variables
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
    // Console.Clear();
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
    Console.WriteLine(c);
}