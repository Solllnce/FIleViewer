using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.MVVM;
using FIleViewer.View;

namespace FIleViewer.Service {
    public class FileSearchService: ISearchService {
        FlyoutPanel flyout;
        public void StartSearch(object owner) {
            flyout = new FlyoutPanel();
            flyout.Hidden += flyout_Hidden;
            flyout.OwnerControl = owner as Control;
            flyout.Options.CloseOnOuterClick = false;
            flyout.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Manual;
            SearchControl ctrl = new SearchControl();
            flyout.ClientSize = ctrl.Size;
            flyout.Options.Location = new System.Drawing.Point(flyout.OwnerControl.Location.X - flyout.Size.Width, flyout.OwnerControl.Location.Y);
            ctrl.Parent = flyout;
            ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            flyout.ShowPopup();
        }

        void flyout_Hidden(object sender, FlyoutPanelEventArgs e) {
            FlyoutPanel flyout = sender as FlyoutPanel;
            flyout.Hidden -= flyout_Hidden;
            flyout.OwnerControl = null;
            flyout.Dispose();
            this.flyout = null;
        }
        public void StopSearch() {
            if (flyout != null)
                flyout.HidePopup();
        }
    }
}
