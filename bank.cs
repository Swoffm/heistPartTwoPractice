

namespace HeistPartTwo
{
    class Bank
    {
        int CashOnHand { get; set; }
        int AlarmScore { get; set; }
        int VaultScore { get; set; }
        int SecurityGuardScore { get; set; }
        bool IsSecure
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


    }


}
