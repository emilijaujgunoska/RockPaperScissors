Random random = new();
bool tryAgain=true;
String player;
String computer;
String answer;

while (tryAgain)
{
    player = "";
    computer = "";
    answer = "";
    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.WriteLine("Enter ROCK, PAPER or SCISSORS: ");
        player = Console.ReadLine();
        player = player.ToUpper();
    }
    switch(random.Next(1, 4))
    {
            case 1:
            computer = "ROCK";
            break;
            case 2:
            computer = "PAPER";
            break;
            case 3:
            computer = "SCISSORS";
            break;
    }
    Console.WriteLine($"Player: {player}");
    Console.WriteLine($"Computer: {computer}");

    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine(" ITS A DRAW");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("YOU LOSE :( !");
            }
            else
            {
                Console.WriteLine(" YOU WIN :) !");
            }
            break;
        case "PAPER":
            if (computer == "ROCK")
            {
                Console.WriteLine(" YOU WIN :) !");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("ITS A DRAW !");
            }
            else
            {
                Console.WriteLine(" YOU LOSE :( !");
            }
            break;
        case "SCISSORS":
            if (computer == "ROCK")
            {
                Console.WriteLine(" YOU LOSE :( !");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("YOU WIN :) !");
            }
            else
            {
                Console.WriteLine(" ITS A DRAW !");
            }
            break;
    }

    Console.WriteLine("Would you like to play again ? (Y/N)");
    answer = Console.ReadLine();
    answer = answer.ToUpper();

    if (answer == "Y")
    {
        tryAgain = true;
    }
    else
    {
        tryAgain = false;
    }
}

Console.WriteLine("Thanks for playing ! Have a nice day :) ");


