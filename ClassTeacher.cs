using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClassTeacher :Teacher
    {
		private CClass _refTeacher;

		public CClass refTeacher
        {
			get { return _refTeacher; }
			set { _refTeacher = value; }
		}


	}
}
