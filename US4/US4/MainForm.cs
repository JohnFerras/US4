using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_StartConvert_Click(object sender, EventArgs e)
        {
            if (rb_LevelConvert.Checked == true)
                LevelConvert();

            if (rb_GameplayConvert.Checked == true)
                GameplayConvert();

            if (rb_MigrateContent.Checked == true)
                ContentMigrate();
        }


        public void LevelConvert()
        {

        }

        public void GameplayConvert()
        {

        }

        public void ContentMigrate()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_SelectUDKPath_Click(object sender, EventArgs e)
        {
            UDKPathBrowser.ShowDialog();
            txtBox_UE3Path.Text = UDKPathBrowser.SelectedPath.ToString();
        }

        private void btn_SelectUE4Path_Click(object sender, EventArgs e)
        {
            UE4PathBrowser.ShowDialog();
            txtBox_UE4Path.Text = UE4PathBrowser.SelectedPath.ToString();
        }
    }
}
