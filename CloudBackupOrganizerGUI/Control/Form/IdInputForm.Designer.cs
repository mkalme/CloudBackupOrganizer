
namespace CloudBackupOrganizerGUI {
    partial class IdInputForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.MessageLabel = new CustomDialogs.DarkLabel();
            this.TextBox = new CustomDialogs.DarkTextBox();
            this.DoneButton = new CustomDialogs.DarkButton();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TextBoxContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PasteButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GenerateButton = new CustomDialogs.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.TextBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MessageLabel.Location = new System.Drawing.Point(8, 9);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(53, 15);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Message";
            this.MessageLabel.UseMnemonic = false;
            // 
            // TextBox
            // 
            this.TextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextBox.Location = new System.Drawing.Point(35, 0);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox.Name = "TextBox";
            this.TextBox.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.TextBox.PasswordChar = '\0';
            this.TextBox.ReadOnly = false;
            this.TextBox.Size = new System.Drawing.Size(389, 24);
            this.TextBox.TabIndex = 1;
            this.TextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextBox.XOffset = 0;
            this.TextBox.YOffset = 0;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DoneButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 95);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(0);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 24);
            this.DoneButton.TabIndex = 2;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(24, 24);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // TextBoxContainer
            // 
            this.TextBoxContainer.ColumnCount = 2;
            this.TextBoxContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TextBoxContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TextBoxContainer.Controls.Add(this.PictureBox, 0, 0);
            this.TextBoxContainer.Controls.Add(this.TextBox, 1, 0);
            this.TextBoxContainer.Location = new System.Drawing.Point(12, 27);
            this.TextBoxContainer.Name = "TextBoxContainer";
            this.TextBoxContainer.RowCount = 1;
            this.TextBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TextBoxContainer.Size = new System.Drawing.Size(424, 24);
            this.TextBoxContainer.TabIndex = 4;
            // 
            // PasteButton
            // 
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PasteButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxPaste;
            this.PasteButton.Location = new System.Drawing.Point(411, 95);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(23, 23);
            this.PasteButton.TabIndex = 6;
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CopyButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxCopyLongText;
            this.CopyButton.Location = new System.Drawing.Point(382, 95);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(23, 23);
            this.CopyButton.TabIndex = 5;
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.GenerateButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GenerateButton.Location = new System.Drawing.Point(361, 54);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(0);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 24);
            this.GenerateButton.TabIndex = 7;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // IdInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(445, 131);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.TextBoxContainer);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.MessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IdInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text input";
            this.Load += new System.EventHandler(this.TextInputDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.TextBoxContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkLabel MessageLabel;
        private CustomDialogs.DarkTextBox TextBox;
        private CustomDialogs.DarkButton DoneButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TableLayoutPanel TextBoxContainer;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private CustomDialogs.DarkButton GenerateButton;
    }
}