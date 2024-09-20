// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Strings and Int 
/*string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal Total =0m;
string message = "";
for (int i =0; i< values.Length; i++)
{
    if (decimal.TryParse(values[i], out decimal number))
    {
        
        Total += number;
        
    }
    else
    {
        message +=values[i];
        

    }
}
Console.WriteLine($"message: {message}");
Console.WriteLine($"Total: {Total}");*/

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32(value1/value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
decimal result2 = value2/(decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
float result3 = value3/(float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
