string? readResult;

int numericValue = 0;
bool validNumber = false;
Console.WriteLine("Enter an integer value between 5 and 10");
do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    // Console.WriteLine(validNumber);
    // Console.WriteLine(numericValue);
    if (numericValue > 5 && numericValue < 10)
        Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
    else if (numericValue == 0)
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    else
        Console.WriteLine($"You entered {numericValue} Please enter a number between 5 and 10.");

} while (true);
