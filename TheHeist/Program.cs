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

            var input = true;
            while (input)
            {
                Console.WriteLine("Name your character");
                var teamMemberName = Console.ReadLine();
                
                if (teamMemberName != "")
                {
                    Console.WriteLine("Give your character a skill level that is a value between 1-50");
                    var teamMemberSkill = Console.ReadLine();

                    Console.WriteLine("Give your character a courage level between 0.0 and 2.0");
                    var teamMemberCourage = Console.ReadLine();

                    var teamMember = new TeamMember(teamMemberName, teamMemberSkill, teamMemberCourage);
                    team.Add(teamMember);
                }
                else
                {
                    break;
                }
            }


        }
    }
}
