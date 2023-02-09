namespace StickyNotes
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.llblAddNewNote = new System.Windows.Forms.LinkLabel();
            this.llblShowAllNotes = new System.Windows.Forms.LinkLabel();
            this.llblShowAllArchivedNotes = new System.Windows.Forms.LinkLabel();
            this.lblRootFolder = new System.Windows.Forms.Label();
            this.ttpRootFolder = new System.Windows.Forms.ToolTip(this.components);
            this.ntfMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAllNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.miAllArchived = new System.Windows.Forms.ToolStripMenuItem();
            this.miHideAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewNote = new System.Windows.Forms.ToolStripMenuItem();
            this.miLastViewed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miShowSpecific = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // llblAddNewNote
            // 
            this.llblAddNewNote.AutoSize = true;
            this.llblAddNewNote.Location = new System.Drawing.Point(94, 4);
            this.llblAddNewNote.Name = "llblAddNewNote";
            this.llblAddNewNote.Size = new System.Drawing.Size(102, 20);
            this.llblAddNewNote.TabIndex = 0;
            this.llblAddNewNote.TabStop = true;
            this.llblAddNewNote.Text = "Add new note";
            this.llblAddNewNote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // llblShowAllNotes
            // 
            this.llblShowAllNotes.AutoSize = true;
            this.llblShowAllNotes.Location = new System.Drawing.Point(14, 4);
            this.llblShowAllNotes.Name = "llblShowAllNotes";
            this.llblShowAllNotes.Size = new System.Drawing.Size(67, 20);
            this.llblShowAllNotes.TabIndex = 1;
            this.llblShowAllNotes.TabStop = true;
            this.llblShowAllNotes.Text = "All notes";
            this.llblShowAllNotes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowAllNotes_LinkClicked);
            // 
            // llblShowAllArchivedNotes
            // 
            this.llblShowAllArchivedNotes.AutoSize = true;
            this.llblShowAllArchivedNotes.Location = new System.Drawing.Point(94, 31);
            this.llblShowAllArchivedNotes.Name = "llblShowAllArchivedNotes";
            this.llblShowAllArchivedNotes.Size = new System.Drawing.Size(127, 20);
            this.llblShowAllArchivedNotes.TabIndex = 2;
            this.llblShowAllArchivedNotes.TabStop = true;
            this.llblShowAllArchivedNotes.Text = "All archived notes";
            this.llblShowAllArchivedNotes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowAllArchivedNotes_LinkClicked);
            // 
            // lblRootFolder
            // 
            this.lblRootFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRootFolder.Location = new System.Drawing.Point(0, 63);
            this.lblRootFolder.Name = "lblRootFolder";
            this.lblRootFolder.Size = new System.Drawing.Size(223, 20);
            this.lblRootFolder.TabIndex = 3;
            // 
            // ntfMain
            // 
            this.ntfMain.ContextMenuStrip = this.cmsMain;
            this.ntfMain.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfMain.Icon")));
            this.ntfMain.Text = "Sticky notes";
            this.ntfMain.Visible = true;
            this.ntfMain.DoubleClick += new System.EventHandler(this.ntfMain_DoubleClick);
            // 
            // cmsMain
            // 
            this.cmsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAllNotes,
            this.miAllArchived,
            this.miShowSpecific,
            this.miHideAll,
            this.toolStripMenuItem2,
            this.miNewNote,
            this.miLastViewed,
            this.toolStripMenuItem3,
            this.miExit});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(195, 220);
            // 
            // miAllNotes
            // 
            this.miAllNotes.Name = "miAllNotes";
            this.miAllNotes.Size = new System.Drawing.Size(194, 24);
            this.miAllNotes.Text = "Show all";
            this.miAllNotes.Click += new System.EventHandler(this.miAllNotes_Click);
            // 
            // miAllArchived
            // 
            this.miAllArchived.Name = "miAllArchived";
            this.miAllArchived.Size = new System.Drawing.Size(194, 24);
            this.miAllArchived.Text = "Show all archived";
            this.miAllArchived.Click += new System.EventHandler(this.miAllArchived_Click);
            // 
            // miHideAll
            // 
            this.miHideAll.Name = "miHideAll";
            this.miHideAll.Size = new System.Drawing.Size(194, 24);
            this.miHideAll.Text = "Hide all";
            this.miHideAll.Click += new System.EventHandler(this.miHideAll_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(194, 24);
            this.toolStripMenuItem2.Text = "---";
            // 
            // miNewNote
            // 
            this.miNewNote.Name = "miNewNote";
            this.miNewNote.Size = new System.Drawing.Size(194, 24);
            this.miNewNote.Text = "Add new";
            this.miNewNote.Click += new System.EventHandler(this.miNewNote_Click);
            // 
            // miLastViewed
            // 
            this.miLastViewed.Name = "miLastViewed";
            this.miLastViewed.Size = new System.Drawing.Size(194, 24);
            this.miLastViewed.Text = "Last viewed";
            this.miLastViewed.Click += new System.EventHandler(this.miLastViewed_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(194, 24);
            this.toolStripMenuItem3.Text = "---";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(194, 24);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miShowSpecific
            // 
            this.miShowSpecific.Name = "miShowSpecific";
            this.miShowSpecific.Size = new System.Drawing.Size(194, 24);
            this.miShowSpecific.Text = "Show...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(223, 83);
            this.Controls.Add(this.lblRootFolder);
            this.Controls.Add(this.llblShowAllArchivedNotes);
            this.Controls.Add(this.llblShowAllNotes);
            this.Controls.Add(this.llblAddNewNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sticky Notes";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblAddNewNote;
        private System.Windows.Forms.LinkLabel llblShowAllNotes;
        private System.Windows.Forms.LinkLabel llblShowAllArchivedNotes;
        private System.Windows.Forms.Label lblRootFolder;
        private System.Windows.Forms.ToolTip ttpRootFolder;
        private System.Windows.Forms.NotifyIcon ntfMain;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem miAllNotes;
        private System.Windows.Forms.ToolStripMenuItem miAllArchived;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miNewNote;
        private System.Windows.Forms.ToolStripMenuItem miLastViewed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem miHideAll;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miShowSpecific;
    }
}
