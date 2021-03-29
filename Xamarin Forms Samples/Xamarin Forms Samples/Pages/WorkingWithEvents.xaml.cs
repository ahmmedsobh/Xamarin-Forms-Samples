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
    public partial class WorkingWithEvents : ContentPage
    {
        public WorkingWithEvents()
        {
            InitializeComponent();
        }

        public void DisplayMessage(object sender , EventArgs e)
        {
            lblMessage.Text = $"Hi MR. {txtName.Text}";
            lblMessage.TextColor = Color.White;
            lblMessage.BackgroundColor = Color.Red;
        }
       
    }
}