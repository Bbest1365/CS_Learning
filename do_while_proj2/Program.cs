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
