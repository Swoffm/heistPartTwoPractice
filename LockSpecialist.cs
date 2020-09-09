using System;

namespace HeistPartTwo

{
    class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int newVaultScore = bank.VaultScore - this.SkillLevel;
            Console.WriteLine($"Robber: Mr. {this.Name}");
            if (newVaultScore > 0)
            {
                Console.Write($"is breaking into the Vault. Decreased Vault Lock to {newVaultScore} points");
            }
            else
            {
                Console.Write("has broken into the Vault!");

            }
        }

        public LockSpecialist(string name, int skillLevel, int percentageCut)
        {
            this.Name = name;
            this.PercentageCut = percentageCut;
            this.SkillLevel = skillLevel;
        }
    }



}