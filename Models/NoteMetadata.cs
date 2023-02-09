using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StickyNotes.Models
{
    public class NoteMetadata
    { 
        [XmlIgnore]
        public Note Note { get; set; }

        public Point LastLocation { get; set; }

        public Size LastSize { get; set; }

        public DateTime LastModified { get; set; }

        public bool IsVisible { get; set; }
    }
}
