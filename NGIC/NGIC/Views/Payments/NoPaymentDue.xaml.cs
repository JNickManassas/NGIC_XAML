using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NGIC.Views.Payments
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoPaymentDue : ContentPage
    {
        public NoPaymentDue()
        {
            InitializeComponent();
        }
    }
}