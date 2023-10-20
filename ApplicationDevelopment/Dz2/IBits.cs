using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApplicationDevelopment.Dz2.implicitСast;


namespace ApplicationDevelopment.Dz2
{
    public interface IBits
    {
        bool GetBit(int i);
        void SetBit(bool bit, int index);
    }
}
