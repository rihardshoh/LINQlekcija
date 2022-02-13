using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQlekcija
{
    class StudentComparer : IEqualityComparer<Student>
    {
        public virtual bool Equals(Student x, Student y)
        {
            if (x.Id == y.Id && x.Name.ToLower() == y.Name.ToLower())
            {
                return true;
            }

            return false;
        }
        public virtual int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }

}
