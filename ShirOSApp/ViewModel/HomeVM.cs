using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirOSApp.ViewModel
{
    using Common;

    public class HomeVM : BaseVM
    {
        protected ListProductVM listProductVM = null;

        public HomeVM()
        {
            this.listProductVM = new ListProductVM();
        }

        public ListProductVM ListProductVM
        {
            get { return listProductVM; }
            set { listProductVM = value; }
        }
    }
}
