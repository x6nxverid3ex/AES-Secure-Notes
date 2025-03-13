using System.Collections.Generic;
using System.IO;
using EncryptedNotesApp.Models;
using Newtonsoft.Json;

namespace EncryptedNotesApp.Services
{
    public static class FileService
    {
        private static readonly string FilePath = "notes.json";

        public static void SaveNotes(List<Note> notes)
        {
            string json = JsonConvert.SerializeObject(notes, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static List<Note> LoadNotes()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<Note>>(json);
            }
            return new List<Note>();
        }
    }
}