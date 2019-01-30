using ClamAV.Managed;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Webblock_AV.Helper;

namespace Webblock_AV
{
    public partial class Main : Form
    {
        private List<string> ExpandedNode = new List<string>();
        private List<string> subDir = new List<string>();
        private ClamEngine clamAV;
        private List<string> selectedDir = new List<string>();
        private Thread threadScan;

        private List<string> files = new List<string>();
        private int Selected;

        public Main()
        {
            InitializeComponent();
            clamAV = new ClamEngine();
            Text = Text + " ClamAV Engine Version : " + ClamEngine.Version;
            Icon = SystemIcons.Shield;
            Thread SetupThread = new Thread(() =>
            {
                try
                {
                    clamAV.LoadDatabase(AppDomain.CurrentDomain.BaseDirectory + @"\database\main.cvd", LoadOptions.OfficialOnly);
                }
                catch (Exception ex)
                {
                    if (InvokeRequired)
                    {
                        Text = "Failed to load signature";
                    }
                }
            });
            SetupThread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Intialize

            Selected = 1;
            CheckSelected();
            GetDrives();
            CustomColor();

            #endregion Intialize

            ApplyShellIcon();
            GetAllDirectories();
            treePath.Nodes[0].Expand();
        }

        #region GetShellIcon

        private void ApplyShellIcon()
        {
            ShellImageList.Images.Add(ShellIcon.GetIcon(15)); //PC Icon
            ShellImageList.Images.Add(ShellIcon.GetIcon(8)); //HDD Icon
            ShellImageList.Images.Add(ShellIcon.GetIcon(3)); //Folder Icon

            //now apply icon
            treePath.Nodes[0].SelectedImageIndex = 0;
            treePath.Nodes[0].ImageIndex = 0;

            for (int i = 0; i <= treePath.Nodes[0].Nodes.Count - 1; i++)
            {
                var n = treePath.Nodes[0].Nodes[i];
                n.ImageIndex = 1;
                n.SelectedImageIndex = 1;
            }
        }

        #endregion GetShellIcon

        #region PopulateTreeOnLoad

        private void GetAllDirectories()
        {
            foreach (TreeNode node in treePath.Nodes[0].Nodes)
            {
                foreach (string dirNode in Directory.GetDirectories(node.Name))
                {
                    var n = node.Nodes.Add(new DirectoryInfo(dirNode).Name);
                    n.Name = dirNode;
                    n.SelectedImageIndex = 2;
                    n.ImageIndex = 2;
                }
            }
        }

        #endregion PopulateTreeOnLoad

        #region PopulateTree

        private void GetDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady == true)
                {
                    treePath.Nodes[0].Nodes.Add(drive.VolumeLabel + " (" + drive.Name + ")").Name = drive.Name;
                }
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (!(e.Node.Text.Contains("This PC")))
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    try
                    {
                        foreach (string dir in Directory.GetDirectories(node.Name))
                        {
                            var n = node.Nodes.Add(new DirectoryInfo(dir).Name);
                            n.Name = dir;
                            n.SelectedImageIndex = 2;
                            n.ImageIndex = 2;
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        #endregion PopulateTree

        #region BtnTab

        private void BtnDashBoard_Click(object sender, EventArgs e)
        {
            PanelSelector.Location = new Point(0, BtnDashBoard.Location.Y);
            Selected = 1;
            IsChild(false);
            CheckSelected();
            TabMain.SelectedTab = TabDashboard;
        }

        private void BtnProtection_Click(object sender, EventArgs e)
        {
            PanelSelector.Location = new Point(0, BtnProtection.Location.Y);
            Selected = 2;
            IsChild(false);
            CheckSelected();
            TabMain.SelectedTab = TabProtection;
        }

        private void BtnScanner_Click(object sender, EventArgs e)
        {
            PanelSelector.Location = new Point(0, BtnScanner.Location.Y);
            Selected = 3;
            IsChild(false);
            CheckSelected();
            TabMain.SelectedTab = TabScanner;
        }

        private void BtnUpdates_Click(object sender, EventArgs e)
        {
            PanelSelector.Location = new Point(0, BtnUpdates.Location.Y);
            Selected = 4;
            IsChild(false);
            CheckSelected();
            TabMain.SelectedTab = TabUpdates;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PanelSelector.Location = new Point(0, BtnSettings.Location.Y);
            Selected = 5;
            IsChild(false);
            CheckSelected();
            TabMain.SelectedTab = TabSettings;
        }

        private void BtnTabSelective_Click(object sender, EventArgs e)
        {
            PanelSelector.Location = new Point(0, BtnTabSelective.Location.Y);
            IsChild(true);
            TabMain.SelectedTab = TabSelective;
            Selected = 9;
            CheckSelected();
        }

        private void BtnTabQuickScan_Click(object sender, EventArgs e)
        {
            PanelSelector.Location = new Point(0, BtnTabQuickScan.Location.Y);
            IsChild(true);
            Selected = 8;
            CheckSelected();
        }

        private void BtnFullScan_Click(object sender, EventArgs e)
        {
            PanelSelector.Location = new Point(0, BtnTabFullScan.Location.Y);
            IsChild(true);
            TabMain.SelectedTab = TabFullScan;
            Selected = 7;
            CheckSelected();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            PanelSelector.Location = new Point(0, BtnAbout.Location.Y);
            Selected = 6;
            IsChild(false);
            CheckSelected();
            TabMain.SelectedTab = TabAbout;
        }

        private void CheckSelected()
        {
            switch (Selected)
            {
                case 1:
                    BtnDashBoard.BackColor = Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnProtection, BtnScanner, BtnUpdates, BtnSettings, BtnAbout, BtnTabFullScan, BtnTabQuickScan, BtnTabSelective);
                    break;

                case 2:
                    BtnProtection.BackColor = Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnDashBoard, BtnScanner, BtnUpdates, BtnSettings, BtnAbout, BtnTabFullScan, BtnTabQuickScan, BtnTabSelective);
                    break;

                case 3:
                    BtnScanner.BackColor = Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnDashBoard, BtnProtection, BtnUpdates, BtnSettings, BtnAbout, BtnTabFullScan, BtnTabQuickScan, BtnTabSelective);
                    break;

                case 4:
                    BtnUpdates.BackColor = Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnDashBoard, BtnProtection, BtnScanner, BtnSettings, BtnAbout, BtnTabFullScan, BtnTabQuickScan, BtnTabSelective);
                    break;

