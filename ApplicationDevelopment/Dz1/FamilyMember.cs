using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopment.NewFolder
{
    public enum Gender
    {
        Male,
        Female
    }

    public class FamilyMember
    {
        public string Name { get; set; }
        public Gender gender { get; set; }
        public FamilyMember spouse { get; set; }
        public List<FamilyMember> children { get; set; }

        public FamilyMember(string name, Gender gender, FamilyMember spouse)
        {
            Name = name;
            this.gender = gender;
            this.spouse = spouse;
            children = new List<FamilyMember>();


        }
    }
}
