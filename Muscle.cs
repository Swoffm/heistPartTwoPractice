using System;

namespace HeistPartTwo

{
    class Muscle : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int newSecurityGuardScore = bank.AlarmScore - this.SkillLevel;
            Console.WriteLine($"Robber: Mr. {this.Name}");
            if (newSecurityGuardScore > 0)
            {
                Console.Write($"is taking care of the guards. The guard security is now set at {newSecurityGuardScore} points");
            }
            else
            {
                Console.Write("has taken care of the guards!");

            }
        }

        public Muscle(string name, int skillLevel, int percentageCut)
        {
            this.Name = name;
            this.PercentageCut = percentageCut;
            this.SkillLevel = skillLevel;
        }
    }



}