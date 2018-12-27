using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace US4
{
    class XMLRequests
    {
        public XDocument LoadXMLDocument(string xDocumentPath)
        {
            try
            {
                XDocument _xDocument = XDocument.Load(xDocumentPath);
                return _xDocument;
            }
            catch
            {
                return null;
            }
        }
        public XElement FindXNodes(XDocument _XDocument, string XNodeName)
        {
            return null;
        }
        

        public XElement F_newXElement(string elemName,Dictionary<string,string> attributes = null)
        {
            
                XElement newXElement = new XElement(elemName);
                if (attributes != null)
                {
                    foreach (var param in attributes)
                    {
                        newXElement.Add(new XAttribute(param.Key, param.Value));
                    }
                }
                return newXElement;
            
        }

        


        public XDocument XMLExamples()
        {
            return new XDocument();
        }
    }
}
