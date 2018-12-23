using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace US4
{
    class MainWorker
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
        //public OpenFileDialog openFileDialog;

        public XMLRequests _XMLRequests = new XMLRequests();
        public XDocument _XMLAssociations;

        public void OpenFile(string fileName)
        {
            //openFileDialog.Filter = "uc files (*.uc)|*.txt|All files (*.*)|*.*";
            //openFileDialog.FilterIndex = 2;
            //openFileDialog.RestoreDirectory = true;
            /*if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
            }*/
            inputDocument = new StreamReader(fileName);
            outputDocumentCpp = new StreamWriter(fileName.Split('.').First() + ".cpp");
            outputDocumentH = new StreamWriter(fileName.Split('.').First() + ".h");
            if (_XMLRequests.LoadXMLDocument("XMLAssociations.xml") != null)
            {
                _XMLAssociations = _XMLRequests.LoadXMLDocument("XMLAssociations.xml");
            }
            else
            {
                _XMLAssociations = new XDocument();
                _XMLAssociations.Add(_XMLRequests.F_newXElement("Root"));
                _XMLAssociations.Root.Add(_XMLRequests.F_newXElement("Variables"));
                _XMLAssociations.Root.Add(_XMLRequests.F_newXElement("Functions"));
                _XMLAssociations.Root.Add(_XMLRequests.F_newXElement("Delegates"));
                _XMLAssociations.Save("XMLAssociations.xml");
            }



        }
    }
}
