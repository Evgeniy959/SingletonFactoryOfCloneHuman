using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactoryOfCloneHuman
{
    public class FactoryClones
    {
        private static FactoryClones _instance;
        private FactoryClones()
        { }

        public static FactoryClones GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FactoryClones();
            }
            return _instance;
        }

        public string Say(IClone @interface)
        {
            return @interface.Say();
        }
    }
}
