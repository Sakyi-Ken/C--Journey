// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("What is your name?");
// //string? name = Console.ReadLine();
// var name = Console.ReadLine() ?? "Guest";
// var currentDate = DateTime.Now;
// Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:T}!");
// Console.WriteLine($"{Environment.NewLine}Press any key to exit...");

using PasswordGenerator;

var pwd = new Password();
var password = pwd.Next();
Console.WriteLine(password.ToString());