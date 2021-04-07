using System;
using System.IO;
using System.Windows.Forms;

namespace TreeViewSample
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		#region Methods
		/// <summary>
		/// Populate the treeview with the contents of the local hard drive
		/// </summary>
		private void FillDirectoryTree()
		{
			//  Suppress redraw until tree view is complete
			tvw.BeginUpdate();

			//  First clear all the nodes.
			tvw.Nodes.Clear();

			//  Get the logical drives and put them into the root nodes.
			//  Fill an array with all the logical drives on the machine.
			string[] strDrives = Environment.GetLogicalDrives();

			//  Iterate through the drives, adding them to the tree.
			//  Use a try/catch block, so if a drive is not ready, 
			//  e.g. an empty floppy or CD, it will not be added to the tree.
			foreach (string rootDirectoryName in strDrives)
			{
				try
				{
					//  Find all the first level subdirectories.
					//  If the drive is not ready, this will throw an 
					//  exception, which will have the effect of 
					//  skipping that drive.
					Directory.GetDirectories(rootDirectoryName);

					//  Create a node for each root directory
					TreeNode ndRoot = new TreeNode(rootDirectoryName);

					//  Add the node to the tree
					tvw.Nodes.Add(ndRoot);

					//  Add subdirectory nodes.
					//  If Show Files checkbox checked, then also get the filenames.
					GetSubDirectoryNodes(ndRoot, cb.Checked);
				}
				catch (IOException)
				{
					//  let it through
				}
				catch (Exception e)
				{
					//  Catch any other errors.
					MessageBox.Show(e.Message);
				}
			}

			tvw.EndUpdate();

		}

		private void GetSubDirectoryNodes(TreeNode parentNode, bool getFileNames)
		{
			//  Exit this method if the node is not a directory.
			DirectoryInfo di = new DirectoryInfo(parentNode.FullPath);
			if ((di.Attributes & FileAttributes.Directory) == 0)
			{
				return;
			}

			//  Clear all the nodes in this node.
			parentNode.Nodes.Clear();

			try
			{
				//  Get an array of strings containing all the subdirectories in the parent node.
				string[] arSubs = Directory.GetDirectories(parentNode.FullPath);

				//  Add a child node for each subdirectory.
				foreach (var subDir in arSubs)
				{
					DirectoryInfo dirInfo = new DirectoryInfo(subDir);
					// do not show hidden folders
					if ((dirInfo.Attributes & FileAttributes.Hidden) != 0)
					{
						continue;
					}

					TreeNode subNode = new TreeNode(dirInfo.Name);
					subNode.ImageKey = "closedFolder.png";
					subNode.SelectedImageKey = "openFolder.png";
					parentNode.Nodes.Add(subNode);
				}

				if (getFileNames)
				{
					//  Get any files for this node.
					string[] files = Directory.GetFiles(parentNode.FullPath);

					// After placing the nodes, 
					// now place the files in that subdirectory.
					foreach (string str in files)
					{
						FileInfo fi = new FileInfo(str);
						TreeNode fileNode = new TreeNode(fi.Name);
						parentNode.Nodes.Add(fileNode);

						//  Set the icon
						switch (fi.Extension.ToUpper())
						{
							case ".JPG":
							case ".JPEG":
								fileNode.ImageKey = "jpgFile.png";
								fileNode.SelectedImageKey = "jpgFile.png";
								break;
							case ".TXT":
								fileNode.ImageKey = "textFile.png";
								fileNode.SelectedImageKey = "textFile.png";
								break;
							default:
								fileNode.ImageKey = "file.png";
								fileNode.SelectedImageKey = "file.png";
								break;
						}
					}
				}
			}
			catch (UnauthorizedAccessException)
			{

			}
		}
		#endregion

		#region Events
		private void MainForm_Load(object sender, EventArgs e)
		{
			FillDirectoryTree();
		}

		private void cb_CheckedChanged(object sender, EventArgs e)
		{
			FillDirectoryTree();
		}

		private void tvw_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			tvw.BeginUpdate();

			foreach (TreeNode tn in e.Node.Nodes)
			{
				GetSubDirectoryNodes(tn, cb.Checked);
			}

			tvw.EndUpdate();
		}

		private void btnSelected_Click(object sender, EventArgs e)
		{
			MessageBox.Show(tvw.SelectedNode + Environment.NewLine + "FullPath: " + tvw.SelectedNode.FullPath +
			                Environment.NewLine + "Index: " + tvw.SelectedNode.Index);
		}

		private void btnExpand_Click(object sender, EventArgs e)
		{
			if (tvw.SelectedNode != null)
				tvw.SelectedNode.Expand();
		}

		private void btnExpandAll_Click(object sender, EventArgs e)
		{
			if(tvw.SelectedNode != null)
				tvw.SelectedNode.ExpandAll();
		}

		private void btnCollapse_Click(object sender, EventArgs e)
		{
			if (tvw.SelectedNode != null)
				tvw.SelectedNode.Collapse();
		}

		private void btnCollapseAll_Click(object sender, EventArgs e)
		{
			tvw.CollapseAll();
		}

		private void btnToggle_Click(object sender, EventArgs e)
		{
			if (tvw.SelectedNode != null)
				tvw.SelectedNode.Toggle();
		}
		#endregion
	}
}
