//In Terminal type:
// dotnet new console
//^ this creates the Program.cs
// dotnet build
//^ this compiles the application before running
// dotnet run
//^ automatically builds then runs the code

Console.Clear(); // clears console before the rest of the code runs
Console.WriteLine("Cheese Sandwich Recipe\n----------------------"); // \n moves next text to a new line

//Color: american spelling :(
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("yellow");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;