using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace FIleViewer.ViewModel {
    public class FileContentViewModel {
        public FileContentViewModel() {
            RegisterFileMessenger();
        }
        public virtual string FileText { get; set; }
        public void RegisterFileMessenger() {
            Messenger.Default.Register<string>(this, "content", OnFileMessage);
        }
        void OnFileMessage(string filePath) {
            try {
                FileText = File.ReadAllText(filePath);
            }
            catch { }
        }
    }
}
