using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIleViewer.Service {
    public interface ISearchService {
        void StartSearch(object owner);
        void StopSearch();
    }
}
