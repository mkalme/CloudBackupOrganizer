using System;
using System.Drawing;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class IdInputForm : Form {
        public string Title { get; set; }
        public string Message { get; set; }
        public Image Image { get; set; }
        public string InputText {
            get => TextBox.Text;
            set => TextBox.Text = value;
        }

        public Func<string, bool> Validator { get; set; }
        public Func<string> Generator { get; set; }

        public bool DialogClosed { get; private set; } = true;

        public IdInputForm(string title, string message, string inputText, Image image, Func<string, bool> validator) {
            InitializeComponent();

            Title = title;
            Message = message;
            Image = image;

            InputText = inputText;
            Validator = validator;

            ToolTip.SetToolTip(CopyButton, "Copy text");
            ToolTip.SetToolTip(PasteButton, "Paste text");
        }

        private void TextInputDialog_Load(object sender, EventArgs e) {
            LoadDialog();
        }

        private void LoadDialog() {
            if (Image != null) {
                Icon = ImageToIconConverter.Convert(Image, Image.Width, Image.Height);
                PictureBox.Image = Image;
            } else {
                PictureBox.Visible = false;
            }

            Text = Title;
            MessageLabel.Text = Message;

            TextBox.Select();
            TextBox.SetCursorAtTheEnd();
        }

        private void GenerateButton_Click(object sender, EventArgs e) {
            TextBox.Text = Generator();
        }

        private void CopyButton_Click(object sender, EventArgs e) {
            string text = TextBox.Text;
            if (string.IsNullOrEmpty(text)) text = " ";

            Clipboard.SetText(text);
        }
        private void PasteButton_Click(object sender, EventArgs e) {
            TextBox.Text = Clipboard.GetText();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            if (!Validator(TextBox.Text)) return;

            DialogClosed = false;
            Close();
        }
    }
}
