using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.Utils.MVVM;
using FIleViewer.Service;

namespace FIleViewer {
    public partial class FilesUserControl : DevExpress.XtraEditors.XtraUserControl {
        public FilesUserControl() {
            InitializeComponent();
            mvvmContext1.ViewModelType = typeof(FilesViewModel);
            var fluentApi = mvvmContext1.OfType<FilesViewModel>();
            fluentApi.BindCommand(showFilesButton, f => f.Load());
            fluentApi.SetBinding(directoryComboBox, c => c.Text, f => f.CurrentDirectory);
            fluentApi.SetBinding(filesGridControl, g => filesGridControl.DataSource, f => f.Files);
            fluentApi.WithEvent<GridControl, EventArgs>(filesGridControl, "DoubleClick").SetBinding<string>(f => f.SelectedFilePath, args => filesGridView.GetFocusedDisplayText(), (grid, str) => (grid.MainView as GridView).FocusedRowHandle = (grid.MainView as GridView).FindRow(str));
            fluentApi.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(filesGridView, "FocusedRowObjectChanged").SetBinding<string>(f => f.FocusedFilePath, args => args.Row == null ? null : args.Row.ToString(), (view, str) => view.FocusedRowHandle = view.FindRow(str));
            mvvmContext1.RegisterService(new FileSearchService());
            fluentApi.BindCommand<FilesUserControl>(searchButton, (f, us) => f.Search(us), p => this) ;
            tokenEdit1.Properties.Tokens.AddRange(mvvmContext1.GetViewModel<FilesViewModel>().FilterPatterns.Select<string, TokenEditToken>(f => new TokenEditToken(f)).ToList());
            fluentApi.SetBinding(tokenEdit1, fi => fi.EditValue, f => f.CurrentFilterPattern);
            fluentApi.SetBinding(filesGridView, g => g.FindFilterText, f => f.SearchString);
        }
    }
}
