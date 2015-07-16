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
using FIleViewer.ViewModel;
using FIleViewer.Service;

namespace FIleViewer.View {
    public partial class SearchControl : DevExpress.XtraEditors.XtraUserControl {
        public SearchControl() {
            InitializeComponent();
            mvvmContext1.ViewModelType = typeof(SearchViewModel);
            var fluentApi = mvvmContext1.OfType<SearchViewModel>();
            fluentApi.SetBinding(searchTextEdit, t => t.Text, s => s.SearchString);
            fluentApi.BindCommand(prevButton, s => s.GoPrev());
            fluentApi.BindCommand(nextButton, s => s.GoNext());
            fluentApi.BindCommand(closeButton, s => s.StopSearch());
        }
    }
}
