namespace SearchOfFile
{
	partial class SearchOfFileForm
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
			this.lbFiles = new System.Windows.Forms.ListBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbFiles
			// 
			this.lbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbFiles.FormattingEnabled = true;
			this.lbFiles.Location = new System.Drawing.Point(0, 0);
			this.lbFiles.Name = "lbFiles";
			this.lbFiles.Size = new System.Drawing.Size(311, 326);
			this.lbFiles.TabIndex = 0;
			// 
			// btnFind
			// 
			this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnFind.ForeColor = System.Drawing.SystemColors.GrayText;
			this.btnFind.Location = new System.Drawing.Point(0, 228);
			this.btnFind.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(311, 49);
			this.btnFind.TabIndex = 1;
			this.btnFind.Text = "Select Folder";
			this.btnFind.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnClear.Location = new System.Drawing.Point(0, 280);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(311, 46);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// SearchOfFileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 326);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.lbFiles);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "SearchOfFileForm";
			this.Text = "Search of files";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbFiles;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnClear;
	}
}

