using System;
using System.Collections.Generic;
using TheHeist.Team;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            var team = new List<TeamMember>();
            var bankDifficulty = 0;

            var bankInput = true;
            Console.WriteLine("Please enter a Bank Difficulty Level between 20-150");
            while (bankInput)
            {
                bankDifficulty = Int32.Parse(Console.ReadLine());
                if (bankDifficulty > 150 || bankDifficulty < 20)
                {
                    Console.WriteLine("Not a valid input. Enter a number between 20-150");
                }
                else
                {
                    bankInput = false;
                }
            }

            Console.WriteLine("How many times would you like to attempt the heist? Please enter a reasonable number.");

            var numberOfRuns = Int32.Parse(Console.ReadLine());
           
            var input = true;
            while (input)
            {
                Console.WriteLine("Name your character");
                var teamMemberName = Console.ReadLine();
                
                if (teamMemberName != "")
                {
                    Console.WriteLine("Give your character a skill level that is a value between 1-50");
                    var teamMemberSkill = Console.ReadLine();

                    Console.WriteLine("Give your character a courage level between 0.0 and 2.0.");
                    var teamMemberCourage = Console.ReadLine();

                    Console.WriteLine("If you are done assembling your team, please press enter.");

                    var teamMember = new TeamMember(teamMemberName, teamMemberSkill, teamMemberCourage);
                    team.Add(teamMember);
                    
                }
                else
                {
                    input = false;
                }
            }

            var teamSkill = 0;

            foreach (TeamMember member in team)
            {
                teamSkill += member.SkillLevel;
            }

            teamSkill /= team.Count;

            var successes = 0;
            var failures = 0;
            var rnd = new Random();

            for (var i = 0; i < numberOfRuns; i++)
            {
                var luckVal = rnd.Next(-20, 20);
                bankDifficulty += luckVal;
                Console.WriteLine($"heist {i} had a difficulty of {bankDifficulty}");
                if (teamSkill < bankDifficulty)
                {
                    failures++;
                }
                else
                {
                    successes++;
                }

            }

            Console.WriteLine("REPORT ///////////////////////////////////////");
            var teamSize = team.Count;
            Console.WriteLine($" Number of team members: {teamSize}");
            Console.WriteLine($"Your team skill level was {teamSkill}");
            Console.WriteLine($"Your team members:");
            foreach (TeamMember mem in team)
            {
                Console.WriteLine($"{mem.Name}");
            }

            Console.WriteLine($"you successfully completed {successes} heists");
            Console.WriteLine($"you failed at {failures} heists");
            
            if (successes > failures)
            {
                Console.WriteLine("Enjoy your money");
            }
            else
            {
                Console.WriteLine("Have fun in jail");
            }
        }
    }
}
