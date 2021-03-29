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
    public partial class WorkingWithSwitch : ContentPage
    {
        public WorkingWithSwitch()
        {
            InitializeComponent();
            MySwitch.Toggled += (sender, e) =>
            {
                if (e.Value)
                    BackgroundColor = Color.LightYellow;
                else
                    BackgroundColor = Color.Black;
            };
        }
    }
}