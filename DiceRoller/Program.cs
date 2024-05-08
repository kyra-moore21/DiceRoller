
//main code
do
{
    int roll = Welcome();
    int dice1 = diceRoll(roll);
    int dice2 = diceRoll(roll);
    Console.WriteLine($"Roll One: {dice1} Roll Two: {dice2} Total: {dice1 + dice2}");
    if (roll == 6)
    {
        Console.WriteLine(Combos(dice1, dice2));
        Console.WriteLine(WinOrLose(dice1, dice2));
    }
} while (runProgram());



//methods
//sides of dice
static int Welcome()
{
    Console.WriteLine("Welcome to the Dice Roller.");
    Console.WriteLine("How many sides would you like your dice to be?");
    
    int dice = 0;
    while (!int.TryParse(Console.ReadLine(), out dice))
    {
        Console.WriteLine( "Input must be a number. Try Again");
    }
    return dice;
}

//random number
static int RandomNum(int input)
{
    Random rand = new Random();
    return rand.Next(1, input + 1);
}

//diceroll
static int diceRoll(int dice1)
{
  return RandomNum(dice1);
}

//combinationcheck
static string Combos(int dice1, int dice2)
{ 

    //wanted to pratice converting to switch statement
    switch (dice1, dice2)
    {
        case (1, 1):
            return "Snake Eyes: Two 1s";
            break;
        case (2, 1):
            return "Ace Deuce: A 1 and 2";
            break;
        case (1, 2):
            return "Ace Deuce: A 1 and 2";
            break;
        case (6, 6):
            return "Box Cars: Two 6s";
            break;
        default:
            return "";
            break;
    }
    //if (dice1 == 1 && dice2 == 1)
    //{
    //    return "Snake Eyes: Two 1s";
    //} else if (dice1 == 1 && dice2 ==2 || dice2 == 1 && dice1  == 2)
    //{
    //    return "Ace Deuce: A 1 and 2";
    //} else if (dice1 ==6 && dice2 == 6)
    //{
    //    return "Box Cars: Two 6s";
    //} else
    //{
    //    return "";
    //}
}

//win or lose check
static string WinOrLose(int dice1, int dice2)
{
    if(dice1 + dice2 == 7 || dice1 + dice2 == 11) {
        return "Win: A total of 7 or 11";
    } else if (dice1 + dice2 == 2 || dice1 +dice2 == 3 || dice1 + dice2 == 12)
    {
       return "Craps: A total of 2, 3, or 12";
    } else
    {
        return "";
    }
}

//loopprogram
static bool runProgram()
{
    while (true) {
        Console.WriteLine("Would you like to roll again? y/n");
        string choice = Console.ReadLine();
        if (choice == "y")
        {
            return true;
        } else if (choice == "n")
        {
            return false;

        } else
        {
            Console.WriteLine("Invalid Input, try again.");

        }
    }
    
    }
   



