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

namespace EditTextFile
{
	public partial class LoadFileForm : Form
	{
		string fileName = "";
		public LoadFileForm()
		{
			InitializeComponent();
			btnModify.Enabled = false;
			btnLoad.Click += BtnLoad_Click;
			btnModify.Click += BtnModify_Click;
		}

		private void BtnModify_Click(object sender, EventArgs e)
		{
			EditTextForm editForm = new EditTextForm(this);			
			editForm.Show(tbText.Text);
		}

		private void BtnLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text files(*.txt)|*.txt|C# files(*.cs)|*.cs||";
			if(openFileDialog.ShowDialog()== DialogResult.OK)
			{
				fileName = openFileDialog.FileName;
				LoadFile(fileName);
				btnModify.Enabled = true;
			}			
		}
		private void LoadFile(string fileName)
		{
			StreamReader sr = null;
			try
			{
				sr = File.OpenText(fileName);
				tbText.Text = sr.ReadToEnd();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (sr != null)
				{
					sr.Close();
				}
			}
		}		
		public void SaveFile(string text)
		{
			StreamWriter sw = null;
			try
			{
				if (fileName == "")
				{
					throw new Exception("File not loaded!");
				}
				tbText.Text = text;
				
				sw = new StreamWriter(fileName);
				sw.Write(tbText.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (sw != null)
				{
					sw.Close();
				}
			}
		}
	}
}
