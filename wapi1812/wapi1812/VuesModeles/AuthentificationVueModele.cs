using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wapi1812.Services;
using wapi1812.Vues;
using Xamarin.Forms;

namespace wapi1812.VuesModeles
{
    class AuthentificationVueModele : INotifyPropertyChanged
    {
        #region Attributs

        private readonly ApiAuthentification _apiServices = new ApiAuthentification();
        private readonly ApiClient _apiServicesClients = new ApiClient();

        private string _identifiant;
        private string _motDePasse;
        private string _imgAuth = "https://st.depositphotos.com/1695366/1400/v/950/depositphotos_14001488-stock-illustration-cartoon-impatient-man-waiting.jpg";
        private bool auth = false;
        #endregion

        #region Constructeurs
        public AuthentificationVueModele()
        {

            CommandeButtonLogIn = new Command(ActionPage);
            CommandeButtonListing = new Command(ActionListingPage);
        }
        #endregion

        #region Getters/Setters
        public ICommand CommandeButtonLogIn { get; }
        public ICommand CommandeButtonListing { get; }
        public string Identifiant
        {
            get
            {
                return _identifiant;
            }
            set
            {
                if (_identifiant != value)
                {
                    _identifiant = value;
                    OnPropertyChanged(nameof(Identifiant));
                }
            }
        }
        public string MotDePasse
        {
            get
            {
                return _motDePasse;
            }
            set
            {
                if (_motDePasse != value)
                {
                    _motDePasse = value;
                    OnPropertyChanged(nameof(MotDePasse));
                }
            }
        }
        public string ImgAuth
        {
            get
            {
                return _imgAuth;
            }
            set
            {
                _imgAuth = value;
                OnPropertyChanged(nameof(ImgAuth));
                
            }
        }
        #endregion

        #region Methodes

        public void ActionPage()
        {

            Task.Run(async () =>
            {
             if(await _apiServicesClients.GetAuthAsync("thierry", "lannion"))
                {
                    ImgAuth = "https://www.aslbadminton.fr/wp-content/uploads/2016/11/Ok-257x300.png";
                    auth = true;
                }
                else 
                {
                    ImgAuth = "http://dd03.blogs.apf.asso.fr/media/02/01/2130280108.jpg";
                    auth = false;
                }

            });

            
        }
        public void ActionListingPage()
        {
           if (auth) Application.Current.MainPage = new NavigationPage(new ListingPage());
        }
        #endregion
            #region notifications
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
