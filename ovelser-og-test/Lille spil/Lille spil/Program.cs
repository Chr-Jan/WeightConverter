namespace Lille_spil
{
        internal class Program
        {
            static void Main(string[] args)
            {
                // hero and monster each have 10hp (health)
                int hero = 10;
                int monster = 10;
                
                // Create a relation between the word "dice" and the function Random...
                Random dice = new Random();
            

                do
                {
                    // (1, 11) because c# start at 0, so the readl value is 0, 10.
                    int roll = dice.Next(1, 11);
                    // -= means it was substract the roll from the monsters health, so (monsters health 10 minus roll number).
                    monster -= roll;
                    // {roll} will display the number that is used to subtract from monsters health, and {monster} show te monsters health
                    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");
                    // meaning if the monster have more than 0 health the game contuines.
                    if (monster <= 0) continue;

                    roll = dice.Next(1, 11);
                    hero -= roll;
                    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
                // the code block stop when either the hero or monster health is less than 0, making the while false.
                } while (hero > 0 && monster > 0);

                Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

                Console.ReadLine();
               
            }
        }
    
}
    
