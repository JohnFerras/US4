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

        public void AdditionalSettings(bool Set)
        {
            cb_OnlyNeededByLevel.Visible = Set;
            txt_LevelFilePath.Visible = Set;
        }

        public void PrintLog(string Param)
        {
            rtb_Log.Text += Param;
            rtb_Log.Text += Environment.NewLine;
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
            PrintLog("---GAMEPLAY MIGRATION STARTS---");

            MainWorker newWorker = new MainWorker();
            newWorker.globalForm = this;
            newWorker.OpenFile("PKPawn.uc");

        }

        public void ContentMigrate()
        {
            ContentWorker newWorker = new ContentWorker();
            newWorker.globalForm = this;
            rtb_Log.Text = "";
            newWorker.Init(fd_OpenLevelFile.FileName);
            

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

        private void rb_MigrateContent_CheckedChanged(object sender, EventArgs e)
        {
            
            if(rb_MigrateContent.Checked)
            {
                AdditionalSettings(true);
            }
            else
            {
                AdditionalSettings(false);
            }
        }

        private void txt_LevelFilePath_MouseClick(object sender, MouseEventArgs e)
        {

            fd_OpenLevelFile.ShowDialog();
        }

        private void cb_OnlyNeededByLevel_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_OnlyNeededByLevel.Checked)
                txt_LevelFilePath.Enabled = true;
            else
                txt_LevelFilePath.Enabled = false;
        }

        private void fd_OpenLevelFile_FileOk(object sender, CancelEventArgs e)
        {
            txt_LevelFilePath.Text = fd_OpenLevelFile.FileName;
        }
    }
}
