using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class SubjectTeacher : Teacher
    {



		private SubjectTeacher _refTeacher;

		public SubjectTeacher refTeacher
        {
			get { return _refTeacher; }
			set { _refTeacher = value; }
		}




	}
}
