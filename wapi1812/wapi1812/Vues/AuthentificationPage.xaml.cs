using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wapi1812.VuesModeles;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wapi1812.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthentificationPage : ContentPage
    {
        public AuthentificationPage()
        {
            InitializeComponent();
            BindingContext = new AuthentificationVueModele();
        }
    }
}