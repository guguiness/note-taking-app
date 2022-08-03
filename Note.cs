using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp {
    internal class Note {
        string title;
        string content;

        public string Title {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Content {
            get { return this.content; }
            set { this.content = value; }
        }

        public override string ToString() {
            return this.title;
        }
    }
}
