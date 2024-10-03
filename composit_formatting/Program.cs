// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);
// output is  >>> Hello World!

// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);
// output is 
// World Hello!
// Hello Hello Hello!

// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");
// output is 
// Hello World!
// World Hello!
// Hello Hello Hello!

// :C is $
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// this is output >> Price: $123.45 (Save $50.00)

// :N is number
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// output is Measurement: 123,456.79 units

// // :N4 is number 4 digit
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");
// output is >> Measurement: 123,456.7891 units

// :P2 is percent have 2 digit
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");
// output is >> Tax rate: 36.79%

//:C2 is compuund have 2 digit
// decimal price = 67.55m;
// decimal salePrice = 59.99m;
// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
// Console.WriteLine(yourDiscount);

// decimal price = 67.55m;
// decimal salePrice = 59.99m;
// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);
// output is >> You saved $7.56 off the regular $67.55 price. A discount of 11.19%!



// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

string input = "Pad this";  //Padleft
 Console.WriteLine(input.PadLeft(20));

 Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));

string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);