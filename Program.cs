using System;
using System.Collections.Generic;

namespace HeistPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();

            // creating team
            Hacker Steve = new Hacker("Steve", 28, 10);
            LockSpecialist Susan = new LockSpecialist("Susan", 55, 10);
            Muscle Cyborg = new Muscle("Cyborg", 33, 7);
            Hacker Greg = new Hacker("Old Greg", 15, 3);
            LockSpecialist Bill = new LockSpecialist("Bill", 10, 5);
            Muscle Selena = new Muscle("Selena", 40, 10);


            // adding team members to rolodex
            rolodex.Add(Steve);
            rolodex.Add(Susan);
            rolodex.Add(Cyborg);
            rolodex.Add(Greg);
            rolodex.Add(Bill);
            rolodex.Add(Selena);

            bool userAddMember = true;

            while (userAddMember)
            {
                Console.WriteLine("Enter your crew member's name: ");
                string userCrewName = Console.ReadLine();
                if (userCrewName == "")
                {
                    break;
                }
                Console.WriteLine("What would you like your crew member to do? Hacker, Muscle or Lock Specialist: ");
                string userCrewMemberAbility = Console.ReadLine();
                if (userCrewMemberAbility == "")
                {
                    break;
                }

                Console.WriteLine("What would you like their skill level to be? (1-100): ");
                string userMemberSkillLevel = Console.ReadLine();

                if (userMemberSkillLevel == "")
                {
                    break;
                }

                Console.WriteLine("What percentage should their cut be? ");
                string userMemberCut = Console.ReadLine();

                if (userMemberCut == "")
                {
                    break;
                }

                try
                {
                    int skillLevel = Int32.Parse(userMemberSkillLevel);
                    int memberCut = Int32.Parse(userMemberCut);
                    if (userCrewMemberAbility == "Hacker")
                    {
                        Hacker newMember = new Hacker(userCrewName, skillLevel, memberCut);
                    }
                    else if (userCrewMemberAbility == "Muscle")
                    {
                        Muscle newMember = new Muscle(userCrewName, skillLevel, memberCut);
                    }
                    else if (userCrewMemberAbility == "Lock Specialist")
                    {
                        LockSpecialist newMember = new LockSpecialist(userCrewName, skillLevel, memberCut);
                    }
                    else
                    {
                        Console.WriteLine("Ability was not spelled properly");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("There was a problem computing make sure numbers are integers and words are spelled correctly");
                }

                Console.WriteLine("Would you like to add more members (yes or no)? ");
                string addMore = Console.ReadLine();
                if (addMore.ToLower() == "yes")
                {
                    userAddMember = true;
                }
                else if (addMore.ToLower() == "no")
                {
                    userAddMember = false;
                }

            }

            //adding random values to the bank constructor
            Bank bank = new Bank(new Random().Next(50000, 1000000), new Random().Next(1, 101), new Random().Next(1, 101), new Random().Next(1, 101));

            bank.ReconReport();
            bool addingRobber = true;
            List<IRobber> userTeam = new List<IRobber>();
            while (addingRobber)
            {
                int index = 0;
                foreach (IRobber rob in rolodex)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine("index number: " + index++);
                    Console.WriteLine(rob.Name);
                    Console.WriteLine(rob.SkillLevel);
                    Console.WriteLine(rob.PercentageCut);
                    Console.WriteLine(rob.GetType());
                    Console.WriteLine("---------------");

                }

                Console.WriteLine("Enter the index number of the robber you would like to add to your robbery");
                if (Console.ReadLine() == "")
                {
                    break;
                }
                try
                {
                    //this checks to see if index number entered by user is a number
                    //if it is a number then it will be added to the team or throw an error

                    int indexNumber = Int32.Parse(Console.ReadLine());
                    userTeam.Add(rolodex[indexNumber]);

                }
                catch
                {
                    Console.WriteLine("You must enter a valid integer");
                }

                Console.WriteLine("would you like to add more? (yes or no) ");
                string addMore = Console.ReadLine();

                if (addMore.ToLower() == "yes")
                {
                    addingRobber = true;
                }
                else if (addMore.ToLower() == "no")
                {
                    addingRobber = false;
                    break;
                }


            }

        }
    }
}
