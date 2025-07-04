Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"C:\invoices");
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// Excerise: Use string interpolation to create a file path
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-Ru\data.txt";

Console.WriteLine($"View message in English:\n\t{englishLocation}");

Console.WriteLine($"\n{russianMessage}:\n\t{russianLocation}");

Console.WriteLine("Hello\rWorld!");
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\r\nWorld!");

int result = 3 + 1 * 5 / 2;
Console.WriteLine($"Result of 3 + 1 * 5 / 2 = {result}");

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");