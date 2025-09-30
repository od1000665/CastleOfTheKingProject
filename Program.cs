/* In the Castle of The King Program
Created by: Owen Douglas
A small mini game prompting you to guess doors in order to find the king, treasure or be eaten by a dragon
*/

//Intro

Console.WriteLine("Welcome to the castle, find the king");
Console.WriteLine("BUT beware of the dragon!");
//Spacing
Console.WriteLine("");

//Will make the random number varible 
Random random = new Random();

//While Loop to keep the game running
while (true)
{
    //Door score
    int doorsOpened = 0;
    while (true)
    {
        //Ask player to choose a number 1-3
        Console.WriteLine("Choose between door 1, 2, or 3");
        int choice = Convert.ToInt32(Console.ReadLine());
        //Add doors opened
        doorsOpened++;
        //will randomize the choice
        int contents = random.Next(1, 4);
        //King statement
        if (contents == 3)
        {
            Console.WriteLine("You found the king, you win!");
            Console.WriteLine("You opened:" + doorsOpened + "door(s)");
            break;
        }
        //Dragon statement
        else if (contents == 1)
        {
            Console.WriteLine("The dragon has eaten you: GAME OVER");
            break;
        }
        //Treasure Statement
        else
        {
            Console.WriteLine("You found the treasure, now find the king!");
            Console.WriteLine("You've opened:" + doorsOpened + "door(s)");
        }
    }
    //Ask to play again
    Console.WriteLine("Play again? y/n");
    string gameLoop = Console.ReadLine();

    if (gameLoop == "n")
    {
        Console.WriteLine("Thanks for playing");
    }
}


//End