                case 5:
                    BtnSettings.BackColor = Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnDashBoard, BtnProtection, BtnScanner, BtnUpdates, BtnAbout, BtnTabFullScan, BtnTabQuickScan, BtnTabSelective);
                    break;

                case 6:
                    BtnAbout.BackColor = Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnDashBoard, BtnProtection, BtnScanner, BtnUpdates, BtnSettings, BtnTabFullScan, BtnTabQuickScan, BtnTabSelective);
                    break;

                case 7:
                    BtnTabFullScan.BackColor = Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnDashBoard, BtnProtection, BtnScanner, BtnUpdates, BtnSettings, BtnAbout, BtnTabQuickScan, BtnTabSelective);
                    break;

                case 8:
                    BtnTabQuickScan.BackColor = Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnDashBoard, BtnProtection, BtnScanner, BtnUpdates, BtnSettings, BtnAbout, BtnTabFullScan, BtnTabSelective);
                    break;

                case 9:
                    BtnTabSelective.BackColor = Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnDashBoard, BtnProtection, BtnScanner, BtnUpdates, BtnSettings, BtnAbout, BtnTabFullScan, BtnTabQuickScan);
                    break;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (Selected == 5)
            {
                PanelSelector.Location = new Point(0, BtnSettings.Location.Y);
            }
            else if (Selected == 6)
            {
                PanelSelector.Location = new Point(0, BtnAbout.Location.Y);
            }
        }

        #endregion BtnTab

        #region Customize

        private void WhoIsUnSelected(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8)
        {
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button7.BackColor = Color.Transparent;
            button8.BackColor = Color.Transparent;
        }

        private void CustomColor()
        {
            treePath.ForeColor = Color.White;
            TabDashboard.BackColor = BackColor;
            TabProtection.BackColor = BackColor;
            TabSelective.BackColor = BackColor;
            TabUpdates.BackColor = BackColor;
            TabSettings.BackColor = BackColor;
            TabAbout.BackColor = BackColor;
            treePath.BackColor = BackColor;
            TabScanner.BackColor = BackColor;
        }

        private void IsChild(bool child)
        {
            switch (child)
            {
                case true:
                    PanelSelector.Size = new Size(3, 44);
                    break;

                case false:
                    PanelSelector.Size = new Size(3, 50);
                    break;
            }
        }

        #endregion Customize

        private void BtnScan_Click(object sender, EventArgs e)
        {
            TabMain.SelectedTab = TabScanner;

            IsScan(true);
            ThreadStart starter = ScanDir;
            starter += () =>
            {
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    IsScan(false);
                    MessageBox.Show(this, "Scan Completed, no virus were found", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            };
            threadScan = new Thread(starter) { IsBackground = true };
            threadScan.Start();
        }

        private void Scan()
        {
            for (int i = 0; i <= files.Count - 1; i++)
            {
                string virusName;
                ScanResult result = clamAV.ScanFile(files[i], ScanOptions.StandardOptions, out virusName);
                this.Invoke(new Action(() =>
                {
                    // progressBar1.Value = i;
                    //LblCurrentScan.Text = files[i];
                }));
            }
        }

        private void ScanDir()
        {
            var scannedFiles = new List<Tuple<string, ScanResult, string>>();
            try
            {
                for (int i = 0; i <= selectedDir.Count - 1; i++)
                {
                    clamAV.ScanDirectory(selectedDir[i], (file, result, virus) =>
                    {
                        scannedFiles.Add(Tuple.Create(file, result, virus));
                        BeginInvoke(new MethodInvoker(delegate ()
                        {
                            LblCurrent.Text = file;
                            LblTotalScan.Text = scannedFiles.Count.ToString();
                        }));
                    });

                    var infected = scannedFiles.Where(f => f.Item2 == ScanResult.Virus);
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        LblDetected.Text = infected.Count().ToString();
                    }));
                }
            }
            catch { }
        }

        private void treePath_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked == true)
            {
                selectedDir.Add(e.Node.Name);
            }
            else
            {
                try
                {
                    selectedDir.Remove(e.Node.Name);
                }
                catch { }
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "Apakah anda yakin ingin membatalkan proses scanning?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    threadScan.Abort();
                    IsScan(false);
                    break;
            }
        }

        private void IsScan(bool scanState)
        {
            if (!(scanState == true))
            {
                if (InvokeRequired || InvokeRequired == false)
                {
                    BtnStop.Visible = false;
                    LblTotalScan.Text = Convert.ToString(0);
                    LblCurrent.Text = "";
                }
            }
            else
            {
                if (InvokeRequired || InvokeRequired == false)
                {
                    BtnStop.Visible = true;
                }
            }
        }
    }
}