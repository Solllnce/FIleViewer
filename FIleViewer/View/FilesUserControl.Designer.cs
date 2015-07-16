namespace FIleViewer {
    partial class FilesUserControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesUserControl));
            this.directoryComboBox = new System.Windows.Forms.ComboBox();
            this.filesGridControl = new DevExpress.XtraGrid.GridControl();
            this.filesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.tokenEdit1 = new DevExpress.XtraEditors.TokenEdit();
            this.showFilesButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // directoryComboBox
            // 
            this.directoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.directoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.directoryComboBox.FormattingEnabled = true;
            this.directoryComboBox.Location = new System.Drawing.Point(126, 90);
            this.directoryComboBox.Name = "directoryComboBox";
            this.directoryComboBox.Size = new System.Drawing.Size(279, 24);
            this.directoryComboBox.TabIndex = 4;
            // 
            // filesGridControl
            // 
            this.filesGridControl.Location = new System.Drawing.Point(12, 126);
            this.filesGridControl.MainView = this.filesGridView;
            this.filesGridControl.Name = "filesGridControl";
            this.filesGridControl.Size = new System.Drawing.Size(488, 607);
            this.filesGridControl.TabIndex = 5;
            this.filesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.filesGridView});
            // 
            // filesGridView
            // 
            this.filesGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.filesGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.filesGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.filesGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.filesGridView.GridControl = this.filesGridControl;
            this.filesGridView.Name = "filesGridView";
            this.filesGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.filesGridView.OptionsBehavior.Editable = false;
            this.filesGridView.OptionsView.ShowColumnHeaders = false;
            this.filesGridView.OptionsView.ShowGroupPanel = false;
            this.filesGridView.OptionsView.ShowIndicator = false;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.searchButton);
            this.layoutControl1.Controls.Add(this.tokenEdit1);
            this.layoutControl1.Controls.Add(this.showFilesButton);
            this.layoutControl1.Controls.Add(this.filesGridControl);
            this.layoutControl1.Controls.Add(this.directoryComboBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1009, 276, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(512, 745);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(12, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(42, 38);
            this.searchButton.StyleController = this.layoutControl1;
            this.searchButton.TabIndex = 12;
            // 
            // tokenEdit1
            // 
            this.tokenEdit1.Location = new System.Drawing.Point(126, 54);
            this.tokenEdit1.Name = "tokenEdit1";
            this.tokenEdit1.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenEdit1.Size = new System.Drawing.Size(279, 22);
            this.tokenEdit1.StyleController = this.layoutControl1;
            this.tokenEdit1.TabIndex = 11;
            // 
            // showFilesButton
            // 
            this.showFilesButton.Location = new System.Drawing.Point(409, 72);
            this.showFilesButton.Name = "showFilesButton";
            this.showFilesButton.Size = new System.Drawing.Size(91, 23);
            this.showFilesButton.StyleController = this.layoutControl1;
            this.showFilesButton.TabIndex = 6;
            this.showFilesButton.Text = "Show Files";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem5,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(512, 745);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.directoryComboBox;
            this.layoutControlItem1.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem1.Image")));
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(397, 36);
            this.layoutControlItem1.Text = "Directory";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(111, 32);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.filesGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(492, 611);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.showFilesButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(397, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(95, 27);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tokenEdit1;
            this.layoutControlItem4.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlItem4.Image")));
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(397, 36);
            this.layoutControlItem4.Text = "Filter Pattern";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(111, 32);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(397, 42);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(95, 18);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(397, 87);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(95, 27);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.searchButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(46, 42);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(46, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(446, 42);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FilesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "FilesUserControl";
            this.Size = new System.Drawing.Size(512, 745);
            ((System.ComponentModel.ISupportInitialize)(this.filesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl filesGridControl;
        private System.Windows.Forms.ComboBox directoryComboBox;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraGrid.Views.Grid.GridView filesGridView;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TokenEdit tokenEdit1;
        private DevExpress.XtraEditors.SimpleButton showFilesButton;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
