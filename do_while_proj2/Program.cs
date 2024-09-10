string? useroriginal;
string? userconv;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    useroriginal = Console.ReadLine().Trim();
    userconv = useroriginal.ToLower();
    if (userconv == "administrator")
    {
        Console.WriteLine($"Your input value ({useroriginal}) has been accepted.");
        break;
    }

    else if (userconv == "manager")
    {
        Console.WriteLine($"Your input value ({useroriginal}) has been accepted.");
        break;
    }
    else if (userconv == "user")
    {
        Console.WriteLine($"Your input value ({useroriginal}) has been accepted.");
        break;
    }
    else
        Console.WriteLine($"The role name that you entered, \"{useroriginal}\" is not valid. Enter your role name (Administrator, Manager, or User)");

} while (true);

//This is Solution
/*
string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
*/