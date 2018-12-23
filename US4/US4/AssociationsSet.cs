using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace US4
{
    public partial class AssociationsSet : Form
    {
        private string codeLine;
        private List<Label> associationTypesLabel = new List<Label>();
        private Point currentWordLocation;
        private string[] wordTypes= { "Variable declaration", "Function declaration", "Variable modificator", "Function modificator", "Content reference", "Operator", "Name" };
        //private ToolStripComboBox wordTypeSelector = new ToolStripComboBox();
        




 


        public AssociationsSet(StreamReader inputDocument, string codeLine)
        {
            
            InitializeComponent();


            CodeLine.Text = codeLine;
            this.codeLine = codeLine;
            //wordTypeSelector.Items.AddRange(wordTypes);
            currentWordLocation = new Point(CodeLine.Location.X, CodeLine.Location.Y+70);
            //wordTypeSelector.Name = "wordTypeSelector";

        }

        private void AssociationsSet_Load(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < codeLine.Split(' ').ToArray().Length; i++)
            {
                Label tmpLabel = new Label();
                tmpLabel.ContextMenuStrip = new ContextMenuStrip();// contextMenuStrip1;
                
                ToolStripComboBox wordTypeSelector = new ToolStripComboBox();
                wordTypeSelector.Name = "wordTypeSelector_" + i;
                wordTypeSelector.Items.AddRange(wordTypes);
                tmpLabel.ContextMenuStrip.Items.Add(wordTypeSelector);
                tmpLabel.Name = "Label_" + i;
                ((ToolStripComboBox)(tmpLabel.ContextMenuStrip.Items.Find("wordTypeSelector",true).First())).SelectedIndexChanged += ChangeFontColor;
                tmpLabel.Text = codeLine.Split(' ').ToArray()[i];
                if (i > 0)
                {
                    currentWordLocation = new Point(currentWordLocation.X + associationTypesLabel[i - 1].Width + 10, currentWordLocation.Y);
                }
                tmpLabel.Location = currentWordLocation;
                this.Controls.Add(tmpLabel);
                associationTypesLabel.Add(tmpLabel);
                
            }
        }
        private void ChangeFontColor(object sender, EventArgs e)
        {
            if(sender)
            string currentIndex = ((Label)sender).Name.Split('_').Last();
            if(((Label)sender).ContextMenuStrip.Items.Find("wordTypeSelector", true).Count()>0)
            {
                switch(((ToolStripComboBox)((Label)sender).ContextMenuStrip.Items.Find("wordTypeSelector",true).First()).SelectedItem)
                {
                    case "Variable declaration":
                        ((Label)sender).ForeColor = Color.Blue;
                        break;
                    case "Function declaration":
                        ((Label)sender).ForeColor = Color.Purple;
                        break;
                    case "Variable modificator":
                        ((Label)sender).ForeColor = Color.Pink;
                        break;
                    case "Function modificator":
                        ((Label)sender).ForeColor = Color.Peru;
                        break;
                    case "Content reference":
                        ((Label)sender).ForeColor = Color.Red;
                        break;
                    case "Operator":
                        ((Label)sender).ForeColor = Color.PowderBlue;
                        break;
                    case "Name":
                        break;
                }

            }
        }
    }
}
