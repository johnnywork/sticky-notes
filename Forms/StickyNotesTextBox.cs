using StickyNotes.Models;
using StickyNotes.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes.Forms
{
    public class StickyNotesTextBox: System.Windows.Forms.RichTextBox
    {
        public delegate void NoteSavedEventHandler(object sender, EventArgs e);
        public event NoteSavedEventHandler NoteSaved;

        private bool BodyModified { get; set; }
        public Note Note { get; set; }
        private NoteService NoteService { get; set; }
        private NoteMetadata NoteMetadataOnLoad { get; set; }

        public StickyNotesTextBox(NoteService noteService, Note note):base() 
        {
            this.Note = note;
            this.NoteService = noteService;
            this.NoteMetadataOnLoad = NoteService.retrieveNoteMetadata(Note);

            this.KeyDown += StickyNotesTextBox_KeyDown;
        }


        private void StickyNotesTextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
            }
            else if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.ControlKey)
                {
                }
                else if (e.KeyCode == Keys.V)
                {
                    this.SelectedText = Clipboard.GetText();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.S)
                {
                    this.save(false);
                }
                else if (e.KeyCode == Keys.B)
                {
                    if (this.SelectionFont != null)
                    {
                        if (this.SelectionFont.Bold)
                        {
                            this.SelectionFont = new Font(this.SelectionFont, this.SelectionFont.Style & ~FontStyle.Bold);
                        }
                        else
                        {
                            this.SelectionFont = new Font(this.SelectionFont, this.SelectionFont.Style | FontStyle.Bold);
                        }
                    }
                }
                else if (e.KeyCode == Keys.U)
                {
                    if (this.SelectionFont != null)
                    {
                        if (this.SelectionFont.Underline)
                        {
                            this.SelectionFont = new Font(this.SelectionFont, this.SelectionFont.Style & ~FontStyle.Underline);
                        }
                        else
                        {
                            this.SelectionFont = new Font(this.SelectionFont, this.SelectionFont.Style | FontStyle.Underline);
                        }
                    }
                }
                else if (e.KeyCode == Keys.I)
                {
                    e.SuppressKeyPress = true;

                    if (this.SelectionFont != null)
                    {
                        if (this.SelectionFont.Italic)
                        {
                            this.SelectionFont = new Font(this.SelectionFont, this.SelectionFont.Style & ~FontStyle.Italic);
                        }
                        else
                        {
                            this.SelectionFont = new Font(this.SelectionFont, this.SelectionFont.Style | FontStyle.Italic);
                        }
                    }
                }
                else if (e.KeyCode == Keys.K)
                {
                    if (this.SelectionFont != null)
                    {
                        if (this.SelectionFont.Strikeout)
                        {
                            this.SelectionFont = new Font(this.SelectionFont, this.SelectionFont.Style & ~FontStyle.Strikeout);
                        }
                        else
                        {
                            this.SelectionFont = new Font(this.SelectionFont, this.SelectionFont.Style | FontStyle.Strikeout);
                        }
                    }
                }
                else if (e.KeyCode == Keys.R)
                {
                    e.SuppressKeyPress = true;

                    if (this.SelectionFont != null)
                    {

                        if (this.SelectionColor == Color.Red)
                        {
                            this.SelectionColor = this.ForeColor;
                        }
                        else
                        {
                            this.SelectionColor = Color.Red;
                        }
                    }
                }
                else if (e.KeyCode == Keys.G)
                {
                    if (this.SelectionFont != null)
                    {
                        if (this.SelectionColor == Color.Green)
                        {
                            this.SelectionColor = this.ForeColor;
                        }
                        else
                        {
                            this.SelectionColor = Color.Green;
                        }
                    }
                }
            }
        }

        private void txtNoteBody_TextChanged(object sender, EventArgs e)
        {
            this.BodyModified = true;
        }

        private void save(bool archive)
        {
            save(archive, true);
        }
        private void save(bool archive, bool isVisible)
        {
            this.Note.NoteBody = this.Text;
            this.Note.NoteBodyRich = this.Rtf;

            if (archive)
            {
                this.NoteService.saveAndArchiveNote(this.Note);
            }
            else
            {
                this.NoteService.saveNote(this.Note);
            }

            NoteMetadata metadata = new NoteMetadata();
            metadata.LastModified = this.BodyModified ? DateTime.Now : this.NoteMetadataOnLoad.LastModified;
            metadata.Note = this.Note;
            metadata.LastLocation = Point.Empty;
            metadata.LastSize = Size.Empty;
            metadata.IsVisible = isVisible;

            this.NoteService.saveNoteMetadata(metadata);

            this.BodyModified = false;

            //this.Text = Note.getTitle() + " [saved on " + DateTime.Now.ToShortTimeString() + "]";
            this.NoteSaved(this, EventArgs.Empty);
        }

    }
}
