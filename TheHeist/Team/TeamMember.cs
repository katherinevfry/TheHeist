using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist.Team
{
    class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        public TeamMember(string name, string skillLevel, string courageFactor)
        {
            Name = name;
            SkillLevel = Int32.Parse(skillLevel);
            CourageFactor = Decimal.Parse(courageFactor);
            Console.WriteLine($" Name: {Name}");
            Console.WriteLine($"Skill Level: {SkillLevel}");
            Console.WriteLine($"Courage Factor: {CourageFactor}");
            Console.WriteLine($"---------------------------------");
        }

     }
 }
