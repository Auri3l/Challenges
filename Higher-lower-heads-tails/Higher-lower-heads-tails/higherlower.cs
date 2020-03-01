using System;

namespace Higher_lower_heads_tails
{
    class higherlower
    {
        static void Main(string[] args)
        {

            /*Higher / lower:
            1.The player one is dealt a card.The player then guesses whether the next card will be higher or lower than the next card.
            If wrong, the player drinks once(because one card was showing).If correct, the player guesses again.
            2.After taking at least three cards, the player may choose to continue or pass. If the player passes, the next player starts where the previous left off.
            3.When a player guesses incorrectly, they drink for each card showing.So, the strategy is to build up a lot of cards and then pass it to the next player.
            4.Before play starts, determine by vote if equal cards are a loss or correct guess.
            Heads / tails:
            As above, save that instead of cards, the guessing is done around coin flips.*/

            // Higher-Lower game, to be commented out after finish.

            Random rand = new Random();
            int card1 = rand.Next(0, 51);
            int card2 = rand.Next(0, 51);
            Console.WriteLine("\n The first card is: " + card1 + "\n Do you think the next one will be (h)igher or (l)ower? \n \n Press h or l to continue:");
            string guess;
            guess = Console.ReadLine();
            }
        }
    }

