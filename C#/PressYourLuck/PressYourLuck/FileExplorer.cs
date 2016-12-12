/*
 * This class will be used to define the functionality for the setup window.
 * 
 * A file explorer was created using directions and sample code from https://msdn.microsoft.com/en-us/library/ms171645(v=vs.110).aspx
 * My own code has been added to tailor the functionality of the file explorer to the PressYourLuck program.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace PressYourLuck
{
    public partial class FileExplorer : Form
    {
        private string triviaFileName;
        //regex to extract file name from listview
        //read as: (look behind for '{')(string)(look ahead for '}')
        Regex rgx = new Regex(@"(?<=\{)(.*)(?=\})", RegexOptions.IgnoreCase);

        //Constructor
        public FileExplorer()
        {
            InitializeComponent();
            PopulateTreeView();
            this.treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
        }

        //Method used to retrieve directory info and show it in the TreeView
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        //Method used to get directory info
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        //Method used to adjust the tree view according to what the user has chosen to expand/collapse
        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[] {new ListViewItem.ListViewSubItem(item, "Directory"), new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]{ new ListViewItem.ListViewSubItem(item, "File"), new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            //getting the full path of the file:
            //Note: listView1.SelectedItems[0].ToString() returns the name of the listView item in a format similar to: "List Item: {myFile.txt}"
            //I used regex here to extract the string from between the brackets and then find the full path useing the Path.GetFullPath method
            triviaFileName = Path.GetFullPath(rgx.Match(listView1.SelectedItems[0].ToString()).ToString());
            triviaFileName = triviaFileName.Replace("\bin\\Debug", "");
            Console.WriteLine(triviaFileName);
            this.Close();
            //Code to be tested for file reading (create new thread here to read file?)
            //string[] lines = System.IO.File.ReadAllLines(filename);
            //System.IO.StreamReader file = new System.IO.StreamReader(Path.GetFullPath(listView1.SelectedItems[0].ToString()));
            //Console.WriteLine(Path.GetFullPath(rgx.Match(listView1.SelectedItems[0].ToString()).ToString()));
        }
        //Method used to make sure something has been selected before the user is allowed to press the "Select" button
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectButton.Enabled = true;
        }
        //get method for question file name
        public string getFilePath()
        {
            Console.WriteLine("TriviaFileName = " + triviaFileName);
            return triviaFileName;
        }
    }
}
