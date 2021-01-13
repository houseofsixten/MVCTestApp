using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestApp.Models
{
    public enum OperatorLevel
    {
        Robot = 1,
        Trainee = 2,
        Junior = 3,
        Veteran = 4,
        Senior = 5,
        Elite = 6        
    }

    public enum OperatorClass
    {
        Guard = 1,
        Defender = 2,
        Sniper = 3,
        Caster = 4,
        Medic = 5,
        Supporter = 6,
        Specialist = 7
    }

    public class Employee
    {
        public OperatorLevel Level { get; set; }

        public OperatorClass OperatorClass { get; set; }

        public string CodeName { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public Employee(OperatorLevel level, OperatorClass operatorClass, string codeName, string title, string image)
        {
            Level = level;
            OperatorClass = operatorClass;
            CodeName = codeName;
            Title = title;
            Image = image;
        }
    }
}
