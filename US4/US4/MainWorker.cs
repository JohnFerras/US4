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
        //private XElement tmpXElement;
        private string currentLine;
        private AssociationsSet associationsSet;
        private string tmpFormatLine;
        private string currentFormat;

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
        private void AppendNewLine()
        {
            currentLine += " "+ inputDocument.ReadLine();
            LineAnalys(currentLine);
        }
        private void LineAnalys(string line)
        {
            List<string> tmpStringArray = line.Split(' ').ToList<string>();
            string tmpString;
            bool findedInAssociations = false;
            for (int i = 0; i < tmpStringArray.Count; i++)
            {
                if(tmpStringArray[i]=="")
                {
                    tmpStringArray.Remove(tmpStringArray[i]);
                }
                else
                {
                    tmpStringArray[i]=tmpStringArray[i].Trim();
                }
            }

            currentFormat = "";

            for (int i = 0; i < tmpStringArray.Count; i++)
            {
                tmpString = tmpStringArray[0];
                if (i > 0)
                {
                    for (int k = 0; k < i; k++)
                    {
                        tmpString += tmpStringArray[k];
                    }
                }
                foreach (XElement xElem in _XMLAssociations.Root.Elements("DictionaryElem"))
                {
                    if (xElem.Attributes("_US_Name").Count() > 0)
                    {
                        if (xElem.Attribute("_US_Name").Value == tmpString)
                        {
                            findedInAssociations = true;
                            currentFormat += xElem.Attribute("type").Value;
                            break;
                        }
                    }
                }
                if (!findedInAssociations)
                {
                    currentFormat += ">Name?>";
                }
            }
            
            if(currentFormat!="")
            {
                if (currentFormat.Contains(";") || currentFormat.Contains("Class declaration"))
                {
                    uint countInCurrentFormat = 0;
                    uint countInAssociations = 0;
                    foreach (string elem in currentFormat.Split(' '))
                    {
                        if (elem == ">Name?>")
                        {
                            countInCurrentFormat++;
                        }
                    }

                    foreach (XElement elem in _XMLAssociations.Root.Elements("LineFormat").Where(e => e.Attribute("Format").Value.Contains(">Name?>")))
                    {
                        foreach (string elem2 in elem.Attribute("Format").Value.Split(' '))
                        {
                            if (elem2 == ">Name?>")
                            {
                                countInAssociations++;
                            }
                        }
                    }
                    if (countInAssociations != countInCurrentFormat)
                    {
                        associationsSet = new AssociationsSet(line);
                        associationsSet.FormClosed += GetTypesCode;
                        associationsSet.ShowDialog();
                    }
                }
                else
                {

                }
            }
            if (!findedInAssociations)
            {
                associationsSet = new AssociationsSet(line);
                associationsSet.FormClosed += GetTypesCode;
                associationsSet.ShowDialog();

            }
        }
        private void GetTypesCode(Object sender, EventArgs e)
        {
            associationsSet.FormClosed -= GetTypesCode;
            associationsList.Clear();
            associationsList = associationsSet.associationsList;
            WriteInDictionary();
        }
        private void WriteInDictionary()
        {
            tmpFormatLine = "";
            foreach (AssociationsStruct aStruct in associationsList)
            {
                _XMLAssociations.Root.Add(_XMLRequests.F_newXElement("DictionaryElem", new Dictionary<string, string>() { { "includeLibrary", aStruct.IncludeLibrary },
                                                                                                              { "type", aStruct.Type},
                                                                                                              { "_US_Name", aStruct.US_Name},
                                                                                                              { "_CPP_Association", aStruct.CPP_Association},
                                                                                                            { "inHeader", aStruct.InHeader} }));
                tmpFormatLine+=aStruct.Type+" ";
            }

            tmpFormatLine = ">"+tmpFormatLine.Trim();
            _XMLAssociations.Root.Add(new XElement("LineFormat",new XAttribute("Format",tmpFormatLine)));
            _XMLAssociations.Save("XMLAssociations.xml");


        }
    }
}

