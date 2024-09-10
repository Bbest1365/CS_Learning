using System;

class Program
{
    static void Main()
    {
        string[] myStrings = new string[2]
        {
            "I like pizza. I like roast chicken. I like salad",
            "I like all three of the menu choices"
        };

        string word = "";
        int index = 0; // Initialize index for the do-while loop

        do
        {
            string str = myStrings[index]; // Get the current string

            // Split the string at each period
            string[] segments = str.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string segment in segments)
            {
                // Trim any leading or trailing whitespace and append to word
                word += $"{segment.Trim()}\n";
            }

            index++; // Move to the next string

        } while (index < myStrings.Length); // Continue until all strings are processed

        Console.WriteLine(word);
    }
}

// This is Solution
/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
*/