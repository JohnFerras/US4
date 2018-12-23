using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;

namespace CodeConverter_Console
{
    class Program
    {
        public struct associationsStruct
        {
            string includeLibrary;
            string type;
            List<string> _US_Names;
            string _CPP_Association;
            string isChildOf;
        };
        public StreamReader inputDocument;
        public StreamWriter outputDocumentH;
        public StreamWriter outputDocumentCpp;
        public OpenFileDialog openFileDialog;
        public List<string> associations;

        static void Main(string[] args)
        {

            OpenFileDialog();
            Console.ReadKey();
        }
        private void OpenFile()
        {

        }
    }
}
