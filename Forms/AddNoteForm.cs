using System;
using System.Windows.Forms;
using EncryptedNotesApp.Models;
using EncryptedNotesApp.Services;

namespace EncryptedNotesApp.Forms
{
    public partial class AddNoteForm : Form
    {
        public Note Note { get; private set; }

        public AddNoteForm()
        {
            InitializeComponent();
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text == "Введіть назву")
            {
                txtTitle.Text = "";
                txtTitle.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                txtTitle.Text = "Введіть назву";
                txtTitle.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtContent_Enter(object sender, EventArgs e)
        {
            if (txtContent.Text == "Введіть вміст")
            {
                txtContent.Text = "";
                txtContent.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtContent_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                txtContent.Text = "Введіть вміст";
                txtContent.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text?.Trim();
            string content = txtContent.Text?.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Введіть назву та вміст нотатки!", "Помилка");
                return;
            }

            string encryptedContent = EncryptionService.Encrypt(content);
            Note = new Note
            {
                Title = title,
                EncryptedContent = encryptedContent,
                CreatedAt = DateTime.Now
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}