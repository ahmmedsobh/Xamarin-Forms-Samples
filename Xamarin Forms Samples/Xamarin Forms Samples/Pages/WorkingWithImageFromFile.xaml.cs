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
    public partial class WorkingWithImageFromFile : CarouselPage
    {
        public WorkingWithImageFromFile()
        {
            InitializeComponent();
            Car1.Source = ImageSource.FromFile("Car1.png");
            Car2.Source = ImageSource.FromFile("Car2.png");
            Car3.Source = ImageSource.FromFile("Car3.png");
            Car4.Source = ImageSource.FromFile("Car4.png");
        }
    }
}