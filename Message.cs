﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp {
    internal class Message {
        string title;
        string content;

        public Message(string title, string content) {
            this.title = title;
            this.content = content;
        }

        public string Title {
            get { return this.title; }
            set { this.title = value; }
        }
    }
}
