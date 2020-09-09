using System;

namespace HeistPartTwo

{
    class Hacker : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int newAlarmScore = bank.AlarmScore - this.SkillLevel;
            Console.WriteLine($"Robber: Mr. {this.Name}");
            if (newAlarmScore > 0)
            {
                Console.Write($"is hacking the alarm system. Decreased security {newAlarmScore} points");
            }
            else
            {
                Console.Write("has disabled the alarm system!");

            }
        }

        public Hacker(string name, int skillLevel, int percentageCut)
        {
            this.Name = name;
            this.PercentageCut = percentageCut;
            this.SkillLevel = skillLevel;
        }
    }



}