using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopment.NewFolder
{
    public class Child : FamilyMember
    {
        public Child(string name, Gender gender, FamilyMember parents) : base(name, gender, parents)
        {

        }
    }
}
