using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.models
{
    internal class Player
    {
        static int DEFAULT_AGE = 18;
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }


        public Player(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;

        }

        public Player(int id, string name) : this(id, name, DEFAULT_AGE)
        { }

        public static Player WhoIsElder(Player[] players)
        {
            Player elder = players[0];

            foreach (var player in players)
            {
                if (player.Age > elder.Age)
                {
                    elder = player;
                }
            }

            return elder;
        }

    }
}
