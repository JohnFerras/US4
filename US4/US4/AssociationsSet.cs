﻿using System;
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
        private List<ControlLabel> associationTypesLabels = new List<ControlLabel>();
        private Point currentWordLocation;
        //private string[] wordTypes= { "Variable declaration", "Function declaration", "Variable modificator", "Function modificator", "Content reference", "Operator", "Name" };
        //private ToolStripComboBox wordTypeSelector = new ToolStripComboBox();
        private Font codeLineLabels;
        
        public List<associationsStruct> associationsList = new List<associationsStruct>();
        associationsStruct tmpAssociationStruct;






        public AssociationsSet(StreamReader inputDocument, string codeLine)
        {
            
            InitializeComponent();

            codeLineLabels = new Font("Microsoft Sans Serif",15);
            CodeLine.Text = codeLine;
            this.codeLine = codeLine;
            currentWordLocation = new Point(CodeLine.Location.X, CodeLine.Location.Y+70);

        }

        private void AssociationsSet_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < codeLine.Split(' ').ToArray().Length; i++)
            {
                ControlLabel tmpLabel = new ControlLabel();
                tmpLabel.ContextMenuStrip = new ContextMenuStrip();// contextMenuStrip1;
                
                ToolStripComboBox wordTypeSelector = new ToolStripComboBox();
                tmpLabel.Font = codeLineLabels;
                tmpLabel.AutoSize = true;
                tmpLabel.Name = "Label_" + i;
                tmpLabel.Text = codeLine.Split(' ').ToArray()[i];
                if (i > 0)
                {
                    currentWordLocation = new Point(currentWordLocation.X + associationTypesLabels[i - 1].Width + 10, currentWordLocation.Y);
                }
                tmpLabel.Location = currentWordLocation;
                this.Controls.Add(tmpLabel);
                associationTypesLabels.Add(tmpLabel);
            }
        }

        private void AssociationsSet_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (ControlLabel cl in associationTypesLabels)
            {
                tmpAssociationStruct = new associationsStruct();
                associationsList.Add(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class associationsStruct
    {
        string includeLibrary;
        string type;
        string _US_Names;
        string _CPP_Association;
        string inHeader;
        string isChildOf;
        associationsStruct(string includeLibrary, string type, string _US_Names, string _CPP_Association, string inHeader, string isChildOf)
        {
            this.includeLibrary = includeLibrary;
            this.type = type;
            this._US_Names = _US_Names;
            this._CPP_Association = _CPP_Association;
            this.inHeader = inHeader;
            this.isChildOf = isChildOf;
        }
    };
}
