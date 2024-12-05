﻿string animalSpecies = "";
        string animalID = "";
        string animalAge = "";
        string animalPhysicalDescription = "";
        string animalPersonalityDescription = "";
        string animalNickname = "";

        // Variables that support data entry
        int maxPets = 8;
        string? readResult;
        string menuSelection = "";

        // Array used to store runtime data
        string[,] ourAnimals = new string[maxPets, 7];  // Increased the column count to 7

        // Create sample data (ourAnimals array entries)
        string suggestedDonation = "";
        decimal decimalDonation = 0.00m;

        for (int i = 0; i < maxPets; i++)
        {
            switch (i)
            {
                case 0:
                    animalSpecies = "dog";
                    animalID = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickname = "lola";
                    suggestedDonation = "85.00";
                    break;

                case 1:
                    animalSpecies = "dog";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                    animalNickname = "gus";
                    suggestedDonation = "49.99";
                    break;

                case 2:
                    animalSpecies = "cat";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "snow";
                    suggestedDonation = "40.00";
                    break;

                case 3:
                    animalSpecies = "cat";
                    animalID = "c4";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "lion";
                    suggestedDonation = "45.00";
                    break;

                default:
                    animalSpecies = "N/A";
                    animalID = "N/A";
                    animalAge = "N/A";
                    animalPhysicalDescription = "N/A";
                    animalPersonalityDescription = "N/A";
                    animalNickname = "N/A";
                    break;
            }

            // Store animal data in array
            ourAnimals[i, 0] = "ID #: " + animalID;
            ourAnimals[i, 1] = "Species: " + animalSpecies;
            ourAnimals[i, 2] = "Age: " + animalAge;
            ourAnimals[i, 3] = "Nickname: " + animalNickname;
            ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

            // Parse donation and handle error cases
            if (!decimal.TryParse(suggestedDonation, out decimalDonation))
            {
                decimalDonation = 45.00m; // Default donation if parsing fails
            }

            ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
        }

        // Display menu and process user selections
        do
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine(" 1. List all of our current pet information");
            Console.WriteLine(" 2. Display all dogs with a specified characteristic");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            switch (menuSelection)
            {
                case "1":
                    // List all pet info
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 0] != "N/A")
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 7; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                        }
                    }
                    Console.WriteLine("\nPress the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "2":
                    // Display all dogs with a specified characteristic
                    string dogCharacteristic = "";

                    while (dogCharacteristic == "")
                    {
                        Console.WriteLine("\nEnter one desired dog characteristic to search for");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            dogCharacteristic = readResult.ToLower().Trim();
                        }
                    }

                    // Loop through the array and search for matching dogs
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 1].Contains("dog") && (ourAnimals[i, 4].Contains(dogCharacteristic) || ourAnimals[i, 5].Contains(dogCharacteristic)))
                        {
                            Console.WriteLine("\nDog found: ");
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                        }
                    }

                    Console.WriteLine("\nPress the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                default:
                    break;
            }

        } while (menuSelection != "exit");