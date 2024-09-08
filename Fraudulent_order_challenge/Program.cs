string[] array = ["B123",
"C234",
"A345",
"C15",
"B177",
"G3003",
"C235",
"B179"];

int i =0;

foreach (string items in array)
{
    if (items.StartsWith("B"))
    {
        Console.WriteLine($" \"{items}\" starts with 'B'!");
    }
}