using StickyNotes.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes.Services
{
    public class NoteFormsHandler
    {
        public Hashtable ActiveNotes { get; set; }

        public NoteFormsHandler()
        {
            ActiveNotes = new Hashtable();
        }

        public void addNoteForm(Note note, Form form)
        {
            if (note == null) { return; }
            ActiveNotes.Add(note.Id, form);
        }

        public void removeNoteForm(Note note, Form form)
        {
            ActiveNotes.Remove(note.Id);
        }

        public bool noteFormExists(Note note)
        {
            return ActiveNotes.ContainsKey(note.Id);
        }

        public Form getForm(Note note)
        {
            if (noteFormExists(note))
            {
                return (Form)ActiveNotes[note.Id];
            }

            return null;
        }

        public Form[] getAllForms()
        {
            Form[] forms = new Form[ActiveNotes.Count];
            ActiveNotes.Values.CopyTo(forms, 0);
            return forms;
        }

        public string[] getNoteIds()
        {
            string[] result = new string[ActiveNotes.Count];
            ActiveNotes.Keys.CopyTo(result, 0);
            return result;
        }

    }
}
