// //string[] fraudulentOrderIDs = new string[] { "ORD123", "ORD456", "ORD789" };
// string[] fraudulentOrderIDs = new string[3]; // Can be simplified
// fraudulentOrderIDs[0] = "ORD123";
// fraudulentOrderIDs[1] = "ORD456";
// fraudulentOrderIDs[2] = "ORD789";
// // string[] fraudulentOrderIDs = ["ORD123", "ORD456", "ORD789"];
// foreach (string orderID in fraudulentOrderIDs)
// {
//   Console.WriteLine($"Fraudulent Order ID: {orderID}");
// }

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//   sum += items;
//   bin++;
//   Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");

// string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// foreach (string orderID in orderIDs)
// {
//   if (orderID.StartsWith("B"))
//   {
//     Console.WriteLine(orderID);
//   }
// }

// /*
//   The following code creates five random OrderIDs
//   to test the fraud detection process.  OrderIDs 
//   consist of a letter from A to E, and a three
//   digit number. Ex. A123.
// */
// Random random = new Random();
// string[] IDs = new string[5];

// for (int i = 0; i < IDs.Length; i++)
// {
//   int prefixValue = random.Next(65, 70);
//   string prefix = Convert.ToChar(prefixValue).ToString();
//   string suffix = random.Next(1, 1000).ToString("000");

//   IDs[i] = prefix + suffix;
// }

// foreach (var ID in IDs)
// {
//   Console.WriteLine(ID);
// }

// /*
//   This code reverses a message, counts the number of times 
//   a particular character appears, then prints the results
//   to the console window.
// */

// string originalMessage = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine($"Original message: {originalMessage}");

// char[] message = originalMessage.ToCharArray();
// Console.WriteLine($"Touched message: {new String(message)}");

// Array.Reverse(message);
// Console.WriteLine($"Reversed message: {new String(message)}");

// int letterCount = 0;

// foreach (char letter in message)
// {
//   if (letter == 'o')
//   {
//     letterCount++;
//   }
// }

// string newMessage = new String(message);

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");