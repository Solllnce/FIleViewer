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
    public partial class FileContentUserControl : DevExpress.XtraEditors.XtraUserControl {
        public FileContentUserControl() {
            InitializeComponent();
            mvvmContext1.ViewModelType = typeof(FileContentViewModel);
            var fluentApi = mvvmContext1.OfType<FileContentViewModel>();
            fluentApi.SetBinding(fileContentMemoEdit, r => r.Text, f => f.FileText);
        }
    }
}
