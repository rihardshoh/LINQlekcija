using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQlekcija
{
    public class Student
    {
        private List<string> _knowledge = new List<string>();
        public string Name { get;set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }

        public bool Attendanced(string subject) // TO DO - implement it
        {
            if (_knowledge.Contains(subject))
            {
                return true;
            }
            else return false;
        }

        public Student()
        {
            _knowledge = new List<string>();
        }

        public Student(List<string> knowledge)
        {
            _knowledge = knowledge;
        }

        public int WriteTest(string subject)
        {
            if (_knowledge.Contains(subject))
            {
                if (subject == "Maths") return 6;
                else if (subject == "Computer science") return 8;
                else return 10;
            }
            return 0;
        }

    }
}