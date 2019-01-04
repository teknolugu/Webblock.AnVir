using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Webblock_AV.Helper;
using ClamAV.Managed;
using System.Linq;

namespace Webblock_AV
{
    public partial class Form1 : Form
    {
        private List<string> ExpandedNode = new List<string>();
        private List<string> subDir = new List<string>();
        private ClamEngine clamAV;

        private List<string> files = new List<string>();
        private string combinedPath;
        private int TotalDrive;
        private int Selected;
        public Form1()
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
                }catch(Exception ex)
                {
                    if (InvokeRequired)
                    {
                        Text = "Failed to load signature";
                    }
                }
            });
            SetupThread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            files.Clear();
            FolderBrowserDialog browseFolder = new FolderBrowserDialog();
            if (browseFolder.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = browseFolder.SelectedPath;

            }
            
        }

        private void GetFilesInDirectory()
        {
            //foreach (string item in listBox1.Items){
            //    foreach (string listF in Directory.GetFiles(item))
            //    {
            //        files.Add(listF);
            //    }
            //    foreach (string dir in Directory.GetDirectories(item, "*", SearchOption.AllDirectories))
            //    {

            //        subDir.Add(dir);
            //        foreach (string flist in Directory.GetFiles(dir))
            //        {
            //            //if (InvokeRequired)
            //            //{
            //            //    BeginInvoke(new MethodInvoker(delegate ()
            //            //    {
            //            //        listBox1.Items.Add(flist);
            //            //    }));
            //            //}
            //            files.Add(flist);
            //        }

            //    }
            //}
            

            
            if (InvokeRequired)
            {
                label1.BeginInvoke(new MethodInvoker(delegate ()
                {
                    label1.Text = files.Count.ToString();
                }));
            }

        }
       

      

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Intialize

            Selected = 1;
            CheckSelected();
            GetDrives();
            CustomColor();

            #endregion
            ApplyShellIcon();
            GetAllDirectories();
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

            for(int i = 0; i<=treePath.Nodes[0].Nodes.Count-1; i++)
            {
                treePath.Nodes[0].Nodes[i].ImageIndex = 1;
                treePath.Nodes[0].Nodes[i].SelectedImageIndex = 1;
                foreach (TreeNode nodes in treePath.Nodes[0].Nodes[i].Nodes)
                {
                    nodes.SelectedImageIndex = 2;
                    nodes.ImageIndex = 2;
                }
            }
            
      
        }
        #endregion

        #region PopulateTreeOnLoad
        private void GetAllDirectories()
        {
           
        }
        #endregion


        #region PopulateTree
        private void GetDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo drive in drives)
            {
               if(drive.IsReady == true)
                {
                    treePath.Nodes[0].Nodes.Add(drive.VolumeLabel + " (" + drive.Name + ")").Name = drive.Name;
                }
               
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (!(e.Node.Text.Contains(")") && e.Node.Text.Contains(":") || e.Node.Text.Contains("This PC")))
            {
                combinedPath = combinedPath + e.Node.Text;
                MessageBox.Show(combinedPath);
            }
            else if(e.Node.Text.Contains(")") && e.Node.Text.Contains(":"))
            {
                //foreach (string dir in Directory.GetDirectories(e.Node.NextNode.Name))
                //{
                //    e.Node.NextNode.Nodes.Add(new DirectoryInfo(dir).Name);
                //}
                combinedPath = "";
                combinedPath = e.Node.Text.Substring(e.Node.Text.IndexOf("(")+1,3);
                MessageBox.Show(combinedPath);
            }

        }
        #endregion

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
        private void BtnTabQuickScan_Click(object sender,EventArgs e)
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
                    WhoIsUnSelected(BtnProtection, BtnScanner, BtnUpdates, BtnSettings, BtnAbout,BtnTabFullScan,BtnTabQuickScan,BtnTabSelective);
                    break;
                case 2:
                    BtnProtection.BackColor = Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnDashBoard, BtnScanner, BtnUpdates, BtnSettings, BtnAbout, BtnTabFullScan, BtnTabQuickScan, BtnTabSelective);
                    break;
                case 3:
                    BtnScanner.BackColor =  Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnDashBoard, BtnProtection, BtnUpdates, BtnSettings, BtnAbout, BtnTabFullScan, BtnTabQuickScan, BtnTabSelective);
                    break;
                case 4:
                    BtnUpdates.BackColor = Color.FromArgb(86, 86, 86);
                    WhoIsUnSelected(BtnDashBoard, BtnProtection, BtnScanner, BtnSettings, BtnAbout,BtnTabFullScan, BtnTabQuickScan, BtnTabSelective);
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
                    WhoIsUnSelected(BtnDashBoard, BtnProtection, BtnScanner, BtnUpdates, BtnSettings, BtnAbout,BtnTabFullScan, BtnTabQuickScan);
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

        #endregion

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






        #endregion

        private void BtnScan_Click(object sender, EventArgs e)
        {

            //ThreadStart starter = GetFilesInDirectory;
            //starter += () =>
            //{
            //    Thread ScanThread = new Thread(Scan);
            //    ScanThread.Start();
            //};
            //Thread RetrieveFiles = new Thread(starter) { IsBackground = true };
            //RetrieveFiles.Start();

            ThreadStart starter = ScanDir;
            starter += () =>
            {
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    MessageBox.Show(this, "Scan Completed, no virus were found", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));

            };
            Thread threadScan = new Thread(starter) { IsBackground = true };
            threadScan.Start();
            //Thread threadScan = new Thread(ScanDir);
            //threadScan.Start();

        }

        private void Scan()
        {
            //progressBar1.Maximum = files.Count;

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
            //var scannedFiles = new List<Tuple<string, ScanResult, string>>();

            //    clamAV.ScanDirectory(textBox1.Text, (file, result, virus) =>
            //    {
            //        scannedFiles.Add(Tuple.Create(file, result, virus));
            //        BeginInvoke(new MethodInvoker(delegate ()
            //        {
            //           // LblCurrentScan.Text = file;
            //            //LblTotalFiles.Text = scannedFiles.Count.ToString();
            //        }));
            //    });
            //    var infected = scannedFiles.Where(f => f.Item2 == ScanResult.Virus);
            //BeginInvoke(new MethodInvoker(delegate ()
            //{
            //    //LblDetected.Text = infected.Count().ToString();
            //}));
            
        }


    }
}
