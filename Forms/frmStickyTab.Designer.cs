﻿namespace StickyNotes.Forms
{
    partial class frmStickyTab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcNotes = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 0;
            // 
            // tcNotes
            // 
            this.tcNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcNotes.Location = new System.Drawing.Point(0, 0);
            this.tcNotes.Name = "tcNotes";
            this.tcNotes.SelectedIndex = 0;
            this.tcNotes.Size = new System.Drawing.Size(800, 389);
            this.tcNotes.TabIndex = 1;
            // 
            // frmStickyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcNotes);
            this.Controls.Add(this.panel1);
            this.Name = "frmStickyTab";
            this.Text = "frmStickyTab";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcNotes;
    }
}