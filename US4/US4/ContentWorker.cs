using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace US4
{
    public class ContentWorker
    {
        public MainForm globalForm;
        private StreamReader inputDocument;

        public void Init(string fileName = "")
        {
            List<string> PackagesToMigrate = new List<string>();
            globalForm.PrintLog("---CONTENT MIGRATION STARTS---");

            inputDocument = new StreamReader(fileName);
            string[] result = File.ReadAllLines(fileName);
            List<string> AllLines = result.ToList();
            int localAmount = 0;
            foreach (string line in AllLines)
            {
                
                if(line.Contains("StaticMesh=StaticMesh'"))
                {
                    localAmount++;
                    string toClear = line.Between(line.Between("StaticMesh=StaticMesh'", "."), "'");
                    string PackageName = line.Between("StaticMesh=StaticMesh'", ".");
                    string[] param = line.Split('.');
                    PackageName = param[0].After("StaticMesh=StaticMesh'");

                    if(!PackagesToMigrate.Contains(PackageName))
                        PackagesToMigrate.Add(PackageName);
                }
            }

            /*
             *  PACKAGES FOUND
             */

            foreach (string package in PackagesToMigrate)
            {
                globalForm.PrintLog("Package to export found " + package);
            }

            if (PackagesToMigrate.Count <= 0)
                globalForm.PrintLog("No packages to export");




        }
    }
}
