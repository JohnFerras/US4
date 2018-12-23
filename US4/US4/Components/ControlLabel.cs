using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace US4
{

    class ControlLabel : Label
    {
        public string currentType;
        private string[] wordTypes = { "Variable declaration", "Function declaration", "Variable modificator", "Function modificator", "Content reference", "Operator", "Name" };
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.ContextMenuStrip = new ContextMenuStrip();
            ToolStripComboBox wordTypeSelector = new ToolStripComboBox();
            wordTypeSelector.Name = "wordTypeSelector_";
            wordTypeSelector.Items.AddRange(wordTypes);
            this.ContextMenuStrip.Items.Add(wordTypeSelector);
            wordTypeSelector.SelectedIndexChanged += ChangeFontColor;
            Parent.Controls.Add(this);
            
        }
        protected void ChangeFontColor(Object sender, EventArgs e)
        {
            
                string currentIndex = ((ToolStripComboBox)sender).Name.Split('_').Last();
                currentType = ((ToolStripComboBox)sender).SelectedItem.ToString();
                switch (currentType)
                {
                    case "Variable declaration":
                        this.ForeColor = Color.Blue;
                        break;
                    case "Function declaration":
                        this.ForeColor = Color.Purple;
                        break;
                    case "Variable modificator":
                        this.ForeColor = Color.Pink;
                        break;
                    case "Function modificator":
                        this.ForeColor = Color.Peru;
                        break;
                    case "Content reference":
                        this.ForeColor = Color.Red;
                        break;
                    case "Operator":
                        this.ForeColor = Color.PowderBlue;
                        break;
                    case "Name":
                        break;
                }

            
        }

    }
}
