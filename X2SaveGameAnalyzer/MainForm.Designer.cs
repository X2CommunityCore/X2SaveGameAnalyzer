namespace X2SaveGameAnalyzer {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.bAnalyze = new System.Windows.Forms.Button();
			this.bSelectFile = new System.Windows.Forms.Button();
			this.tPath = new System.Windows.Forms.TextBox();
			this.openSaveGameDialog = new System.Windows.Forms.OpenFileDialog();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.tInfo = new System.Windows.Forms.TextBox();
			this.MainTabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lCreated = new System.Windows.Forms.Label();
			this.label123 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.lLastModified = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lDescription = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lCampaign = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lMapCommand = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lSavegame = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lLanguage = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lVersion = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tMods = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tFileName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.MainTabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// bAnalyze
			// 
			this.bAnalyze.Location = new System.Drawing.Point(93, 12);
			this.bAnalyze.Name = "bAnalyze";
			this.bAnalyze.Size = new System.Drawing.Size(75, 23);
			this.bAnalyze.TabIndex = 0;
			this.bAnalyze.Text = "Analyze";
			this.bAnalyze.UseVisualStyleBackColor = true;
			this.bAnalyze.Click += new System.EventHandler(this.bAnalyze_Click);
			// 
			// bSelectFile
			// 
			this.bSelectFile.Location = new System.Drawing.Point(12, 12);
			this.bSelectFile.Name = "bSelectFile";
			this.bSelectFile.Size = new System.Drawing.Size(75, 23);
			this.bSelectFile.TabIndex = 1;
			this.bSelectFile.Text = "Select file";
			this.bSelectFile.UseVisualStyleBackColor = true;
			this.bSelectFile.Click += new System.EventHandler(this.bSelectFile_Click);
			// 
			// tPath
			// 
			this.tPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tPath.Location = new System.Drawing.Point(174, 14);
			this.tPath.Name = "tPath";
			this.tPath.ReadOnly = true;
			this.tPath.Size = new System.Drawing.Size(265, 20);
			this.tPath.TabIndex = 2;
			// 
			// openSaveGameDialog
			// 
			this.openSaveGameDialog.AddExtension = false;
			this.openSaveGameDialog.Title = "Select XCOM 2 save game file";
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.HelpVisible = false;
			this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(612, 304);
			this.propertyGrid1.TabIndex = 3;
			this.propertyGrid1.ToolbarVisible = false;
			// 
			// tInfo
			// 
			this.tInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tInfo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tInfo.Location = new System.Drawing.Point(12, 383);
			this.tInfo.Multiline = true;
			this.tInfo.Name = "tInfo";
			this.tInfo.ReadOnly = true;
			this.tInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tInfo.Size = new System.Drawing.Size(622, 102);
			this.tInfo.TabIndex = 4;
			// 
			// MainTabControl
			// 
			this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainTabControl.Controls.Add(this.tabPage1);
			this.MainTabControl.Controls.Add(this.tabPage3);
			this.MainTabControl.Controls.Add(this.tabPage2);
			this.MainTabControl.Location = new System.Drawing.Point(12, 41);
			this.MainTabControl.Name = "MainTabControl";
			this.MainTabControl.SelectedIndex = 0;
			this.MainTabControl.Size = new System.Drawing.Size(626, 336);
			this.MainTabControl.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(618, 310);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Summary";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.lName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lCreated, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label123, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label14, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lLastModified, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lDescription, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.lCampaign, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.lMapCommand, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.lSavegame, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.lLanguage, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.label11, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.lVersion, 1, 6);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 9;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 304);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lName
			// 
			this.lName.AutoSize = true;
			this.lName.Location = new System.Drawing.Point(103, 3);
			this.lName.Margin = new System.Windows.Forms.Padding(3);
			this.lName.Name = "lName";
			this.lName.Size = new System.Drawing.Size(35, 13);
			this.lName.TabIndex = 1;
			this.lName.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// lCreated
			// 
			this.lCreated.AutoSize = true;
			this.lCreated.Location = new System.Drawing.Point(103, 22);
			this.lCreated.Margin = new System.Windows.Forms.Padding(3);
			this.lCreated.Name = "lCreated";
			this.lCreated.Size = new System.Drawing.Size(44, 13);
			this.lCreated.TabIndex = 11;
			this.lCreated.Text = "Created";
			// 
			// label123
			// 
			this.label123.AutoSize = true;
			this.label123.Location = new System.Drawing.Point(3, 22);
			this.label123.Margin = new System.Windows.Forms.Padding(3);
			this.label123.Name = "label123";
			this.label123.Size = new System.Drawing.Size(47, 13);
			this.label123.TabIndex = 12;
			this.label123.Text = "Created:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(3, 41);
			this.label14.Margin = new System.Windows.Forms.Padding(3);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 13);
			this.label14.TabIndex = 13;
			this.label14.Text = "Last modified:";
			// 
			// lLastModified
			// 
			this.lLastModified.AutoSize = true;
			this.lLastModified.Location = new System.Drawing.Point(103, 41);
			this.lLastModified.Margin = new System.Windows.Forms.Padding(3);
			this.lLastModified.Name = "lLastModified";
			this.lLastModified.Size = new System.Drawing.Size(69, 13);
			this.lLastModified.TabIndex = 14;
			this.lLastModified.Text = "Last modified";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 60);
			this.label5.Margin = new System.Windows.Forms.Padding(3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Description:";
			// 
			// lDescription
			// 
			this.lDescription.AutoSize = true;
			this.lDescription.Location = new System.Drawing.Point(103, 60);
			this.lDescription.Margin = new System.Windows.Forms.Padding(3);
			this.lDescription.Name = "lDescription";
			this.lDescription.Size = new System.Drawing.Size(60, 13);
			this.lDescription.TabIndex = 6;
			this.lDescription.Text = "Description";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 79);
			this.label3.Margin = new System.Windows.Forms.Padding(3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Campaign #:";
			// 
			// lCampaign
			// 
			this.lCampaign.AutoSize = true;
			this.lCampaign.Location = new System.Drawing.Point(103, 79);
			this.lCampaign.Margin = new System.Windows.Forms.Padding(3);
			this.lCampaign.Name = "lCampaign";
			this.lCampaign.Size = new System.Drawing.Size(64, 13);
			this.lCampaign.TabIndex = 3;
			this.lCampaign.Text = "Campaign #";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 136);
			this.label7.Margin = new System.Windows.Forms.Padding(3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Map command:";
			// 
			// lMapCommand
			// 
			this.lMapCommand.AutoSize = true;
			this.lMapCommand.Location = new System.Drawing.Point(103, 136);
			this.lMapCommand.Margin = new System.Windows.Forms.Padding(3);
			this.lMapCommand.Name = "lMapCommand";
			this.lMapCommand.Size = new System.Drawing.Size(77, 13);
			this.lMapCommand.TabIndex = 8;
			this.lMapCommand.Text = "Map command";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 98);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Savegame #:";
			// 
			// lSavegame
			// 
			this.lSavegame.AutoSize = true;
			this.lSavegame.Location = new System.Drawing.Point(103, 98);
			this.lSavegame.Margin = new System.Windows.Forms.Padding(3);
			this.lSavegame.Name = "lSavegame";
			this.lSavegame.Size = new System.Drawing.Size(68, 13);
			this.lSavegame.TabIndex = 4;
			this.lSavegame.Text = "Savegame #";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 155);
			this.label9.Margin = new System.Windows.Forms.Padding(3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Language:";
			// 
			// lLanguage
			// 
			this.lLanguage.AutoSize = true;
			this.lLanguage.Location = new System.Drawing.Point(103, 155);
			this.lLanguage.Margin = new System.Windows.Forms.Padding(3);
			this.lLanguage.Name = "lLanguage";
			this.lLanguage.Size = new System.Drawing.Size(55, 13);
			this.lLanguage.TabIndex = 10;
			this.lLanguage.Text = "Language";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 117);
			this.label11.Margin = new System.Windows.Forms.Padding(3);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(45, 13);
			this.label11.TabIndex = 3;
			this.label11.Text = "Version:";
			// 
			// lVersion
			// 
			this.lVersion.AutoSize = true;
			this.lVersion.Location = new System.Drawing.Point(103, 117);
			this.lVersion.Margin = new System.Windows.Forms.Padding(3);
			this.lVersion.Name = "lVersion";
			this.lVersion.Size = new System.Drawing.Size(42, 13);
			this.lVersion.TabIndex = 11;
			this.lVersion.Text = "Version";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tMods);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(618, 310);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Mods";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tMods
			// 
			this.tMods.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tMods.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tMods.Location = new System.Drawing.Point(3, 3);
			this.tMods.Multiline = true;
			this.tMods.Name = "tMods";
			this.tMods.ReadOnly = true;
			this.tMods.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tMods.Size = new System.Drawing.Size(612, 304);
			this.tMods.TabIndex = 5;
			this.tMods.WordWrap = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.propertyGrid1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(618, 310);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Diagnostic";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tFileName
			// 
			this.tFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tFileName.Location = new System.Drawing.Point(463, 14);
			this.tFileName.Name = "tFileName";
			this.tFileName.ReadOnly = true;
			this.tFileName.Size = new System.Drawing.Size(171, 20);
			this.tFileName.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(445, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(12, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "\\";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 497);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tFileName);
			this.Controls.Add(this.tInfo);
			this.Controls.Add(this.MainTabControl);
			this.Controls.Add(this.tPath);
			this.Controls.Add(this.bSelectFile);
			this.Controls.Add(this.bAnalyze);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "XCOM 2 Savegame Analyzer";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MainTabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bAnalyze;
		private System.Windows.Forms.Button bSelectFile;
		private System.Windows.Forms.TextBox tPath;
		private System.Windows.Forms.OpenFileDialog openSaveGameDialog;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.TextBox tInfo;
		private System.Windows.Forms.TabControl MainTabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox tFileName;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lCampaign;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lLanguage;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lMapCommand;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lDescription;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lSavegame;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lCreated;
		private System.Windows.Forms.Label lLastModified;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label lVersion;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label123;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox tMods;
		private System.Windows.Forms.Label label4;
	}
}

