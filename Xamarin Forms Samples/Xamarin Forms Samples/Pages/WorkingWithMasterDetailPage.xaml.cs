using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Forms_Samples.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkingWithMasterDetailPage : MasterDetailPage
    {
        public WorkingWithMasterDetailPage()
        {
            InitializeComponent();
        }
    }
}