using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace FIleViewer.ViewModel {
    public class FileDetailsViewModel {
        public FileDetailsViewModel(){
             RegisterFileMessenger();
             FileDetails = new FileInfo();
        }
        public virtual FileInfo FileDetails { get; set; }
        public void RegisterFileMessenger() {
            Messenger.Default.Register<string>(this, "details", OnFileMessage);
        }
        void OnFileMessage(string filePath) {
            if (File.Exists(filePath)) {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);
                FileDetails = new FileInfo() { DateModified = fileInfo.LastWriteTime, Size = fileInfo.Length.ToString() };
            }
        }
    }

    public class FileInfo {
        public DateTime DateModified { get; set; }
        public string Size { get; set; }
    }
}
