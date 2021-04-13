using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro1
{
    public class Globals
    {
        private static string _strSubjectId;
        public static string strSubjectId
        {
            get
            {
                return _strSubjectId;
            }
            set
            {
                _strSubjectId = value;
            }
        }
    }
}
