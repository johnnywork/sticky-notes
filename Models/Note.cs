using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes.Models
{
    public class Note
    {
        public string Id { get; set; }
        public Boolean IsArchived { get; set; }
        public string? NoteBody { get; set; }
        public string? NoteBodyRich { get; set; }

        private string Title { get; set; }

        public string getTitle()
        {
            if (Title == null)
            {
                try
                {
                    if (NoteBody.IndexOf("\n\n") >= 0)
                    {
                        Title = NoteBody.Split("\n\n")[0];
                    }
                    else if (NoteBody.IndexOf("\r\n") >= 0)
                    {
                        Title = NoteBody.Split("\r\n")[0];
                    }
                    else if (NoteBody.IndexOf("\r") >= 0)
                    {
                        Title = NoteBody.Split("\r")[0];
                    }
                    else
                    {
                        Title = NoteBody;
                    }
                }
                catch (Exception ex)
                {
                    Title = "Note " + Id;
                }
            }
            return Title;
        }
    }
}
