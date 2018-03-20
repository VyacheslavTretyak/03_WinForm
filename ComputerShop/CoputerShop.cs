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
	
	public partial class CoputerShop : Form
	{
		List<ComputerItem> items;			
		public CoputerShop()
		{
			InitializeComponent();
			Load += CoputerShop_Load;
			items = new List<ComputerItem>()
			{
				new ComputerItem()
				{
					Name = "GeForce 650",
					Specification = "650",
					Description = "videocard",
					Price = 5699f
				},
				new ComputerItem()
				{
					Name = "Rysen 3",
					Specification = "3.2 Hz",
					Description = "processor",
					Price = 3500f
				}
			};
			cbItems.DataSource = items;
			cbItems.SelectedIndexChanged += CbItems_SelectedIndexChanged;
			cbItems.SelectedIndex = -1;

			btnAdd.Click += BtnAdd_Click;

			btnBuy.Click += BtnBuy_Click;

			btnDelete.Click += BtnDelete_Click;

			btnEdit.Click += BtnEdit_Click;
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			ItemEditForm editForm = new ItemEditForm(cbItems.SelectedItem as ComputerItem);
			if (editForm.ShowDialog() == DialogResult.OK)
			{
				items[cbItems.SelectedIndex] = editForm.Item;
				cbItems.DataSource = null;
				cbItems.DataSource = items;
			}
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			lbItems.Items.Remove(lbItems.SelectedItem);
			SetSum();
		}

		private void BtnBuy_Click(object sender, EventArgs e)
		{
			lbItems.Items.Add(items[cbItems.SelectedIndex]);
			SetSum();
		}

		private void CbItems_SelectedIndexChanged(object sender, EventArgs e)
		{			
			if(cbItems.SelectedIndex > -1)
			{
				SetPrice(items[cbItems.SelectedIndex].Price);
			}			
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			ItemEditForm editForm = new ItemEditForm();
			if(editForm.ShowDialog() == DialogResult.OK)
			{
				items.Add(editForm.Item);
				cbItems.DataSource = null;
				cbItems.DataSource = items;				
			}
		}

		private void CoputerShop_Load(object sender, EventArgs e)
		{			
			SetSum();
			SetPrice(0);
		}
		private void SetSum()
		{
			float sum = 0;
			foreach (ComputerItem item in lbItems.Items)
			{
				sum += item.Price;
			}
			lbSum.Text = $"SUM : {sum:F2} grn.";
		}
		private void SetPrice(float price)
		{
			lbPrice.Text = $"{price:F2} grn.";
		}
	}
}
