using System;

namespace EncryptedNotesApp.Models
{
    public class Note
    {
        public string Title { get; set; }
        public string EncryptedContent { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}