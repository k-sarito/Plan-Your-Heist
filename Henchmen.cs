using System;

namespace Heist
{
    public class Henchmen
    {
        public string Name {get; set;}
        public int SkillLevel {get; set;}
        public double CourageFactor {get;set;}

        public Henchmen (string n, int S, double C)
        {
            Name = n;
            SkillLevel = S;
            CourageFactor = C;
        }
    }
}