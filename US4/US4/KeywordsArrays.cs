using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US4
{
    public class KeywordsArrays
    {
        private string[] wordTypes = { "Variable declaration",
                                       "Function declaration",
                                       "Variable modificator",
                                       "Function modificator",
                                       "Line end",
                                       "Content reference",
                                       "Operator",
                                       "Name",
                                       "Class declaration",
                                       "Extends operator" };

        public string[] WordTypes()
        {
            return wordTypes;
        }

    }
}
