using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SearchOfFile
{
	public partial class SearchOfFileForm : Form
	{
		public SearchOfFileForm()
		{
			InitializeComponent();
			btnFind.Click += BtnFind_Click;
			btnClear.Click += BtnClear_Click;
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			lbFiles.Items.Clear();
		}

		private void BtnFind_Click(object sender, EventArgs e)
		{
			SelectFolderForm folderForm = new SelectFolderForm(this);
			folderForm.Show();
		}
		public void LoadFileList(string path, string mask)
		{
			lbFiles.Items.AddRange(Directory.GetFiles(path, mask));
		}

	}
}
