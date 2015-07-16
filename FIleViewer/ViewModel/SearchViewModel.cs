using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace FIleViewer.ViewModel {
    public class SearchViewModel {
        public SearchViewModel() {
            
        }
        public virtual string SearchString { get; set; }
        protected void OnSearchStringChanged() {
            Messenger.Default.Send<SearchMessage>(new SearchMessage() { Type = SearchMessage.SearchMessageType.Search, SearchString = this.SearchString });
        }
        public void GoNext() {
            Messenger.Default.Send<SearchMessage>(new SearchMessage() { Type = SearchMessage.SearchMessageType.Next });
        }
        public void GoPrev() {
            Messenger.Default.Send<SearchMessage>(new SearchMessage() { Type = SearchMessage.SearchMessageType.Prev });
        }
        public void StopSearch() {
            Messenger.Default.Send<SearchMessage>(new SearchMessage() { Type = SearchMessage.SearchMessageType.Stop });
        }
    }

    public class SearchMessage {
        public enum SearchMessageType {
            Search, 
            Next, 
            Prev, 
            Stop
        }
        public SearchMessageType Type { get; set; }
        public string SearchString { get; set; }
    }
}
