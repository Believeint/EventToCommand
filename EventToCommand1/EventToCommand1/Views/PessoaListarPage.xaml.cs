using EventToCommand1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventToCommand1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PessoaListarPage : ContentPage
    {
        public PessoaListarPage()
        {
            InitializeComponent();
            BindingContext = new PessoaListarViewModel();
        }
    }
}