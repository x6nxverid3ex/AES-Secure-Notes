namespace EncryptedNotesApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnViewNote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNoteContent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnViewNote = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNoteContent = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // listBoxNotes
            this.listBoxNotes.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.listBoxNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxNotes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listBoxNotes.ForeColor = System.Drawing.Color.White;
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.ItemHeight = 17;
            this.listBoxNotes.Location = new System.Drawing.Point(20, 60);
            this.listBoxNotes.Size = new System.Drawing.Size(340, 240);
            this.listBoxNotes.TabIndex = 0;

            // btnAddNote
            this.btnAddNote.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNote.ForeColor = System.Drawing.Color.White;
            this.btnAddNote.Location = new System.Drawing.Point(20, 320);
            this.btnAddNote.Size = new System.Drawing.Size(160, 40);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "Додати";
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);

            // btnViewNote
            this.btnViewNote.BackColor = System.Drawing.Color.Teal;
            this.btnViewNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnViewNote.ForeColor = System.Drawing.Color.White;
            this.btnViewNote.Location = new System.Drawing.Point(200, 320);
            this.btnViewNote.Size = new System.Drawing.Size(160, 40);
            this.btnViewNote.TabIndex = 2;
            this.btnViewNote.Text = "Переглянути";
            this.btnViewNote.UseVisualStyleBackColor = false;
            this.btnViewNote.Click += new System.EventHandler(this.btnViewNote_Click);

            // panel1
            this.panel1.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Size = new System.Drawing.Size(380, 50);
            this.panel1.TabIndex = 3;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Зашифровані нотатки";

            // txtNoteContent
            this.txtNoteContent.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.txtNoteContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoteContent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNoteContent.ForeColor = System.Drawing.Color.White;
            this.txtNoteContent.Location = new System.Drawing.Point(20, 60);
            this.txtNoteContent.Multiline = true;
            this.txtNoteContent.Size = new System.Drawing.Size(340, 240);
            this.txtNoteContent.TabIndex = 3;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(380, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxNotes);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.btnViewNote);
            this.Controls.Add(this.txtNoteContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Зашифровані нотатки";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}