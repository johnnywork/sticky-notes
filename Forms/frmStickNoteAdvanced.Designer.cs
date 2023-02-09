namespace StickyNotes
{
    partial class frmStickNoteAdvanced
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
            this.pnlActions = new System.Windows.Forms.Panel();
            this.llblSaveAndStay = new System.Windows.Forms.LinkLabel();
            this.llblSaveAndForget = new System.Windows.Forms.LinkLabel();
            this.llbSave = new System.Windows.Forms.LinkLabel();
            this.ttpRootFolder = new System.Windows.Forms.ToolTip(this.components);
            this.lblNoteId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNoteBody = new System.Windows.Forms.RichTextBox();
            this.pnlActions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlActions
            // 
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.llblSaveAndStay);
            this.pnlActions.Controls.Add(this.llblSaveAndForget);
            this.pnlActions.Controls.Add(this.llbSave);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 98);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(292, 18);
            this.pnlActions.TabIndex = 1;
            // 
            // llblSaveAndStay
            // 
            this.llblSaveAndStay.AutoSize = true;
            this.llblSaveAndStay.Location = new System.Drawing.Point(94, 0);
            this.llblSaveAndStay.Name = "llblSaveAndStay";
            this.llblSaveAndStay.Size = new System.Drawing.Size(78, 15);
            this.llblSaveAndStay.TabIndex = 2;
            this.llblSaveAndStay.TabStop = true;
            this.llblSaveAndStay.Text = "Save and stay";
            this.llblSaveAndStay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSaveAndStay_LinkClicked);
            // 
            // llblSaveAndForget
            // 
            this.llblSaveAndForget.AutoSize = true;
            this.llblSaveAndForget.Location = new System.Drawing.Point(179, 0);
            this.llblSaveAndForget.Name = "llblSaveAndForget";
            this.llblSaveAndForget.Size = new System.Drawing.Size(89, 15);
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
            this.llbSave.Size = new System.Drawing.Size(84, 15);
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
            this.lblNoteId.Size = new System.Drawing.Size(289, 20);
            this.lblNoteId.TabIndex = 2;
            this.lblNoteId.Text = "lbl id";
            this.lblNoteId.DoubleClick += new System.EventHandler(this.lblNoteId_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNoteId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.panel1.Size = new System.Drawing.Size(292, 22);
            this.panel1.TabIndex = 3;
            // 
            // txtNoteBody
            // 
            this.txtNoteBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNoteBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoteBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoteBody.Location = new System.Drawing.Point(0, 0);
            this.txtNoteBody.Name = "txtNoteBody";
            this.txtNoteBody.Size = new System.Drawing.Size(292, 76);
            this.txtNoteBody.TabIndex = 4;
            this.txtNoteBody.Text = "";
            this.txtNoteBody.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtNoteBody_LinkClicked);
            this.txtNoteBody.TextChanged += new System.EventHandler(this.txtNoteBody_TextChanged);
            this.txtNoteBody.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoteBody_KeyDown);
            // 
            // frmStickNoteAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(292, 116);
            this.ControlBox = false;
            this.Controls.Add(this.txtNoteBody);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStickNoteAdvanced";
            this.Text = "StickNoteForm";
            this.Load += new System.EventHandler(this.frmStickNote_Load);
            this.Move += new System.EventHandler(this.frmStickNoteAdvanced_Move);
            this.Resize += new System.EventHandler(this.frmStickNoteAdvanced_Resize);
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.LinkLabel llbSave;
        private System.Windows.Forms.LinkLabel llblSaveAndForget;
        private System.Windows.Forms.ToolTip ttpRootFolder;
        private System.Windows.Forms.Label lblNoteId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llblSaveAndStay;
        private System.Windows.Forms.RichTextBox txtNoteBody;
    }
}