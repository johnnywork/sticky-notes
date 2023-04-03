using StickyNotes.Forms;
using StickyNotes.Models;
using StickyNotes.Services;
using StickyNotes.Utils;
using System;
using System.Collections;
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
    public partial class frmMain : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private NoteService noteService;
        private Random random;
        
        public NoteFormsHandler FormsHandler { get; set; }
        public string WorkingFolder { get; set; }
        

        public frmMain()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newNote();
        }

        private void llblShowAllNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            allNotes();
        }

        private void llblShowAllArchivedNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            allArchivedNotes();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (this.WorkingFolder == null)
            {
                this.WorkingFolder = Application.StartupPath;
            }

            this.random = new Random();

            noteService = new NoteService(this.WorkingFolder);
            FormsHandler = new NoteFormsHandler();

            lblRootFolder.Text = PathUtils.pathStartEnd(WorkingFolder);
            ttpRootFolder.SetToolTip(lblRootFolder, this.WorkingFolder);

            initialiseNoteMenuItems();

            ntfMain.Text = "Stiky notes - " + this.WorkingFolder;
            ntfMain.Visible = true;

            showLastActiveNotes();

            showLastActiveNotesInTabControl();
        }

        private void ntfMain_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.Activate();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ntfMain.Visible = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void miAllNotes_Click(object sender, EventArgs e)
        {
            allNotes();
        }
        
        private void miAllArchived_Click(object sender, EventArgs e)
        {
            allArchivedNotes();
        }

        private void miHideAll_Click(object sender, EventArgs e)
        {
            hideAll();
        }

        private void miLastViewed_Click(object sender, EventArgs e)
        {

        }

        private void miExit_Click(object sender, EventArgs e)
        {
            markActiveNotes();
            this.Close();
        }

        private void miNewNote_Click(object sender, EventArgs e)
        {
            newNote();
        }


        private void initialiseNoteMenuItems()
        {
            Note[] allNotes = noteService.retrieveNotes();

            foreach (Note note in allNotes)
            {
                AddMenuItemForNote(note);
            }
        }

        private void newNote()
        {
            StickyNotes.Models.Note note = new StickyNotes.Models.Note();
            note.Id = noteService.createNoteId();

            Form frm = createFormForNote(note, noteService, FormsHandler);
            frm.Show();

            FormsHandler.addNoteForm(note, frm);
        }

        private Form createFormForNote(Note note, NoteService noteService, NoteFormsHandler formsHandler)
        {
            frmStickNoteAdvanced frm = new frmStickNoteAdvanced();
            frm.Note = note;
            frm.NoteService = noteService;
            frm.FormsHandler = formsHandler;

            Point newLocation = new Point(this.random.Next(50, 100), this.random.Next(50, 100));
            frm.Location = newLocation;

            return frm;
        }

        private void allNotes()
        {
            Note[] allNotes = noteService.retrieveNotes();
            foreach (Note note in allNotes)
            {
                CreateOrActivateForm(note);
            }

        }

        private bool ActivateFormForNote(Note note)
        {
            if (FormsHandler.noteFormExists(note))
            {
                Form f = FormsHandler.getForm(note);
                f.WindowState = FormWindowState.Normal;
                f.Show();
                f.Activate();
                
                return true;
            }

            return false;
        }

        private void AddMenuItemForNote(Note note)
        {
            ToolStripItem item = new ToolStripMenuItem();
            item.Text = note.getTitle();
            item.Click += Item_Click;
            item.Tag = note;
            item.Font = new Font(item.Font.Name, 7);

            if (miShowSpecific.DropDownItems.Count % 2 == 1)
            {
                item.BackColor = Color.LightGoldenrodYellow;
            }
            else
            {
                item.BackColor = Color.LightGray;
            }

            miShowSpecific.DropDownItems.Add(item);
        }

        private void Item_Click(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                Note note = (Note)item.Tag;
                CreateOrActivateForm(note);
            }
        }

        private void CreateOrActivateForm(Note note)
        {
            if (ActivateFormForNote(note))
            {
                return;
            }

            Form frm = createFormForNote(note, noteService, FormsHandler);
            frm.Show();

            FormsHandler.addNoteForm(note, frm);
        }

        private void allArchivedNotes()
        {
            Note[] allNotes = noteService.retrieveArchivedNotes();
            foreach (Note note in allNotes)
            {
                Form frm = createFormForNote(note, noteService, FormsHandler);

                frm.Show();
            }
        }

        private void hideAll()
        {
            Form[] forms =FormsHandler.getAllForms();
            foreach (Form f in forms)
            {
                f.Hide();
                //f.WindowState = FormWindowState.Minimized;
            }
        }

        private void markActiveNotes()
        {
            Note[] allNotes = noteService.retrieveNotes();
            string[] noteIds = FormsHandler.getNoteIds();

            foreach(string noteId in noteIds)
            {
                foreach(Note note in allNotes)
                {
                    if (note.Id == noteId)
                    {
                        frmStickNoteAdvanced frm = (frmStickNoteAdvanced) FormsHandler.getForm(note);
                        frm.saveNoteMetadata(true);
                    }
                }
            }
        }

        private void showLastActiveNotes()
        {
            Note[] allNotes = noteService.retrieveNotes();
            foreach (Note note in allNotes)
            {
                NoteMetadata noteMetadata = noteService.retrieveNoteMetadata(note);
                if (noteMetadata != null && noteMetadata.IsVisible)
                {
                    CreateOrActivateForm(note);
                }
            }

        }

        private void showLastActiveNotesInTabControl()
        {
            frmStickyTab frmTabs = new frmStickyTab();
            Note[] allNotes = noteService.retrieveNotes();
            foreach (Note note in allNotes)
            {
                NoteMetadata noteMetadata = noteService.retrieveNoteMetadata(note);
                if (noteMetadata != null && noteMetadata.IsVisible)
                {
                    frmTabs.loadNote(note);
                }
            }

            frmTabs.Show();
            frmTabs.Activate();
        }

    }
}
