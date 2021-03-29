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
    public partial class WorkingWithImageFromResource : CarouselPage
    {
        public WorkingWithImageFromResource()
        {
            InitializeComponent();
            Car1.Source = ImageSource.FromResource("Xamarin_Forms_Samples.images.Car1.png");
            Car2.Source = ImageSource.FromResource("Xamarin_Forms_Samples.images.Car2.png");
            Car3.Source = ImageSource.FromResource("Xamarin_Forms_Samples.images.Car3.png");
            Car4.Source = ImageSource.FromResource("Xamarin_Forms_Samples.images.Car4.png");
        }
    }
}