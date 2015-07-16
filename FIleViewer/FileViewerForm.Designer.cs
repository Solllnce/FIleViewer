namespace FIleViewer {
    partial class FileViewerForm {
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.filesUserControl1 = new FIleViewer.FilesUserControl();
            this.fileDetailsUserControl1 = new FIleViewer.View.FileDetailsUserControl();
            this.fileContentUserControl1 = new FIleViewer.View.FileContentUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.MinSize = 300;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.fileContentUserControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1030, 583);
            this.splitContainerControl1.SplitterPosition = 385;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.filesUserControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.fileDetailsUserControl1);
            this.splitContainerControl2.Panel2.MinSize = 150;
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(385, 583);
            this.splitContainerControl2.SplitterPosition = 439;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // filesUserControl1
            // 
            this.filesUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesUserControl1.Location = new System.Drawing.Point(0, 0);
            this.filesUserControl1.Name = "filesUserControl1";
            this.filesUserControl1.Size = new System.Drawing.Size(385, 421);
            this.filesUserControl1.TabIndex = 0;
            // 
            // fileDetailsUserControl1
            // 
            this.fileDetailsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileDetailsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.fileDetailsUserControl1.Name = "fileDetailsUserControl1";
            this.fileDetailsUserControl1.Size = new System.Drawing.Size(385, 150);
            this.fileDetailsUserControl1.TabIndex = 0;
            // 
            // fileContentUserControl1
            // 
            this.fileContentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileContentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.fileContentUserControl1.MaximumSize = new System.Drawing.Size(633, 583);
            this.fileContentUserControl1.MinimumSize = new System.Drawing.Size(633, 583);
            this.fileContentUserControl1.Name = "fileContentUserControl1";
            this.fileContentUserControl1.Size = new System.Drawing.Size(633, 583);
            this.fileContentUserControl1.TabIndex = 0;
            // 
            // FileViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 583);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FileViewerForm";
            this.Text = "File Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private FilesUserControl filesUserControl1;
        private View.FileDetailsUserControl fileDetailsUserControl1;
        private View.FileContentUserControl fileContentUserControl1;



    }
}

