using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchOfFile
{
	public partial class SelectFolderForm : Form
	{	
		string defaultText = "Mask for searching";
		SearchOfFileForm mainForm;
		public SelectFolderForm(SearchOfFileForm main)
		{
			InitializeComponent();
			mainForm = main;
			Load += SelectFolderForm_Load;
			tbMask.Text = defaultText;
			tbMask.ForeColor = Color.Gray;
			tbMask.Leave += TbMask_Leave;
			tbMask.Enter += TbMask_Enter;
			btnFind.Click += BtnFind_Click;
		}

		private void BtnFind_Click(object sender, EventArgs e)
		{
			if (tbMask.Text != defaultText)
			{				
				mainForm.LoadFileList(folderBrowserDialog1.SelectedPath, tbMask.Text);
			}
		}

		private void TbMask_Enter(object sender, EventArgs e)
		{
			TextBox tb = sender as TextBox;		
			if (tb.Text == defaultText)
			{
				tb.Text = "";
				tb.ForeColor = Color.Black;
			}
		}

		private void TbMask_Leave(object sender, EventArgs e)
		{
			if(tbMask.Text == "" || tbMask.Text == defaultText)
			{
				tbMask.Text = defaultText;
				tbMask.ForeColor = Color.Gray;
			}
		}		

		private void SelectFolderForm_Load(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
		}
	}
}
