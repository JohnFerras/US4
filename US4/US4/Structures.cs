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
        private string type;
        private string _US_Name;
        private string _CPP_Association;
        private string inHeader;
        private string isChildOf;
        
        public AssociationsStruct(string _includeLibrary, string _type, string __US_Name, string __CPP_Association, string _inHeader, string _isChildOf)
        {
            includeLibrary = _includeLibrary;
            type = _type;
            _US_Name = __US_Name;
            _CPP_Association = __CPP_Association;
            inHeader = _inHeader;
            isChildOf = _isChildOf;
        }

        public string IncludeLibrary
        {
            get
            {
                if (includeLibrary != null)
                    return includeLibrary;
                else
                    return "";
            }
            set { includeLibrary = value; }
        }
        public string Type
        {
            get
            {
                if (type != null)
                    return type;
                else
                    return "";
            }
            set { type = value; }
        }
        public string US_Name
        {
            get
            {
                if (_US_Name != null)
                    return _US_Name;
                else
                    return "";
            }
            set { _US_Name = value; }
        }
        public string CPP_Association
        {
            get
            {
                if (_CPP_Association != null)
                    return _CPP_Association;
                else
                    return "";
            }
            set { _CPP_Association = value; }
        }
        public string InHeader
        {
            get
            {
                if (inHeader != null)
                    return inHeader;
                else
                    return "";
            }
            set { inHeader = value; }
        }
        public string IsChildOf
        {
            get
            {
                if (isChildOf != null)
                    return isChildOf;
                else
                    return "";
            }
            set { isChildOf = value; }
        }
    };
    
    
    
}
