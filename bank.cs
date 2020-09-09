using System.Collections.Generic;
using System;

namespace HeistPartTwo
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure
        {
            set
            {
                if (VaultScore > 0 && AlarmScore > 0 && SecurityGuardScore > 0)
                {
                    value = false;
                }
                else
                {
                    value = true;
                }
            }
        }

        public Bank(int cashOnHand, int alarmScore, int vaultScore, int securityGuardScore)
        {
            this.CashOnHand = cashOnHand;
            this.AlarmScore = alarmScore;
            this.VaultScore = vaultScore;
            this.SecurityGuardScore = securityGuardScore;

        }

        public void ReconReport()
        {
            if (this.AlarmScore >= this.SecurityGuardScore && this.AlarmScore >= this.VaultScore)
            {
                Console.WriteLine("Most Secure: Alarm Score");
            }
            else if (this.SecurityGuardScore >= this.AlarmScore && this.SecurityGuardScore >= this.VaultScore)
            {
                Console.WriteLine("Most Secure: Security Guard Score");
            }
            else if (this.VaultScore >= this.AlarmScore && this.VaultScore >= this.SecurityGuardScore)
            {
                Console.WriteLine("Most Secure: Vault Score");
            }


            if (this.AlarmScore <= this.SecurityGuardScore && this.AlarmScore <= this.VaultScore)
            {
                Console.WriteLine("Least Secure: Alarm Score");
            }
            else if (this.SecurityGuardScore <= this.AlarmScore && this.SecurityGuardScore <= this.VaultScore)
            {
                Console.WriteLine("Least Secure: Security Guard Score");
            }
            else if (this.VaultScore <= this.AlarmScore && this.VaultScore <= this.SecurityGuardScore)
            {
                Console.WriteLine("Least Secure: Vault Score");
            }

        }


    }


}
