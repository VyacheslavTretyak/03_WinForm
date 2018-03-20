using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
	public partial class ItemEditForm : Form
	{
		public ComputerItem Item { get; set; }			
		public ItemEditForm()
		{
			InitializeComponent();
			tbName.Enter += TextBox_Enter;
			tbSpec.Enter += TextBox_Enter;
			tbDescr.Enter += TextBox_Enter;
			tbPrice.Enter += TextBox_Enter;

			tbName.Leave += TextBox_Leave;
			tbSpec.Leave += TextBox_Leave;
			tbDescr.Leave += TextBox_Leave;
			tbPrice.Leave += TextBox_Leave;

			btnCancel.Click += BtnCancel_Click;
			btnSave.Click += BtnSave_Click;			
		}
		public ItemEditForm(ComputerItem compItem) : this()
		{
			Item = compItem;
			tbName.Text = Item.Name;
			tbSpec.Text = Item.Specification;
			tbDescr.Text = Item.Description;
			tbPrice.Text = Item.Price.ToString(); 
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			try
			{				
				Item = new ComputerItem()
				{
					Name = tbName.Text,
					Specification = tbSpec.Text,
					Description = tbDescr.Text,
					Price = float.Parse(tbPrice.Text)
				};
				DialogResult = DialogResult.OK;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				DialogResult = DialogResult.Cancel;
			}			
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void TextBox_Leave(object sender, EventArgs e)
		{
			TextBox tb = sender as TextBox;
			if(tb.Text == "")
			{
				tb.Text = tb.Tag.ToString();
				tb.ForeColor = Color.Gray;
			}
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox tb = sender as TextBox;
			if(tb.Text == tb.Tag.ToString())
			{
				tb.Text = "";
				tb.ForeColor = Color.Black;
			}
		}

	}
}
