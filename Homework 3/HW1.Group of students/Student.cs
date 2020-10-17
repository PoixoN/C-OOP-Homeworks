using System;
using System.Collections.Generic;
using System.Text;

namespace Test_workspace
{
    abstract class Student
    {
        protected string state;
        protected string name;
        public string Name 
        {
            get { return name; }
        }
        public string State
        {
            get { return state; }
        }

        public Student(string _name)
        {
            name = _name;
        }
        public abstract void Study();
        protected virtual void Read()
        {
            state += " Read ";
        }
        protected virtual void Write()
        {
            state += " Write ";
        }
        protected virtual void Relax()
        {
            state += " Relax ";
        }
    }
}
