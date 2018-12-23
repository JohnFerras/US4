using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US4
{

    class ControlLabel : Label
    {
        private string[] wordTypes = { "Variable declaration", "Function declaration", "Variable modificator", "Function modificator", "Content reference", "Operator", "Name" };
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.ContextMenuStrip = new ContextMenuStrip();
            ToolStripComboBox wordTypeSelector = new ToolStripComboBox();
            wordTypeSelector.Name = "Test name";
            wordTypeSelector.Items.AddRange(wordTypes);
            this.ContextMenuStrip.Items.Add(wordTypeSelector);
            Parent.Controls.Add(this);
        }

    }
}
