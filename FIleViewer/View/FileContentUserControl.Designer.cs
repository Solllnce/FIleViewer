namespace FIleViewer.View {
    partial class FileContentUserControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext();
            this.fileContentMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileContentMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // fileContentMemoEdit
            // 
            this.fileContentMemoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileContentMemoEdit.Location = new System.Drawing.Point(0, 0);
            this.fileContentMemoEdit.Name = "fileContentMemoEdit";
            this.fileContentMemoEdit.Size = new System.Drawing.Size(606, 690);
            this.fileContentMemoEdit.TabIndex = 0;
            // 
            // FileContentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileContentMemoEdit);
            this.Name = "FileContentUserControl";
            this.Size = new System.Drawing.Size(606, 690);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileContentMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.MemoEdit fileContentMemoEdit;
    }
}
