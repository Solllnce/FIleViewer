using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using FIleViewer.Service;
using FIleViewer.ViewModel;

namespace FIleViewer {

    public class FilesViewModel {
        public FilesViewModel() {
            FilterPatterns = new BindingList<string>(new string[] { "cs", "vb" });
            RegisterSearchMessenger();
        }
        public virtual BindingList<string> Files { get; set; }
        public virtual BindingList<string> FilterPatterns { get; set; }
        public virtual string CurrentFilterPattern { get; set; }
        public virtual string CurrentDirectory { get; set; }
        public virtual string FocusedFilePath { get; set; }
        public virtual string SelectedFilePath { get; set; }
        public virtual string SearchString { get; set; }

        public virtual ISearchService Service {
            get { throw new NotImplementedException(); }
        }
        public virtual IDialogService DialogService
        {
            get { throw new NotImplementedException(); }
        }
        public void RegisterSearchMessenger() {
            Messenger.Default.Register<SearchMessage>(this, OnSearchMessage);
        }
        protected void OnSearchMessage(SearchMessage message) {
            int index = -1;
            switch (message.Type) {
                case SearchMessage.SearchMessageType.Search:
                    SearchString = message.SearchString;
                    FocusedFilePath = Files.FirstOrDefault(s => s.Contains(SearchString));
                    break;
                case SearchMessage.SearchMessageType.Next:
                    index = Files.IndexOf(FocusedFilePath);
                    string nextFile = Files.Where(s => s.Contains(SearchString) && Files.IndexOf(s) > index).FirstOrDefault();
                    if (nextFile != null)
                        FocusedFilePath = nextFile;
                    break;
                case SearchMessage.SearchMessageType.Prev:
                    List<string> reverseList = Files.Reverse().ToList();
                    index = reverseList.IndexOf(FocusedFilePath);
                    string prevFile = Files.Reverse().Where(s => s.Contains(SearchString) && reverseList.IndexOf(s) > index).FirstOrDefault();
                    if (prevFile != null)
                        FocusedFilePath = prevFile;
                    break;
                case SearchMessage.SearchMessageType.Stop:
                    StopSearch();
                    break;
            }
        }
        public void Load() {
            if (string.IsNullOrEmpty(CurrentFilterPattern))
                Files = new BindingList<string>(Directory.GetFiles(CurrentDirectory));
            else
                Filter();

        }
        public bool CanLoad() {
            return Directory.Exists(CurrentDirectory);
        }
        public void Search(object owner) {
            //Service.StartSearch(owner);
            DialogService.ShowDialog(MessageButton.OK, "Search Window", "Search", this);
            StopSearch();
        }
        protected bool CanSearch(object owner) {
            return Files != null && owner != null && CanLoad();
        }
        public void StopSearch() {
            SearchString = string.Empty;
            //Service.StopSearch();
        }
        public void Filter() {
            var filteredList = Directory.GetFiles(CurrentDirectory).Where(f => CurrentFilterPattern.Contains(Path.GetExtension(f).TrimStart('.')));
            if (filteredList != null)
                Files = new BindingList<string>(filteredList.ToList());
            else
                Files = new BindingList<string>();
        }
        protected void OnCurrentDirectoryChanged() {
            this.RaiseCanExecuteChanged(f => f.Load());
        }
        protected void OnFilesChanged() {
            this.RaiseCanExecuteChanged(f => f.Search(null));
        }
        protected void OnFocusedFilePathChanged() {
            SendFileMessage(FocusedFilePath, "details");
        }
        protected void OnSelectedFilePathChanged() {
            SendFileMessage(SelectedFilePath, "content");
        }
        public void SendFileMessage(string filePath, string token) {
            Messenger.Default.Send<string>(filePath, token);
        }
    }
}
