using System;
using System.Collections.Generic;
using System.Text;

namespace Test_workspace
{
    class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {
            base.state = "bad";
        }

        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
    }
}
