namespace EditTextFile
{
	partial class LoadFileForm
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
			this.tbText = new System.Windows.Forms.TextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnModify = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbText
			// 
			this.tbText.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbText.Location = new System.Drawing.Point(0, 0);
			this.tbText.Multiline = true;
			this.tbText.Name = "tbText";
			this.tbText.ReadOnly = true;
			this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbText.Size = new System.Drawing.Size(678, 444);
			this.tbText.TabIndex = 0;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(12, 450);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 1;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			// 
			// btnModify
			// 
			this.btnModify.Enabled = false;
			this.btnModify.Location = new System.Drawing.Point(93, 450);
			this.btnModify.Name = "btnModify";
			this.btnModify.Size = new System.Drawing.Size(75, 23);
			this.btnModify.TabIndex = 2;
			this.btnModify.Text = "Modify";
			this.btnModify.UseVisualStyleBackColor = true;
			// 
			// LoadFileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 485);
			this.Controls.Add(this.btnModify);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.tbText);
			this.Name = "LoadFileForm";
			this.Text = "Edit text file";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbText;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnModify;
	}
}

