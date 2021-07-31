using System;
using TheHeist.Team;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.WriteLine("Name your character");
            string teamMemberName = Console.ReadLine();
            Console.WriteLine("Give your character a skill level that is a value between 1-50");
            var teamMemberSkill = Console.ReadLine();
            Console.WriteLine("Give your character a courage level between 0.0 and 2.0");
            var teamMemberCourage = Console.ReadLine();

            var firstTeamMember = new TeamMember(teamMemberName, teamMemberSkill, teamMemberCourage);
        }
    }
}
