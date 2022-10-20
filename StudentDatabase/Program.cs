string[] studentName = { "Ross Geller", "Rachel Green", "Monica Geller", "Chandler Bing", "Joey Tribiani"};
string[] studentHomeTown = { "Newport, MI", "Cleveland, OH", "New York, NY", "New York, NY", "New York, NY" };
string[] favoriteFood = { "The Moistmaker", "Green Tea", "Ice Cream", "Pizza", "MeatBall Sub" };

bool searchAgain = true;
while (searchAgain == true)
{
    Console.WriteLine("Hello, Please enter a students number from 1-5 for more information");
    int userEntry = Convert.ToInt32(Console.ReadLine());

    if (userEntry < 1 || userEntry > studentName.Length)
    {
        Console.WriteLine($"Please enter a number between 1 and {studentName.Length}, program will prompt for another entry \n");
        continue;
    }
    else
    {
        Console.WriteLine($"Students name is {studentName[userEntry - 1]}, would you like to see their hometown or favorite food? enter hometown or food");
        string userSecondChoice = Console.ReadLine().ToLower();
        switch (userSecondChoice)
        {
            case "food":
            case "favorite food":
                { Console.WriteLine($"{studentName[userEntry - 1]}'s favorite food is {favoriteFood[userEntry - 1]}"); }
                break;
            case "hometown":
            case "home town":
            case "home":
                Console.WriteLine($"{studentName[userEntry - 1]}'s hometown is {studentHomeTown[userEntry - 1]}");
                break;
            default:
                Console.WriteLine("That category is not in my databanks, please try again, program will prompt you to start over.");
                continue;
                break;
        }
    }
    Console.WriteLine("Would you like to look up another student? enter y/yes to continue or n/no to quit");
    string goAgain = Console.ReadLine().ToLower();

    switch (goAgain)
    {
        case "y":
        case "yes":
            continue;
            break;
        case "no":
        case "n":
            Console.WriteLine("Thank you for using my student database, have a great day!");
            searchAgain = false;
            break;
        default:
            Console.WriteLine("Please enter either (yes/y) or (no/n)");
            break;
    }
}


