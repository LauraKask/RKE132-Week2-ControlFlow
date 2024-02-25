// See https://aka.ms/new-console-template for more information

// rakendus küsib kasutajalt sisestada oma vanuse
//kui kasutaja vanus on väiksem kui 13 siis konsoolis kuvatakse: 
//"You are to young"
//muul juhul konsoolis kuvatakse "You are welcome"


Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
Console.WriteLine ($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram");
    }
    else
    {
        Console.WriteLine("You are too young!!");
    }
}
else
{
    Console.WriteLine("Could not read your age!");
}
