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
    public partial class WorkingWithPicker : ContentPage
    {
        public WorkingWithPicker()
        {
            InitializeComponent();
            btnAdd.Clicked += (sender, e) =>
            {
                MyPicker.Items.Add(txtItem.Text);
                txtItem.Text = "";
                txtItem.Focus();
            };
        }
    }
}