using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EncryptedNotesApp.Models;
using EncryptedNotesApp.Services;

namespace EncryptedNotesApp.Forms
{
    public partial class MainForm : Form
    {
        private List<Note> notes = new List<Note>();

        public MainForm()
        {
            InitializeComponent();

            Console.WriteLine("=== Тестування шифрування ===");
            EncryptionService.TestEncryption();

            LoadNotes();
        }

        private void LoadNotes()
        {
            notes = FileService.LoadNotes();
            listBoxNotes.Items.Clear();
            foreach (var note in notes)
            {
                listBoxNotes.Items.Add(note.Title);
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            using (var addNoteForm = new AddNoteForm())
            {
                var result = addNoteForm.ShowDialog();
                if (result == DialogResult.OK && addNoteForm.Note != null)
                {
                    notes.Add(addNoteForm.Note);
                    FileService.SaveNotes(notes);
                    LoadNotes();
                }
            }
        }

        private void btnViewNote_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex >= 0)
            {
                var note = notes[listBoxNotes.SelectedIndex];
                Console.WriteLine($"Перегляд: {note.Title} -> {note.EncryptedContent}");

                if (string.IsNullOrEmpty(note.EncryptedContent))
                {
                    MessageBox.Show("Нотатка порожня або не була зашифрована!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    string decryptedContent = EncryptionService.Decrypt(note.EncryptedContent);
                    Console.WriteLine($"Розшифровано: {decryptedContent}");

                    string message = $"Заголовок: {note.Title}\n\n" +
                                    $"Розшифрований вміст:\n{decryptedContent}\n\n" +
                                    $"Зашифрований вміст:\n{note.EncryptedContent}";

                    MessageBox.Show(message, "Перегляд нотатки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при розшифруванні: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Виберіть нотатку для перегляду!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}