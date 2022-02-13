using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQlekcija
{
    class CompareStudents: StudentComparer
    {
        public string Name;
        public int Id;

        public CompareStudents(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public override bool Equals(object obj)
        {
            CompareStudents compareStudents = (CompareStudents)obj;   
            if (this.Id == compareStudents.Id && this.Name.ToLower() == compareStudents.Name.ToLower())
            {
                return true;
            }

            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
