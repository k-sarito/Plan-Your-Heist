using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("Name of henchman: ");
            string henchmanName = Console.ReadLine();
            Console.WriteLine($"What is the skill level of {henchmanName}? ");
            string henchmanSkill = Console.ReadLine();
            int parsedSkill = int.Parse(henchmanSkill);
            Console.WriteLine($"Courage factor for {henchmanName}? (0.0-2.0):  ");
            string henchmanCourage = Console.ReadLine();
            double parsedCourage = Double.Parse(henchmanCourage);
            Henchmen newHenchmen = new Henchmen(henchmanName, parsedSkill, parsedCourage);
            Console.WriteLine($"{newHenchmen.Name}: Skill Level = {newHenchmen.SkillLevel} Courage Factor = {newHenchmen.CourageFactor}");

        }
    }
}
