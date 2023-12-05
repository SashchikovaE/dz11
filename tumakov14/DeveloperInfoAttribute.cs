using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov14
{
    internal class DeveloperInfoAttribute : Attribute
    {
        public string DeveloperName { get; }
        public string DevelopmentDate { get; }

        public DeveloperInfoAttribute(string developerName, string developmentDate)
        {
            DeveloperName = developerName;
            DevelopmentDate = developmentDate;
        }
    }
}
