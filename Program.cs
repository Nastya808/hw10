using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace hw10
{
    /*
    // клас морська істоти
    public class SeaCreature
    {
        public string Name { get; set; }
        public string Species { get; set; }
    }

    // клас океанаріуму
    public class Oceanarium : IEnumerable<SeaCreature>
    {
        private List<SeaCreature> creatures = new List<SeaCreature>();

        public void AddCreature(string name, string species)
        {
            creatures.Add(new SeaCreature { Name = name, Species = species });
        }

        public IEnumerator<SeaCreature> GetEnumerator()
        {
            return creatures.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main()
        {
            Oceanarium oceanarium = new Oceanarium();

            while (true)
            {
                Console.Write("Введіть ім'я морської істоти (або вийдіть, набравши 'exit'): ");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit")
                    break;

                Console.Write("Введіть вид морської істоти: ");
                string species = Console.ReadLine();

                oceanarium.AddCreature(name, species);
            }

            Console.WriteLine("Морські істоти в Океанаріумі:");
            foreach (SeaCreature creature in oceanarium)
            {
                Console.WriteLine($"Ім'я: {creature.Name}, Вид: {creature.Species}");
            }
        }
    }
    */

    // клас гравця
    public class FootballPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }

    // клас команди
    public class FootballTeam : IEnumerable<FootballPlayer>
    {
        private List<FootballPlayer> players = new List<FootballPlayer>();

        public void AddPlayer(string name, int number)
        {
            players.Add(new FootballPlayer { Name = name, Number = number });
        }

        public IEnumerator<FootballPlayer> GetEnumerator()
        {
            return players.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main()
        {
            FootballTeam team = new FootballTeam();

            while (true)
            {
                Console.Write("Введіть ім'я гравця (або вийдіть, набравши 'exit'): ");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit")
                    break;

                Console.Write("Введіть номер гравця: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    team.AddPlayer(name, number);
                }
                else
                {
                    Console.WriteLine("Некоректний номер гравця. Введіть число.");
                }
            }

            Console.WriteLine("Гравці в Футбольній Команді:");
            foreach (FootballPlayer player in team)
            {
                Console.WriteLine($"Ім'я: {player.Name}, Номер: {player.Number}");
            }
        }
    }
}