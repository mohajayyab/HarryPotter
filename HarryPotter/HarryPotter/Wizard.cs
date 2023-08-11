using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     public class Wizard
    {
        static Random RNG = new Random();

        public string Name { get; set; }
        public int Courage { get; set; }
        public int Intelligence { get; set; }
        public int Perseverance { get; set; }
        public int Cunning { get; set; }

        public Wizard(string name, int courage, int intelligence, int perseverance, int cunning)
        {
            Name = name;
            Courage = courage;
            Intelligence = intelligence;
            Perseverance = perseverance;
            Cunning = cunning;
        }
        public Wizard()
        {
        }
        public  List<Wizard> GenerateRandomWizard(int size)
        {
            List<Wizard> wizardList = new List<Wizard>();
            string[] firstName = { "Sophie", "Maximus", "Luna", "Felix", "Aria", "Leo", "Eva",
            "Gabriel", "Isaac", "Eleanor", "Nathan", "Grace", "Lucy", "Adam", "Penelope", "Samuel",
            "Olivia", "Ethan", "Emily", "Henry", "Chloe", "Julian", "Victoria", "Daniel", "Zoe", "Caleb", "Nora", "Sarah" };
            string[] lastName = { "Walker", "Roberts", "Mitchell", "Carter", "Baker", "Turner", "Perez",
            "Campbell", "Wood", "Kelly", "Edwards", "Price", "Harris", "Rivera", "Rogers", "Reed",
            "Morgan", "Howard", "Stewart", "Parker", "Gray", "Bell", "Cook", "Long", "Ramirez", "Cox", "Foster" };


            for (int i = 0; i < size; i++)
            {
                string fullName = firstName[RNG.Next(firstName.Length)] + " " + lastName[RNG.Next(lastName.Length)];
                Wizard newPlayer = new Wizard(fullName, RNG.Next(1, 11), RNG.Next(1, 11), RNG.Next(1, 11), RNG.Next(1, 11));
                wizardList.Add(newPlayer);
            }

            return wizardList;
        }

    }
}
