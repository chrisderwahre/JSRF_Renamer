namespace JSRF_Character_Renamer
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.characterList = new System.Windows.Forms.ComboBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openxbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAnIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newName = new System.Windows.Forms.TextBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pal = new System.Windows.Forms.RadioButton();
            this.ntsc = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // characterList
            // 
            this.characterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characterList.FormattingEnabled = true;
            this.characterList.Items.AddRange(new object[] {
            "A.KU.MU",
            "Beat",
            "Boogie",
            "Clutch",
            "Combo",
            "Corn",
            "Cube",
            "Doom Riders",
            "Garam",
            "Goji",
            "Gum",
            "Jazz ",
            "Love Shockers",
            "NT-3000",
            "Poison Jam",
            "Pots ",
            "Rapid 99",
            "Rhyth",
            "Roboy",
            "Soda",
            "Immortals",
            "Yoyo",
            "Zero Beat"});
            this.characterList.Location = new System.Drawing.Point(6, 19);
            this.characterList.Name = "characterList";
            this.characterList.Size = new System.Drawing.Size(168, 21);
            this.characterList.TabIndex = 1;
            this.characterList.SelectedIndexChanged += new System.EventHandler(this.characterList_SelectedIndexChanged);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openxbeToolStripMenuItem,
            this.closeItem,
            this.exitItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openxbeToolStripMenuItem
            // 
            this.openxbeToolStripMenuItem.Name = "openxbeToolStripMenuItem";
            this.openxbeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.openxbeToolStripMenuItem.Text = "Open .xbe";
            this.openxbeToolStripMenuItem.Click += new System.EventHandler(this.openXbe_Click);
            // 
            // closeItem
            // 
            this.closeItem.Enabled = false;
            this.closeItem.Name = "closeItem";
            this.closeItem.Size = new System.Drawing.Size(127, 22);
            this.closeItem.Text = "Close .xbe";
            this.closeItem.Click += new System.EventHandler(this.closeXbe_Click);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(127, 22);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(204, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportAnIssueToolStripMenuItem,
            this.contactMeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // reportAnIssueToolStripMenuItem
            // 
            this.reportAnIssueToolStripMenuItem.Name = "reportAnIssueToolStripMenuItem";
            this.reportAnIssueToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.reportAnIssueToolStripMenuItem.Text = "Report an Issue";
            this.reportAnIssueToolStripMenuItem.Click += new System.EventHandler(this.reportIssue_Click);
            // 
            // contactMeToolStripMenuItem
            // 
            this.contactMeToolStripMenuItem.Name = "contactMeToolStripMenuItem";
            this.contactMeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.contactMeToolStripMenuItem.Text = "Contact me";
            this.contactMeToolStripMenuItem.Click += new System.EventHandler(this.contactMe_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.about_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.characterList);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Character";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newName);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Name";
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(7, 20);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(167, 20);
            this.newName.TabIndex = 0;
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(13, 225);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(179, 25);
            this.renameButton.TabIndex = 4;
            this.renameButton.Text = "Rename Character";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pal);
            this.groupBox3.Controls.Add(this.ntsc);
            this.groupBox3.Location = new System.Drawing.Point(12, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 49);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Region";
            // 
            // pal
            // 
            this.pal.AutoSize = true;
            this.pal.Location = new System.Drawing.Point(98, 19);
            this.pal.Name = "pal";
            this.pal.Size = new System.Drawing.Size(45, 17);
            this.pal.TabIndex = 1;
            this.pal.TabStop = true;
            this.pal.Text = "PAL";
            this.pal.UseVisualStyleBackColor = true;
            // 
            // ntsc
            // 
            this.ntsc.AutoSize = true;
            this.ntsc.Location = new System.Drawing.Point(24, 19);
            this.ntsc.Name = "ntsc";
            this.ntsc.Size = new System.Drawing.Size(54, 17);
            this.ntsc.TabIndex = 0;
            this.ntsc.TabStop = true;
            this.ntsc.Text = "NTSC";
            this.ntsc.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 262);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "JSRF Renamer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox characterList;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton pal;
        private System.Windows.Forms.RadioButton ntsc;
        private System.Windows.Forms.ToolStripMenuItem openxbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAnIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

