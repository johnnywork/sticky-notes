using Microsoft.VisualBasic.Devices;
using StickyNotes.Forms;
using StickyNotes.Models;
using StickyNotes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public partial class frmStickNoteAdvanced : Form
    {

        public Note Note { get; set; }
        public NoteMetadata NoteMetadataOnLoad { get; set; }
        public NoteService NoteService { get; set; }

        public NoteFormsHandler FormsHandler { get; set; }

        private bool BodyModified { get; set; }

        public frmStickNoteAdvanced()
        {
            InitializeComponent();
        }

        private void txtNoteBody_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.saveNoteMetadata(true);
                checkAndHide(false);
            }
            else if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.ControlKey)
                {
                }
                else if (e.KeyCode == Keys.V)
                {
                    txtNoteBody.SelectedText = Clipboard.GetText();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.S)
                {
                    this.save(false);
                }
                else if (e.KeyCode == Keys.B)
                {
                    if (txtNoteBody.SelectionFont != null)
                    {
                        if (txtNoteBody.SelectionFont.Bold)
                        {
                            txtNoteBody.SelectionFont = new Font(txtNoteBody.SelectionFont, txtNoteBody.SelectionFont.Style & ~FontStyle.Bold);
                        }
                        else
                        {
                            txtNoteBody.SelectionFont = new Font(txtNoteBody.SelectionFont, txtNoteBody.SelectionFont.Style | FontStyle.Bold);
                        }
                    }
                }
                else if (e.KeyCode == Keys.U)
                {
                    if (txtNoteBody.SelectionFont != null)
                    {
                        if (txtNoteBody.SelectionFont.Underline)
                        {
                            txtNoteBody.SelectionFont = new Font(txtNoteBody.SelectionFont, txtNoteBody.SelectionFont.Style & ~FontStyle.Underline);
                        }
                        else
                        {
                            txtNoteBody.SelectionFont = new Font(txtNoteBody.SelectionFont, txtNoteBody.SelectionFont.Style | FontStyle.Underline);
                        }
                    }
                }
                else if (e.KeyCode == Keys.I)
                {
                    e.SuppressKeyPress = true;

                    if (txtNoteBody.SelectionFont != null)
                    {
                        if (txtNoteBody.SelectionFont.Italic)
                        {
                            txtNoteBody.SelectionFont = new Font(txtNoteBody.SelectionFont, txtNoteBody.SelectionFont.Style & ~FontStyle.Italic);
                        }
                        else
                        {
                            txtNoteBody.SelectionFont = new Font(txtNoteBody.SelectionFont, txtNoteBody.SelectionFont.Style | FontStyle.Italic);
                        }
                    }
                }
                else if (e.KeyCode == Keys.K)
                {
                    if (txtNoteBody.SelectionFont != null)
                    {
                        if (txtNoteBody.SelectionFont.Strikeout)
                        {
                            txtNoteBody.SelectionFont = new Font(txtNoteBody.SelectionFont, txtNoteBody.SelectionFont.Style & ~FontStyle.Strikeout);
                        }
                        else
                        {
                            txtNoteBody.SelectionFont = new Font(txtNoteBody.SelectionFont, txtNoteBody.SelectionFont.Style | FontStyle.Strikeout);
                        }
                    }
                }
                else if (e.KeyCode == Keys.R)
                {
                    e.SuppressKeyPress= true;

                    if (txtNoteBody.SelectionFont != null)
                    {

                        if (txtNoteBody.SelectionColor == Color.Red)
                        {
                            txtNoteBody.SelectionColor = txtNoteBody.ForeColor;
                        }
                        else
                        {
                            txtNoteBody.SelectionColor = Color.Red;
                        }
                    }                
                }
                else if (e.KeyCode == Keys.G)
                {
                    if (txtNoteBody.SelectionFont != null)
                    {
                        if (txtNoteBody.SelectionColor == Color.Green)
                        {
                            txtNoteBody.SelectionColor = txtNoteBody.ForeColor;
                        }
                        else
                        {
                            txtNoteBody.SelectionColor = Color.Green;
                        }
                    }
                }
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
                this.BackColor = UIStatics.ARCHIVED_BACKCOLOR;
                this.txtNoteBody.BackColor = UIStatics.ARCHIVED_BACKCOLOR;
                this.pnlActions.BackColor = UIStatics.ARCHIVED_BACKCOLOR;
            }
            else
            {
                this.BackColor = UIStatics.REGULAR_BACKCOLOR;
                this.txtNoteBody.BackColor = UIStatics.REGULAR_BACKCOLOR;
                this.pnlActions.BackColor = UIStatics.REGULAR_BACKCOLOR;
            }

            if (this.Note.NoteBodyRich != null)
            {
                this.txtNoteBody.Rtf = this.Note.NoteBodyRich;
            }
            else
            {
                this.txtNoteBody.Text = this.Note.NoteBody;
            }
            this.txtNoteBody.SelectionStart = 0;
            this.Text = Note.getTitle();

            //customize
            this.txtNoteBody.AcceptsTab= true;
            this.txtNoteBody.DetectUrls= true;

            lblNoteId.Text = this.Note.Id;

            this.NoteMetadataOnLoad = NoteService.retrieveNoteMetadata(Note);
            if (this.NoteMetadataOnLoad != null)
            {
                this.Size = this.NoteMetadataOnLoad.LastSize;
                if (this.NoteMetadataOnLoad.LastLocation.X > -10 && this.NoteMetadataOnLoad.LastLocation.Y > 0)
                {
                    this.Location = new Point(this.NoteMetadataOnLoad.LastLocation.X, this.NoteMetadataOnLoad.LastLocation.Y);
                    if (this.Location.X> Screen.AllScreens.Sum(s => s.Bounds.Width) ||
                        this.Location.Y > Screen.AllScreens.Sum(s => s.Bounds.Height))
                    {
                        this.Location = new Point(100, 100);
                    }
                }
            }
            else
            {
                this.NoteMetadataOnLoad = new NoteMetadata();
                this.NoteMetadataOnLoad.LastLocation = this.Location;
                this.NoteMetadataOnLoad.LastModified = DateTime.Now;
                this.NoteMetadataOnLoad.LastSize = this.Size;
                this.NoteMetadataOnLoad.IsVisible = true;
                this.NoteMetadataOnLoad.Note = this.Note;
            }

            this.BodyModified = false;
        }

        private void llbSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.save(false, false);
            this.CloseForm();
        }

        private void llblSaveAndForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.save(true);
            this.CloseForm();
        }

        private void llblSaveAndStay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.save(false, true);
        }

        private void lblNoteId_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(lblNoteId.Text);
        }

        /*****************************************************************************************
         * PRIVATES
         *****************************************************************************************/

        private void checkAndHide(bool closeForm)
        {
            if (!this.BodyModified)
            {
                if (closeForm)
                    this.CloseForm();
                else
                    this.MinimizeForm();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Accept changes ?", "Changes happened", MessageBoxButtons.YesNoCancel);
                if ( dialogResult== DialogResult.Yes)
                {
                    this.save(false);
                    if (closeForm)
                        this.CloseForm();
                    else
                        this.MinimizeForm();
                }
                else if (dialogResult== DialogResult.No)
                {
                    if (closeForm)
                        this.CloseForm();
                    else
                        this.MinimizeForm();
                }
            }
        }

        private void CloseForm()
        {
            this.FormsHandler.removeNoteForm(this.Note, this);
            this.Close();
        }

        private void MinimizeForm()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void save(bool archive)
        {
            save(archive, true);
        }
        private void save(bool archive, bool isVisible)
        {
            this.Note.NoteBody = txtNoteBody.Text;
            this.Note.NoteBodyRich = txtNoteBody.Rtf;

            if (archive)
            {
                this.NoteService.saveAndArchiveNote(this.Note);
            }
            else
            {
                this.NoteService.saveNote(this.Note);
            }

            NoteMetadata metadata = new NoteMetadata();
            metadata.LastModified = this.BodyModified ? DateTime.Now: this.NoteMetadataOnLoad.LastModified;
            metadata.Note = this.Note;
            metadata.LastLocation = this.Location;
            metadata.LastSize = this.Size;
            metadata.IsVisible = isVisible;

            this.NoteService.saveNoteMetadata(metadata);

            this.BodyModified = false;

            this.Text = Note.getTitle() + " [saved on "+DateTime.Now.ToShortTimeString()+"]";
        }

        public void saveNoteMetadata(bool isVisible)
        {
            saveNoteMetadata(isVisible, Point.Empty);
        }
        public void saveNoteMetadata(bool isVisible, Point lastLocation)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                return;
            }

            NoteMetadata metadata = new NoteMetadata();
            metadata.LastModified = this.NoteMetadataOnLoad.LastModified;
            metadata.Note = this.Note;
            if (this.Location.X < -10 && this.Location.Y < 0)
            {
                metadata.LastLocation = lastLocation;
            }
            else
            {
                metadata.LastLocation = this.Location;
            }
            metadata.LastSize = this.Size;
            metadata.IsVisible = isVisible;

            this.NoteService.saveNoteMetadata(metadata);
        }

        private void frmStickNoteAdvanced_Move(object sender, EventArgs e)
        {
            if (!this.Visible)
                return;

            if ((this.NoteMetadataOnLoad.LastLocation.X != this.Location.X) ||
                (this.NoteMetadataOnLoad.LastLocation.Y != this.Location.Y))
            this.saveNoteMetadata(true);
            lblNoteId.Text = this.Note.Id + " [" + this.Location.X + "," + this.Location.Y + "]";
        }

        private void frmStickNoteAdvanced_Resize(object sender, EventArgs e)
        {
            if (!this.Visible)
                return;

            if ((this.NoteMetadataOnLoad.LastSize.Width != this.Size.Width) ||
                (this.NoteMetadataOnLoad.LastSize.Height != this.Size.Height))
                this.saveNoteMetadata(true, this.NoteMetadataOnLoad.LastLocation);
        }

        private void txtNoteBody_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName= e.LinkText;
            Process.Start(psi);
        }
    }
}
