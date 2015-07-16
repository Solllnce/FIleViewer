namespace FIleViewer.View {
    partial class FileDetailsUserControl {
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
            this.fileDetailsDataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.DateModifiedDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.SizeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForDateModified = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSize = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.fileDetailsDataLayoutControl)).BeginInit();
            this.fileDetailsDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateModifiedDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateModifiedDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDateModified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileDetailsDataLayoutControl
            // 
            this.fileDetailsDataLayoutControl.Controls.Add(this.DateModifiedDateEdit);
            this.fileDetailsDataLayoutControl.Controls.Add(this.SizeTextEdit);
            this.fileDetailsDataLayoutControl.DataSource = this.bindingSource1;
            this.fileDetailsDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileDetailsDataLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.fileDetailsDataLayoutControl.Name = "fileDetailsDataLayoutControl";
            this.fileDetailsDataLayoutControl.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.fileDetailsDataLayoutControl.Root = this.layoutControlGroup1;
            this.fileDetailsDataLayoutControl.Size = new System.Drawing.Size(464, 353);
            this.fileDetailsDataLayoutControl.TabIndex = 0;
            this.fileDetailsDataLayoutControl.Text = "dataLayoutControl1";
            // 
            // DateModifiedDateEdit
            // 
            this.DateModifiedDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "DateModified", true));
            this.DateModifiedDateEdit.EditValue = null;
            this.DateModifiedDateEdit.Location = new System.Drawing.Point(93, 12);
            this.DateModifiedDateEdit.Name = "DateModifiedDateEdit";
            this.DateModifiedDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateModifiedDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateModifiedDateEdit.Properties.ReadOnly = true;
            this.DateModifiedDateEdit.Properties.UseReadOnlyAppearance = false;
            this.DateModifiedDateEdit.Size = new System.Drawing.Size(359, 22);
            this.DateModifiedDateEdit.StyleController = this.fileDetailsDataLayoutControl;
            this.DateModifiedDateEdit.TabIndex = 4;
            // 
            // SizeTextEdit
            // 
            this.SizeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Size", true));
            this.SizeTextEdit.Location = new System.Drawing.Point(93, 38);
            this.SizeTextEdit.Name = "SizeTextEdit";
            this.SizeTextEdit.Properties.ReadOnly = true;
            this.SizeTextEdit.Properties.UseReadOnlyAppearance = false;
            this.SizeTextEdit.Size = new System.Drawing.Size(359, 22);
            this.SizeTextEdit.StyleController = this.fileDetailsDataLayoutControl;
            this.SizeTextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(464, 353);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDateModified,
            this.ItemForSize});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(444, 333);
            // 
            // ItemForDateModified
            // 
            this.ItemForDateModified.Control = this.DateModifiedDateEdit;
            this.ItemForDateModified.Location = new System.Drawing.Point(0, 0);
            this.ItemForDateModified.Name = "ItemForDateModified";
            this.ItemForDateModified.Size = new System.Drawing.Size(444, 26);
            this.ItemForDateModified.Text = "Date Modified";
            this.ItemForDateModified.TextSize = new System.Drawing.Size(78, 16);
            // 
            // ItemForSize
            // 
            this.ItemForSize.Control = this.SizeTextEdit;
            this.ItemForSize.Location = new System.Drawing.Point(0, 26);
            this.ItemForSize.Name = "ItemForSize";
            this.ItemForSize.Size = new System.Drawing.Size(444, 307);
            this.ItemForSize.Text = "Size";
            this.ItemForSize.TextSize = new System.Drawing.Size(78, 16);
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(FIleViewer.ViewModel.FileInfo);
            // 
            // FileDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileDetailsDataLayoutControl);
            this.Name = "FileDetailsUserControl";
            this.Size = new System.Drawing.Size(464, 353);
            ((System.ComponentModel.ISupportInitialize)(this.fileDetailsDataLayoutControl)).EndInit();
            this.fileDetailsDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateModifiedDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateModifiedDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDateModified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl fileDetailsDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.DateEdit DateModifiedDateEdit;
        private DevExpress.XtraEditors.TextEdit SizeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDateModified;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSize;
    }
}
