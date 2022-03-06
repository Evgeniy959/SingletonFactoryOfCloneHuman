using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactoryOfCloneHuman
{
    public interface IHuman : ICloneable
    {
        string Name { get; set; }
        int Age { get; set; }
    }
}
