string? readResult;
bool validEntry = false;
// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);