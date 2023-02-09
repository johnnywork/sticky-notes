namespace StickyNotes
{
    partial class frmStickNote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStickNoteAdvanced));
            this.txtNoteBody = new System.Windows.Forms.TextBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.llblSaveAndStay = new System.Windows.Forms.LinkLabel();
            this.llblSaveAndForget = new System.Windows.Forms.LinkLabel();
            this.llbSave = new System.Windows.Forms.LinkLabel();
            this.ttpRootFolder = new System.Windows.Forms.ToolTip(this.components);
            this.lblNoteId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlActions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNoteBody
            // 
            this.txtNoteBody.AcceptsReturn = true;
            this.txtNoteBody.AcceptsTab = true;
            this.txtNoteBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNoteBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoteBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoteBody.Location = new System.Drawing.Point(0, 0);
            this.txtNoteBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoteBody.Multiline = true;
            this.txtNoteBody.Name = "txtNoteBody";
            this.txtNoteBody.Size = new System.Drawing.Size(299, 121);
            this.txtNoteBody.TabIndex = 0;
            this.txtNoteBody.TextChanged += new System.EventHandler(this.txtNoteBody_TextChanged);
            this.txtNoteBody.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoteBody_KeyDown);
            // 
            // pnlActions
            // 
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.llblSaveAndStay);
            this.pnlActions.Controls.Add(this.llblSaveAndForget);
            this.pnlActions.Controls.Add(this.llbSave);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 149);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(299, 23);
            this.pnlActions.TabIndex = 1;
            // 
            // llblSaveAndStay
            // 
            this.llblSaveAndStay.AutoSize = true;
            this.llblSaveAndStay.Location = new System.Drawing.Point(98, 0);
            this.llblSaveAndStay.Name = "llblSaveAndStay";
            this.llblSaveAndStay.Size = new System.Drawing.Size(99, 20);
            this.llblSaveAndStay.TabIndex = 2;
            this.llblSaveAndStay.TabStop = true;
            this.llblSaveAndStay.Text = "Save and stay";
            this.llblSaveAndStay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSaveAndStay_LinkClicked);
            // 
            // llblSaveAndForget
            // 
            this.llblSaveAndForget.AutoSize = true;
            this.llblSaveAndForget.Location = new System.Drawing.Point(192, 0);
            this.llblSaveAndForget.Name = "llblSaveAndForget";
            this.llblSaveAndForget.Size = new System.Drawing.Size(114, 20);
            this.llblSaveAndForget.TabIndex = 1;
            this.llblSaveAndForget.TabStop = true;
            this.llblSaveAndForget.Text = "Save and forget";
            this.llblSaveAndForget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSaveAndForget_LinkClicked);
            // 
            // llbSave
            // 
            this.llbSave.AutoSize = true;
            this.llbSave.Location = new System.Drawing.Point(3, 0);
            this.llbSave.Name = "llbSave";
            this.llbSave.Size = new System.Drawing.Size(107, 20);
            this.llbSave.TabIndex = 0;
            this.llbSave.TabStop = true;
            this.llbSave.Text = "Save and close";
            this.llbSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSave_LinkClicked);
            // 
            // lblNoteId
            // 
            this.lblNoteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoteId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoteId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNoteId.Location = new System.Drawing.Point(0, 0);
            this.lblNoteId.Name = "lblNoteId";
            this.lblNoteId.Size = new System.Drawing.Size(298, 28);
            this.lblNoteId.TabIndex = 2;
            this.lblNoteId.Text = "lbl id";
            this.lblNoteId.DoubleClick += new System.EventHandler(this.lblNoteId_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNoteId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.panel1.Size = new System.Drawing.Size(299, 28);
            this.panel1.TabIndex = 3;
            // 
            // frmStickNoteAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(299, 172);
            this.ControlBox = false;
            this.Controls.Add(this.txtNoteBody);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStickNoteAdvanced";
            this.Text = "StickNoteForm";
            this.Load += new System.EventHandler(this.frmStickNote_Load);
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoteBody;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.LinkLabel llbSave;
        private System.Windows.Forms.LinkLabel llblSaveAndForget;
        private System.Windows.Forms.ToolTip ttpRootFolder;
        private System.Windows.Forms.Label lblNoteId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llblSaveAndStay;
    }
}