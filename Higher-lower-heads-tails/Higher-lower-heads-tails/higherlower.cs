using System;

namespace Higher_lower_heads_tails
{
    class higherlower
    {
        static void Main(string[] args)
        {

            /*Higher / lower:
1.The player one is dealt a card.The player then guesses whether the next card will be higher or lower than the next card.If wrong, the player drinks once(because one card was showing).If correct, the player guesses again.
2.After taking at least three cards, the player may choose to continue or pass. If the player passes, the next player starts where the previous left off.
3.When a player guesses incorrectly, they drink for each card showing.So, the strategy is to build up a lot of cards and then pass it to the next player.
4.Before play starts, determine by vote if equal cards are a loss or correct guess.
Heads / tails:
As above, save that instead of cards, the guessing is done around coin flips.*/

            var player1 = 1;
            var player2 = 2;
            player1 = 1;
            player2 = 2;
            Console.WriteLine(player1 + player2);
        }
    }
}
