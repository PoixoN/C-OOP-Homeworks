using System;
using System.Collections.Generic;
using System.Text;

namespace Test_workspace
{
    /// <summary>
    /// Наслідує клас Student, перевизначає методи
    /// </summary>
    class GoodStudent : Student
    {
        public GoodStudent(string name) : base(name)
        {
            base.state = "good";
        }

        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }
}
