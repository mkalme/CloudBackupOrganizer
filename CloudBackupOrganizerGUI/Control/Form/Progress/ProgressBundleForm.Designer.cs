
namespace CloudBackupOrganizerGUI {
    partial class ProgressBundleForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBundleForm));
            this.MainProgressPanel = new CustomDialogs.ProgressPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubProgressPanel = new CustomDialogs.ProgressPanel();
            this.UploadingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MainProgressPanel
            // 
            this.MainProgressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MainProgressPanel.Location = new System.Drawing.Point(9, 13);
            this.MainProgressPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainProgressPanel.Name = "MainProgressPanel";
            this.MainProgressPanel.OriginalActivityTypeText = "";
            this.MainProgressPanel.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(196)))), ((int)(((byte)(150)))));
            this.MainProgressPanel.Size = new System.Drawing.Size(383, 66);
            this.MainProgressPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 1);
            this.panel1.TabIndex = 2;
            // 
            // SubProgressPanel
            // 
            this.SubProgressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SubProgressPanel.Location = new System.Drawing.Point(9, 88);
            this.SubProgressPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SubProgressPanel.Name = "SubProgressPanel";
            this.SubProgressPanel.OriginalActivityTypeText = "";
            this.SubProgressPanel.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(196)))), ((int)(((byte)(150)))));
            this.SubProgressPanel.Size = new System.Drawing.Size(383, 66);
            this.SubProgressPanel.TabIndex = 3;
            // 
            // UploadingTimer
            // 
            this.UploadingTimer.Tick += new System.EventHandler(this.UploadingTimer_Tick);
            // 
            // ProgressBundleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(401, 156);
            this.Controls.Add(this.SubProgressPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainProgressPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProgressBundleForm";
            this.Padding = new System.Windows.Forms.Padding(9, 13, 9, 9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProgressBundle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressBundleView_FormClosing);
            this.Load += new System.EventHandler(this.ProgressBundleView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDialogs.ProgressPanel MainProgressPanel;
        private System.Windows.Forms.Panel panel1;
        private CustomDialogs.ProgressPanel SubProgressPanel;
        private System.Windows.Forms.Timer UploadingTimer;
    }
}