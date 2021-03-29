using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_Forms_Samples.Pages;

namespace Xamarin_Forms_Samples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CreateLoginFormWithStackLayout.Clicked += (sender, e) => { Navigation.PushAsync(new CreateLoginFormWithStackLayout());};
            WorkingWithAbsoluteLayout.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithAbsoluteLayout());};
            WorkingWithCarouselPage.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithCarouselPage());};
            WorkingWithEvents.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithEvents());};
            WorkingWithFrame.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithFrame());};
            WorkingWithGrid.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithGrid());};
            WorkingWithImageFromFile.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithImageFromFile());};
            WorkingWithImageFromResource.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithImageFromResource());};
            WorkingWithImageFromUri.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithImageFromUri());};
            WorkingWithLayoutOptions.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithLayoutOptions());};
            WorkingWithMasterDetailPage.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithMasterDetailPage());};
            WorkingWithNavigationPage.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithNavigationPage());};
            WorkingWithPicker.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithPicker());};
            WorkingWithRelativeLayout.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithRelativeLayout());};
            WorkingWithScrollView.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithScrollView());};
            WorkingWithSwitch.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithSwitch());};
            WorkingWithTabbedPage.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithTabbedPage());};
            WorkingWithXamal.Clicked += (sender, e) => { Navigation.PushAsync(new WorkingWithXamal());};
        }
    }
}
