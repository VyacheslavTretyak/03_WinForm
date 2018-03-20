namespace ComputerShop
{
	partial class CoputerShop
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbItems = new System.Windows.Forms.ListBox();
			this.lbPrice = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.lbSum = new System.Windows.Forms.Label();
			this.btnBuy = new System.Windows.Forms.Button();
			this.cbItems = new System.Windows.Forms.ComboBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbItems
			// 
			this.lbItems.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbItems.FormattingEnabled = true;
			this.lbItems.ItemHeight = 20;
			this.lbItems.Location = new System.Drawing.Point(0, 0);
			this.lbItems.Name = "lbItems";
			this.lbItems.Size = new System.Drawing.Size(309, 264);
			this.lbItems.TabIndex = 0;
			// 
			// lbPrice
			// 
			this.lbPrice.AutoSize = true;
			this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lbPrice.Location = new System.Drawing.Point(170, 288);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new System.Drawing.Size(67, 29);
			this.lbPrice.TabIndex = 2;
			this.lbPrice.Text = "price";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.ForeColor = System.Drawing.Color.ForestGreen;
			this.btnAdd.Location = new System.Drawing.Point(0, 454);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(149, 41);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEdit.ForeColor = System.Drawing.Color.Tomato;
			this.btnEdit.Location = new System.Drawing.Point(160, 454);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(149, 41);
			this.btnEdit.TabIndex = 4;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// lbSum
			// 
			this.lbSum.AutoSize = true;
			this.lbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbSum.ForeColor = System.Drawing.Color.DarkViolet;
			this.lbSum.Location = new System.Drawing.Point(12, 389);
			this.lbSum.Name = "lbSum";
			this.lbSum.Size = new System.Drawing.Size(58, 29);
			this.lbSum.TabIndex = 5;
			this.lbSum.Text = "sum";
			// 
			// btnBuy
			// 
			this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnBuy.ForeColor = System.Drawing.Color.Olive;
			this.btnBuy.Location = new System.Drawing.Point(0, 323);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.Size = new System.Drawing.Size(149, 41);
			this.btnBuy.TabIndex = 6;
			this.btnBuy.Text = "Buy";
			this.btnBuy.UseVisualStyleBackColor = true;
			// 
			// cbItems
			// 
			this.cbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbItems.FormattingEnabled = true;
			this.cbItems.Location = new System.Drawing.Point(0, 284);
			this.cbItems.Name = "cbItems";
			this.cbItems.Size = new System.Drawing.Size(149, 33);
			this.cbItems.TabIndex = 7;
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDelete.ForeColor = System.Drawing.Color.Sienna;
			this.btnDelete.Location = new System.Drawing.Point(160, 323);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(149, 41);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// CoputerShop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(309, 507);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.cbItems);
			this.Controls.Add(this.btnBuy);
			this.Controls.Add(this.lbSum);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lbPrice);
			this.Controls.Add(this.lbItems);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CoputerShop";
			this.Text = "Computer shop";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbItems;
		private System.Windows.Forms.Label lbPrice;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Label lbSum;
		private System.Windows.Forms.Button btnBuy;
		private System.Windows.Forms.ComboBox cbItems;
		private System.Windows.Forms.Button btnDelete;
	}
}

