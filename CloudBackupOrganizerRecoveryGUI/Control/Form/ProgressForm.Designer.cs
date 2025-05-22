
namespace CloudBackupOrganizerRecoveryGUI {
    partial class ProgressForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            this.UploadingTitleTimer = new System.Windows.Forms.Timer(this.components);
            this.ProgressPanel = new CustomDialogs.ProgressPanel();
            this.SuspendLayout();
            // 
            // UploadingTitleTimer
            // 
            this.UploadingTitleTimer.Tick += new System.EventHandler(this.UploadingTitleTimer_Tick);
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ProgressPanel.Location = new System.Drawing.Point(9, 10);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.OriginalActivityTypeText = "";
            this.ProgressPanel.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(196)))), ((int)(((byte)(150)))));
            this.ProgressPanel.Size = new System.Drawing.Size(370, 57);
            this.ProgressPanel.TabIndex = 6;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(388, 80);
            this.Controls.Add(this.ProgressPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extracting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer UploadingTitleTimer;
        private CustomDialogs.ProgressPanel ProgressPanel;
    }
}