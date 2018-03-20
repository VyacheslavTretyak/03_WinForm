namespace ComputerShop
{
	partial class ItemEditForm
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
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbSpec = new System.Windows.Forms.TextBox();
			this.tbDescr = new System.Windows.Forms.TextBox();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbName
			// 
			this.tbName.BackColor = System.Drawing.Color.NavajoWhite;
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.tbName.Location = new System.Drawing.Point(13, 13);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(282, 32);
			this.tbName.TabIndex = 0;
			this.tbName.Tag = "Name";
			this.tbName.Text = "Name";
			// 
			// tbSpec
			// 
			this.tbSpec.AcceptsReturn = true;
			this.tbSpec.BackColor = System.Drawing.Color.NavajoWhite;
			this.tbSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbSpec.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbSpec.Location = new System.Drawing.Point(12, 51);
			this.tbSpec.Multiline = true;
			this.tbSpec.Name = "tbSpec";
			this.tbSpec.Size = new System.Drawing.Size(282, 131);
			this.tbSpec.TabIndex = 1;
			this.tbSpec.Tag = "Specification";
			this.tbSpec.Text = "Specification";
			// 
			// tbDescr
			// 
			this.tbDescr.AcceptsReturn = true;
			this.tbDescr.BackColor = System.Drawing.Color.NavajoWhite;
			this.tbDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbDescr.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbDescr.Location = new System.Drawing.Point(12, 188);
			this.tbDescr.Multiline = true;
			this.tbDescr.Name = "tbDescr";
			this.tbDescr.Size = new System.Drawing.Size(282, 131);
			this.tbDescr.TabIndex = 2;
			this.tbDescr.Tag = "Description";
			this.tbDescr.Text = "Description";
			// 
			// tbPrice
			// 
			this.tbPrice.AcceptsReturn = true;
			this.tbPrice.BackColor = System.Drawing.Color.PaleTurquoise;
			this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.tbPrice.Location = new System.Drawing.Point(12, 325);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(282, 32);
			this.tbPrice.TabIndex = 3;
			this.tbPrice.Tag = "Price";
			this.tbPrice.Text = "Price";
			this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.ForeColor = System.Drawing.Color.ForestGreen;
			this.btnSave.Location = new System.Drawing.Point(13, 364);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(137, 40);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
			this.btnCancel.Location = new System.Drawing.Point(158, 363);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(137, 40);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// ItemEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SandyBrown;
			this.ClientSize = new System.Drawing.Size(307, 416);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.tbDescr);
			this.Controls.Add(this.tbSpec);
			this.Controls.Add(this.tbName);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ItemEditForm";
			this.Text = "Edit item ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbSpec;
		private System.Windows.Forms.TextBox tbDescr;
		private System.Windows.Forms.TextBox tbPrice;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
	}
}