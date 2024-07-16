using PlayerApp.models;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player[] players = new Player[]{
                new Player(101, "Swati", 30),
                new Player(102, "Roshani", 40),
                new Player(103, "Shweta", 20),
                new Player(104, "Sampada", 35),
                new Player(105, "Swamini", 25)
            };

            Player eldestPlayer = Player.WhoIsElder(players);
            Console.WriteLine($"The oldest player in the group is: {eldestPlayer.Name} " +
                $"& age is: {eldestPlayer.Age}");

        }
    }
}
