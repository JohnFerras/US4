using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US4
{
    public struct AssociationsStruct
    {
        private string includeLibrary;
        public string IncludeLibrary
        {
            get { return includeLibrary; }
            set { includeLibrary = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string _US_Name;
        public string US_Name
        {
            get { return _US_Name; }
            set { _US_Name = value; }
        }

        private string _CPP_Association;
        public string CPP_Association
        {
            get { return _CPP_Association; }
            set { _CPP_Association = value; }
        }

        private string inHeader;
        public string InHeader
        {
            get { return inHeader; }
            set { inHeader = value; }
        }

        private string isChildOf;
        public string IsChildOf
        {
            get { return isChildOf; }
            set { isChildOf = value; }
        }



        public AssociationsStruct(string _includeLibrary, string _type, string __US_Name, string __CPP_Association, string _inHeader, string _isChildOf)
        {
            includeLibrary = _includeLibrary;
            type = _type;
            _US_Name = __US_Name;
            _CPP_Association = __CPP_Association;
            inHeader = _inHeader;
            isChildOf = _isChildOf;
        }
    };
    
    class Structures
    {
        
    }
}
