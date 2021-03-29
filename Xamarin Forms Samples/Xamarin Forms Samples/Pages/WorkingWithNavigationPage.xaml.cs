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
    public partial class WorkingWithNavigationPage : ContentPage
    {
        public WorkingWithNavigationPage()
        {
            InitializeComponent();
            btnPush.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new WorkingWithNavigationPage());
            };

            btnPop.Clicked += (sender, e) =>
            {
                Navigation.PopAsync();
            };

            btnPushModal.Clicked += (sender, e) =>
            {
                Navigation.PushModalAsync(new WorkingWithNavigationPage());
            };

            btnPopModal.Clicked += (sender, e) =>
            {
                Navigation.PopModalAsync();
            };
        }
    }
}