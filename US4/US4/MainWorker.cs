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
        public MainForm globalForm;
        private List<AssociationsStruct> associationsList = new List<AssociationsStruct>();
        private StreamReader inputDocument;
        private StreamWriter outputDocumentH;
        private StreamWriter outputDocumentCpp;
        //public OpenFileDialog openFileDialog;

        private XMLRequests _XMLRequests = new XMLRequests();
        private XDocument _XMLAssociations;
        private XElement tmpXElement;
        private string currentLine;
        private AssociationsSet associationsSet;

        public void OpenFile(string fileName)
        {
            globalForm.PrintLog("Gameplay: Reading file " + fileName);
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
                _XMLAssociations.Save("XMLAssociations.xml");
            }
            CodeReading();



        }
        private void CodeReading()
        {
            if ((currentLine = inputDocument.ReadLine()) != null)
            {
                LineAnalys(currentLine);
            }

        }
        private void LineAnalys(string line)
        {
            string[] tmpStringArray = line.Split(' ');
            string tmpString;
            bool findedInAssociations = false;
            for (int i = 0; i < tmpStringArray.Length; i++)
            {
                tmpString = tmpStringArray[0];
                if (i > 0)
                {
                    for (int k = 0; k < i; k++)
                    {
                        tmpString += tmpStringArray[k];
                    }
                }
                foreach (XElement xElem in _XMLAssociations.Root.Elements())
                {
                    if (xElem.Attributes("inText").Count() > 0)
                    {
                        if (xElem.Attribute("inText").Value == tmpString)
                        {
                            findedInAssociations = true;
                        }
                    }
                }
            }
            if (!findedInAssociations)
            {
                associationsSet = new AssociationsSet(inputDocument, line);
                associationsSet.FormClosed += GetTypesCode;
                associationsSet.ShowDialog();

            }
        }
        private void GetTypesCode(Object sender, EventArgs e)
        {
            associationsList.Clear();
            associationsList = associationsSet.associationsList;
            WriteInDictionary();
        }
        private void WriteInDictionary()
        {
            foreach (AssociationsStruct aStruct in associationsList)
            {
                tmpXElement = _XMLRequests.F_newXElement("DictionaryElem", new Dictionary<string, string>() { { "includeLibrary", aStruct.IncludeLibrary },
                                                                                                              { "type", aStruct.Type},
                                                                                                              { "_US_Name", aStruct.US_Name},
                                                                                                              { "_CPP_Association", aStruct.CPP_Association},
                                                                                                              { "inHeader", aStruct.InHeader} });
            }


        }
    }
}

