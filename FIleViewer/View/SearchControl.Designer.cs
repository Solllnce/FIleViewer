namespace FIleViewer.View {
    partial class SearchControl {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            this.searchTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.prevButton = new DevExpress.XtraEditors.SimpleButton();
            this.nextButton = new DevExpress.XtraEditors.SimpleButton();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextEdit
            // 
            this.searchTextEdit.Location = new System.Drawing.Point(16, 14);
            this.searchTextEdit.Name = "searchTextEdit";
            this.searchTextEdit.Size = new System.Drawing.Size(243, 22);
            this.searchTextEdit.TabIndex = 0;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // prevButton
            // 
            this.prevButton.Image = ((System.Drawing.Image)(resources.GetObject("prevButton.Image")));
            this.prevButton.Location = new System.Drawing.Point(265, 13);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(26, 23);
            this.prevButton.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.Location = new System.Drawing.Point(293, 13);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(26, 23);
            this.nextButton.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(293, 42);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Visible = false;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.searchTextEdit);
            this.MaximumSize = new System.Drawing.Size(324, 72);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(324, 72);
            ((System.ComponentModel.ISupportInitialize)(this.searchTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit searchTextEdit;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.SimpleButton nextButton;
        private DevExpress.XtraEditors.SimpleButton prevButton;
    }
}
