using StickyNotes.Models;
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
            RichTextBox richTextBox = createTextBox(note);

            TabPage tabPage = new TabPage(note.getTitle());
            tabPage.Controls.Add(richTextBox);
            richTextBox.Dock= DockStyle.Fill;

            return tabPage;
        }

        private RichTextBox createTextBox(Note note)
        {
            RichTextBox richTextBox = new RichTextBox();

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
