namespace WindowsEnvEditor
{
	partial class frmMain
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
			this.lstEnvVars = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoSystem = new System.Windows.Forms.RadioButton();
			this.rdoUser = new System.Windows.Forms.RadioButton();
			this.lstEnvVarValues = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstEnvVars
			// 
			this.lstEnvVars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lstEnvVars.FormattingEnabled = true;
			this.lstEnvVars.Location = new System.Drawing.Point(12, 80);
			this.lstEnvVars.Name = "lstEnvVars";
			this.lstEnvVars.Size = new System.Drawing.Size(262, 355);
			this.lstEnvVars.TabIndex = 0;
			this.lstEnvVars.SelectedIndexChanged += new System.EventHandler(this.lstEnvVars_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdoSystem);
			this.groupBox1.Controls.Add(this.rdoUser);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(262, 62);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Scope";
			// 
			// rdoSystem
			// 
			this.rdoSystem.AutoSize = true;
			this.rdoSystem.Location = new System.Drawing.Point(6, 36);
			this.rdoSystem.Name = "rdoSystem";
			this.rdoSystem.Size = new System.Drawing.Size(59, 17);
			this.rdoSystem.TabIndex = 1;
			this.rdoSystem.Text = "System";
			this.rdoSystem.UseVisualStyleBackColor = true;
			this.rdoSystem.CheckedChanged += new System.EventHandler(this.rdoSystem_CheckedChanged);
			// 
			// rdoUser
			// 
			this.rdoUser.AutoSize = true;
			this.rdoUser.Checked = true;
			this.rdoUser.Location = new System.Drawing.Point(6, 16);
			this.rdoUser.Name = "rdoUser";
			this.rdoUser.Size = new System.Drawing.Size(47, 17);
			this.rdoUser.TabIndex = 0;
			this.rdoUser.TabStop = true;
			this.rdoUser.Text = "User";
			this.rdoUser.UseVisualStyleBackColor = true;
			this.rdoUser.CheckedChanged += new System.EventHandler(this.rdoUser_CheckedChanged);
			// 
			// lstEnvVarValues
			// 
			this.lstEnvVarValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.lstEnvVarValues.FullRowSelect = true;
			this.lstEnvVarValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lstEnvVarValues.LabelEdit = true;
			this.lstEnvVarValues.Location = new System.Drawing.Point(280, 12);
			this.lstEnvVarValues.MultiSelect = false;
			this.lstEnvVarValues.Name = "lstEnvVarValues";
			this.lstEnvVarValues.Size = new System.Drawing.Size(568, 423);
			this.lstEnvVarValues.TabIndex = 3;
			this.lstEnvVarValues.UseCompatibleStateImageBehavior = false;
			this.lstEnvVarValues.View = System.Windows.Forms.View.Details;
			this.lstEnvVarValues.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstEnvVarValues_MouseClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 560;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(860, 446);
			this.Controls.Add(this.lstEnvVarValues);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lstEnvVars);
			this.Name = "frmMain";
			this.Text = "Environment Editor";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.Click += new System.EventHandler(this.frmMain_Click);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstEnvVars;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoSystem;
		private System.Windows.Forms.RadioButton rdoUser;
		private System.Windows.Forms.ListView lstEnvVarValues;
		private System.Windows.Forms.ColumnHeader columnHeader1;
	}
}

