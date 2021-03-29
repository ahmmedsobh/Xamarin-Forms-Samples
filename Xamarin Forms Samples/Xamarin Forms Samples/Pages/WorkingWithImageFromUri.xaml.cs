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
    public partial class WorkingWithImageFromUri : CarouselPage
    {
        public WorkingWithImageFromUri()
        {
            InitializeComponent();
            Car1.Source = ImageSource.FromUri(new Uri("https://i.pinimg.com/originals/07/85/2f/07852f228cc629c0bb6c3625e7c98d6f.png"));
            Car2.Source = ImageSource.FromUri(new Uri("https://e7.pngegg.com/pngimages/813/228/png-clipart-cars-2-lightning-mcqueen-pixar-car-blue-car.png"));
            Car3.Source = ImageSource.FromUri(new Uri("https://e7.pngegg.com/pngimages/492/871/png-clipart-cars-mater-national-championship-lightning-mcqueen-cars-3-driven-to-win-cars-vintage-car-car.png"));
            Car4.Source = ImageSource.FromUri(new Uri("https://e7.pngegg.com/pngimages/489/894/png-clipart-mater-lightning-mcqueen-sally-carrera-cars-cars-compact-car-vintage-car.png"));
        }
    }
}