namespace OnTopReplica.SidePanels {
    partial class AboutPanelContents {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelTranslators = new System.Windows.Forms.Label();
            this.linkCredits = new System.Windows.Forms.LinkLabel();
            this.labeledDivider1 = new WindowsFormsAero.LabeledDivider();
            this.linkHomepage = new System.Windows.Forms.LinkLabel();
            this.linkAuthor = new System.Windows.Forms.LinkLabel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.labeledDivider2 = new WindowsFormsAero.LabeledDivider();
            this.linkLicense = new System.Windows.Forms.LinkLabel();
            this.labeledDivider3 = new WindowsFormsAero.LabeledDivider();
            this.linkContribute = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTranslators
            // 
            this.labelTranslators.AutoSize = true;
            this.labelTranslators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTranslators.Location = new System.Drawing.Point(3, 216);
            this.labelTranslators.Name = "labelTranslators";
            this.labelTranslators.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.labelTranslators.Size = new System.Drawing.Size(296, 13);
            this.labelTranslators.TabIndex = 31;
            this.labelTranslators.Text = "Translators:";
            // 
            // linkCredits
            // 
            this.linkCredits.AutoSize = true;
            this.linkCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkCredits.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCredits.Location = new System.Drawing.Point(3, 176);
            this.linkCredits.Name = "linkCredits";
            this.linkCredits.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.linkCredits.Size = new System.Drawing.Size(296, 36);
            this.linkCredits.TabIndex = 30;
            this.linkCredits.TabStop = true;
            this.linkCredits.Text = "%CREDITS%";
            this.linkCredits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCredits_click);
            // 
            // labeledDivider1
            // 
            this.labeledDivider1.DividerColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(222)))));
            this.labeledDivider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeledDivider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labeledDivider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.labeledDivider1.Location = new System.Drawing.Point(3, 153);
            this.labeledDivider1.Name = "labeledDivider1";
            this.labeledDivider1.Size = new System.Drawing.Size(296, 20);
            this.labeledDivider1.TabIndex = 25;
            this.labeledDivider1.Text = global::OnTopReplica.Strings.AboutDividerCredits;
            // 
            // linkHomepage
            // 
            this.linkHomepage.AutoSize = true;
            this.linkHomepage.BackColor = System.Drawing.Color.Transparent;
            this.linkHomepage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkHomepage.Location = new System.Drawing.Point(67, 53);
            this.linkHomepage.Name = "linkHomepage";
            this.linkHomepage.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.linkHomepage.Size = new System.Drawing.Size(167, 17);
            this.linkHomepage.TabIndex = 23;
            this.linkHomepage.TabStop = true;
            this.linkHomepage.Text = "https://github.com/giahoki/OnTopReplica-Refactor";
            this.linkHomepage.UseCompatibleTextRendering = true;
            this.linkHomepage.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkHomepage_clicked);
            // 
            // linkAuthor
            // 
            this.linkAuthor.AutoSize = true;
            this.linkAuthor.BackColor = System.Drawing.Color.Transparent;
            this.linkAuthor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkAuthor.LinkColor = System.Drawing.Color.Blue;
            this.linkAuthor.Location = new System.Drawing.Point(67, 34);
            this.linkAuthor.Name = "linkAuthor";
            this.linkAuthor.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.linkAuthor.Size = new System.Drawing.Size(72, 17);
            this.linkAuthor.TabIndex = 22;
            this.linkAuthor.TabStop = true;
            this.linkAuthor.Text = "%AUTHOR%";
            this.linkAuthor.UseCompatibleTextRendering = true;
            this.linkAuthor.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAuthor_clicked);
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Location = new System.Drawing.Point(67, 0);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(200, 17);
            this.lblSlogan.TabIndex = 24;
            this.lblSlogan.Text = "A lightweight, real-time, always on top thumbnail.";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.lblVersion.Location = new System.Drawing.Point(67, 17);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 13);
            this.lblVersion.TabIndex = 38;
            this.lblVersion.Text = "Version: ";
            // 
            // labeledDivider2
            // 
            this.labeledDivider2.DividerColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(222)))));
            this.labeledDivider2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeledDivider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.labeledDivider2.Location = new System.Drawing.Point(3, 256);
            this.labeledDivider2.Name = "labeledDivider2";
            this.labeledDivider2.Size = new System.Drawing.Size(296, 20);
            this.labeledDivider2.TabIndex = 32;
            this.labeledDivider2.Text = "License";
            // 
            // linkLicense
            // 
            this.linkLicense.AutoSize = true;
            this.linkLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLicense.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLicense.Location = new System.Drawing.Point(3, 279);
            this.linkLicense.Name = "linkLicense";
            this.linkLicense.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.linkLicense.Size = new System.Drawing.Size(296, 36);
            this.linkLicense.TabIndex = 33;
            this.linkLicense.TabStop = true;
            this.linkLicense.Text = "%LICENSE%";
            this.linkLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLicense_click);
            // 
            // labeledDivider3
            // 
            this.labeledDivider3.DividerColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(191)))), ((int)(((byte)(222)))));
            this.labeledDivider3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeledDivider3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(170)))));
            this.labeledDivider3.Location = new System.Drawing.Point(3, 318);
            this.labeledDivider3.Name = "labeledDivider3";
            this.labeledDivider3.Size = new System.Drawing.Size(296, 20);
            this.labeledDivider3.TabIndex = 34;
            this.labeledDivider3.Text = "Contribute";
            // 
            // linkContribute
            // 
            this.linkContribute.AutoSize = true;
            this.linkContribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkContribute.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkContribute.Location = new System.Drawing.Point(3, 341);
            this.linkContribute.Name = "linkContribute";
            this.linkContribute.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.linkContribute.Size = new System.Drawing.Size(296, 36);
            this.linkContribute.TabIndex = 35;
            this.linkContribute.TabStop = true;
            this.linkContribute.Text = "%CONTRIBUTE%";
            this.linkContribute.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkContribute_clicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnTopReplica.Properties.Resources.flat_logo_64;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.headerPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.linkAuthor, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.linkHomepage, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labeledDivider1, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.linkCredits, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelTranslators, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.labeledDivider2, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.linkLicense, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.labeledDivider3, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.linkContribute, 0, 9);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tableLayoutPanel.RowCount = 10;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.Size = new System.Drawing.Size(302, 400);
            this.tableLayoutPanel.TabIndex = 37;
            // 
            // headerPanel
            // 
            this.headerPanel.AutoSize = true;
            this.headerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.lblSlogan);
            this.headerPanel.Controls.Add(this.lblVersion);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(296, 80);
            this.headerPanel.TabIndex = 37;
            // 
            // AboutPanelContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AboutPanelContents";
            this.Size = new System.Drawing.Size(302, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTranslators;
        private System.Windows.Forms.LinkLabel linkCredits;
        private WindowsFormsAero.LabeledDivider labeledDivider1;
        private System.Windows.Forms.LinkLabel linkHomepage;
        private System.Windows.Forms.LinkLabel linkAuthor;
        private System.Windows.Forms.Label lblSlogan;
        private WindowsFormsAero.LabeledDivider labeledDivider2;
        private System.Windows.Forms.LinkLabel linkLicense;
        private WindowsFormsAero.LabeledDivider labeledDivider3;
        private System.Windows.Forms.LinkLabel linkContribute;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel headerPanel;
        internal System.Windows.Forms.Label lblVersion;

    }
}
