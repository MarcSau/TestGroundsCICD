using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICD_Test.src
{
    internal class Tester
    {
        public bool TestWorkingBehaviours()
        {
            return SystemToTest.Behaviour1();
        }

        public bool TestNoyWorkingBehaviours()
        {
            return SystemToTest.Behaviour2();
        }
    }
}
