namespace SearchOfFile
{
	partial class SelectFolderForm
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
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btnFind = new System.Windows.Forms.Button();
			this.tbMask = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnFind
			// 
			this.btnFind.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnFind.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnFind.Location = new System.Drawing.Point(0, 35);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(376, 43);
			this.btnFind.TabIndex = 0;
			this.btnFind.Text = "Find Files";
			this.btnFind.UseVisualStyleBackColor = true;
			// 
			// tbMask
			// 
			this.tbMask.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbMask.Location = new System.Drawing.Point(0, 3);
			this.tbMask.Name = "tbMask";
			this.tbMask.Size = new System.Drawing.Size(376, 32);
			this.tbMask.TabIndex = 1;
			this.tbMask.Text = "Mask for searching";
			// 
			// SelectFolderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 78);
			this.Controls.Add(this.tbMask);
			this.Controls.Add(this.btnFind);
			this.Name = "SelectFolderForm";
			this.Text = "Select folder";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox tbMask;
	}
}