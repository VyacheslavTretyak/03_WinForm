using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditTextFile
{
	public partial class EditTextForm : Form
	{
		private LoadFileForm mainForm;
		public EditTextForm(LoadFileForm form)
		{
			InitializeComponent();
			mainForm = form;
			btnCancel.Click += BtnCancel_Click;
			btnSave.Click += BtnSave_Click;
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			mainForm.SaveFile(tbText.Text);
			Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void Show(string text)
		{
			tbText.Text = text;
			Show();
		}
	}
}
