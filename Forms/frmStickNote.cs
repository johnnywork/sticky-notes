using StickyNotes.Models;
using StickyNotes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class frmStickNote : Form
    {
        private Color REGULAR_BACKCOLOR = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        private Color ARCHIVED_BACKCOLOR = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));

        public StickyNotes.Models.Note Note { get; set; }
        public StickyNotes.Services.NoteService NoteService { get; set; }
        public NoteFormsHandler FormsHandler { get; set; }

        private bool BodyModified { get; set; }

        public frmStickNote()
        {
            InitializeComponent();
        }

        private void txtNoteBody_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                checkAndClose();
            }
            else if (e.KeyCode==Keys.S && e.Modifiers == Keys.Control)
            {
                this.save(false);
            }
        }

        private void txtNoteBody_TextChanged(object sender, EventArgs e)
        {
            this.BodyModified = true;
        }

        private void frmStickNote_Load(object sender, EventArgs e)
        {
            if (this.Note.IsArchived)
            {
                this.BackColor = ARCHIVED_BACKCOLOR;
                this.txtNoteBody.BackColor = ARCHIVED_BACKCOLOR;
                this.pnlActions.BackColor = ARCHIVED_BACKCOLOR;
            }
            else
            {
                this.BackColor = REGULAR_BACKCOLOR;
                this.txtNoteBody.BackColor = REGULAR_BACKCOLOR;
                this.pnlActions.BackColor = REGULAR_BACKCOLOR;
            }
            this.txtNoteBody.Text = this.Note.NoteBody;
            this.txtNoteBody.SelectionStart = 0;

            try
            {
                this.Text = this.Note.NoteBody.Split("\r\n")[0];
            }
            catch(Exception ex)
            {
                this.Text = "Note "+Note.Id;
            }

            lblNoteId.Text = this.Note.Id;

            NoteMetadata metadata = NoteService.retrieveNoteMetadata(Note);
            if (metadata != null)
            {
                this.Size = metadata.LastSize;
                this.Location = new Point(metadata.LastLocation.X, metadata.LastLocation.Y);
            }

            this.BodyModified = false;
        }

        private void llbSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.save(false);
            this.CloseForm();
        }

        private void llblSaveAndForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.save(true);
            this.CloseForm();
        }

        private void llblSaveAndStay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.save(false);
        }

        private void lblNoteId_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(lblNoteId.Text);
        }

        private void checkAndClose()
        {
            if (this.BodyModified)
            {
                if (MessageBox.Show("Accept changes ?", "Changes happened", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    this.save(false);
                }
            }

            this.CloseForm();
        }

        private void CloseForm()
        {
            this.FormsHandler.removeNoteForm(this.Note, this);
            this.Close();
        }

        private void save(bool archive)
        {
            this.Note.NoteBody = txtNoteBody.Text;
            if (archive)
            {
                this.NoteService.saveAndArchiveNote(this.Note);
            }
            else
            {
                this.NoteService.saveNote(this.Note);
            }

            NoteMetadata metadata = new NoteMetadata();
            metadata.LastModified = DateTime.Now;
            metadata.Note = Note;
            metadata.LastLocation = this.Location;
            metadata.LastSize = this.Size;

            this.NoteService.saveNoteMetadata(metadata);
        }

    }
}
