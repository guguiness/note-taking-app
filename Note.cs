using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp {
    internal class Note {
        string title;
        string content;
        bool open;

        public Note() {
            
        }

        public string Title {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Content {
            get { return this.content; }
            set { this.content = value; }
        }

        public bool Open {
            get { return this.open; }
            set { this.open = value; }
        }

        public override string ToString() {
            return this.title;
        }
    }
}
