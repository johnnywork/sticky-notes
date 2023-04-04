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

namespace StickyNotes.Forms
{
    public partial class frmStickyTab : Form
    {
        public NoteService NoteService { get; set; }

        public frmStickyTab()
        {
            InitializeComponent();
        }

        public void loadNote(Note note)
        {
            TabPage tabPage = createTabPage(note);

            tcNotes.TabPages.Add(tabPage);
            tabPage.Focus();
        }

        private TabPage createTabPage(Note note)
        {
            StickyNotesTextBox richTextBox = createTextBox(note);
            richTextBox.NoteSaved += RichTextBox_NoteSaved;

            TabPage tabPage = new TabPage(note.getTitle());
            tabPage.Controls.Add(richTextBox);
            
            richTextBox.Dock= DockStyle.Fill;
            richTextBox.Tag = tabPage;

            return tabPage;
        }

        private void RichTextBox_NoteSaved(object sender, EventArgs e)
        {
            StickyNotesTextBox stickyNotesTextBox = (StickyNotesTextBox)sender;
            TabPage tabPage = (TabPage) stickyNotesTextBox.Tag;
            tabPage.Text = stickyNotesTextBox.Note.getTitle() + " [saved on " + DateTime.Now.ToShortTimeString() + "]";
        }

        private StickyNotesTextBox createTextBox(Note note)
        {
            StickyNotesTextBox richTextBox = new StickyNotesTextBox(this.NoteService, note);
            //RichTextBox richTextBox = new RichTextBox();

            if (note.IsArchived)
            {
                richTextBox.BackColor = UIStatics.ARCHIVED_BACKCOLOR;
            }
            else
            {
                richTextBox.BackColor = UIStatics.REGULAR_BACKCOLOR;
            }

            if (note.NoteBodyRich != null)
            {
                richTextBox.Rtf = note.NoteBodyRich;
            }
            else
            {
                richTextBox.Text = note.NoteBody;
            }
            richTextBox.SelectionStart = 0;
            this.Text = note.getTitle();

            return richTextBox;
        }
    }
}
