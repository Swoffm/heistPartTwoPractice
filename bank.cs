

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


    }


}
