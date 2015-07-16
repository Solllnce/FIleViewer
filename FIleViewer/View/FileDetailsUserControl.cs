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

namespace FIleViewer.View {
    public partial class FileDetailsUserControl : DevExpress.XtraEditors.XtraUserControl {
        public FileDetailsUserControl() {
            InitializeComponent();
            mvvmContext1.ViewModelType = typeof(FileDetailsViewModel);
            var fluentApi = mvvmContext1.OfType<FileDetailsViewModel>();
            fluentApi.SetBinding(bindingSource1, b => b.DataSource, f => f.FileDetails);
        }
    }
}
