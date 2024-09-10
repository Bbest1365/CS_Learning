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

//This is solution

/*string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
*/