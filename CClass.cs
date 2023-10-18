using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CClass
    {
		public string _name;

		public ClassTeacher refTeacher;
		public List<SubjectTeacher> subjectTeachers;	
		public string name
        {
			get { return _name; }
			set { _name = value; }
		}

        public ClassTeacher _refTeacher
        {
            get { return refTeacher; }
            set { refTeacher = value; }
        }

        public List<SubjectTeacher> SubjectTeachers
        {
            get { return subjectTeachers; }
            set { subjectTeachers = value; }
        }




    }
}
