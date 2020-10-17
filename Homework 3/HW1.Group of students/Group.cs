using System;
using System.Collections.Generic;
using System.Text;

namespace Test_workspace
{
    class Group
    {
        string name;
        List<Student> students = new List<Student>();
        
        public Group(string _name) 
        {
            name = _name;
        }

        public void AddStudent(Student st)
        {
            students.Add(st);
        }
        public void AddGroupStudents(Group gr)
        {
            foreach (Student st in gr.students)
            {
                this.students.Add(st);
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($" {name}");
            foreach (Student st in students)
            {
                Console.WriteLine($"    {st.Name}");
            }
        }
        public void GetFullInfo()
        {
            Console.WriteLine($" {name}");
            foreach (Student st in students)
            {
                Console.WriteLine($"    {st.Name} - {st.State}");
            }            
        }
    }
}
