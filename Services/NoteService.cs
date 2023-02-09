using StickyNotes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StickyNotes.Services
{
    public class NoteService
    {
        private const string FILE_EXTENTION_REGULAR = ".sntxt";
        private const string FILE_EXTENTION_REGULAR_RICH = ".snrtf";
        private const string FILE_EXTENTION_ARCHIVED = ".snarc";
        private const string FILE_EXTENTION_METADATA = ".snmeta";

        private XmlSerializer NoteSerializer { get; set; }

        public string RootFolder { get; set; }

        public NoteService(string rootFolder)
        {
            RootFolder = rootFolder;

            this.NoteSerializer = new XmlSerializer(typeof(NoteMetadata));
        }

        public void saveNote(Note note)
        {
            string filepath = Path.Combine(RootFolder, note.Id + FILE_EXTENTION_REGULAR);
            File.WriteAllText(filepath, note.NoteBody);

            filepath = Path.Combine(RootFolder, note.Id + FILE_EXTENTION_REGULAR_RICH);
            File.WriteAllText(filepath, note.NoteBodyRich);
        }

        public void saveAndArchiveNote(Note note)
        {
            string filepath = Path.Combine(RootFolder, note.Id + FILE_EXTENTION_ARCHIVED);
            File.WriteAllText(filepath, note.NoteBody);

            filepath = Path.Combine(RootFolder, note.Id + FILE_EXTENTION_REGULAR_RICH);
            File.WriteAllText(filepath, note.NoteBodyRich);

            filepath = Path.Combine(RootFolder, note.Id + FILE_EXTENTION_REGULAR);
            File.Delete(filepath);
        }

        public void saveNoteMetadata(NoteMetadata metadata)
        {
            string filepath = Path.Combine(RootFolder, metadata.Note.Id + FILE_EXTENTION_METADATA);
            File.WriteAllText(filepath, this.getMetadataContent(metadata));
        }

        public NoteMetadata retrieveNoteMetadata(Note note)
        {
            string filepath = Path.Combine(RootFolder, note.Id + FILE_EXTENTION_METADATA);
            if (File.Exists(filepath))
            {
                string content = File.ReadAllText(filepath);
                return getMetadata(content);
            }
            return null;
        }


        public String createNoteId()
        {
            return Guid.NewGuid().ToString();
        }

        public Note[] retrieveNotes()
        {
            return retrieveNotesByExtention(FILE_EXTENTION_REGULAR);
        }

        public Note[] retrieveArchivedNotes()
        {
            return retrieveNotesByExtention(FILE_EXTENTION_ARCHIVED);
        }

        /* PRIVATES */

        private Note[] retrieveNotesByExtention(string extention)
        {
            List<Note> notes = new List<Note>();
            string[] localNotes = Directory.GetFiles(RootFolder, "*" + extention);
            foreach (var filePath in localNotes)
            {
                Note note = new Note();
                note.Id = extractId(filePath);
                note.IsArchived = extention == FILE_EXTENTION_ARCHIVED;
                note.NoteBody = File.ReadAllText(filePath);

                if (!note.IsArchived)
                {
                    string d1 = Path.GetDirectoryName(filePath);
                    string f1 = Path.GetFileNameWithoutExtension(filePath);
                    f1 = f1 + FILE_EXTENTION_REGULAR_RICH;
                    string f2 = Path.Combine(d1, f1);

                    if (File.Exists(f2))
                    {
                        note.NoteBodyRich = File.ReadAllText(f2);
                    }
                }

                notes.Add(note);
            }

            return notes.ToArray();
        }

        private string extractId(string filepath)
        {
            return Path.GetFileName(filepath).Replace(FILE_EXTENTION_REGULAR, "").Replace(FILE_EXTENTION_ARCHIVED, "");
        }

        private string getMetadataContent(NoteMetadata metadata)
        {
            StringWriter sw = new StringWriter();
            this.NoteSerializer.Serialize(sw, metadata);
            return sw.ToString();
        }
        private NoteMetadata getMetadata(string metadata)
        {
            TextReader tr = new StringReader(metadata);
            return (NoteMetadata) this.NoteSerializer.Deserialize(tr);            
        }
    }
}
