using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wapi1812.Modeles;
using wapi1812.Services;
using Xamarin.Forms;

namespace wapi1812.VuesModeles
{
    class ListingVueModele : INotifyPropertyChanged
    {
        #region attributs
        private readonly ApiClient _apiServices = new ApiClient();
        private ObservableCollection<Banque> maListebanque;


        #endregion
        #region constructeurs
        public ListingVueModele()
        {
            
            Task.Run(async () =>
            {
                MaListeBanque = await _apiServices.GetBanqueAsync();

            });
        }
        #endregion
        #region getters/setters
        private Clients selectedClient;
        public Clients SelectedClient
        {
            get
            {
                return selectedClient;
            }
            set
            {
                if (selectedClient != value)
                {
                    selectedClient = value;
                    this.ActionItemSelected();
                }
            }
        }
       
        public ObservableCollection<Banque> MaListeBanque
        {
            get
            {

                return maListebanque;
            }

            set
            {
                maListebanque = value;
                OnPropertyChanged(nameof(MaListeBanque));
            }
        }
        #endregion
        #region methodes
        public void ActionPage()
        {
            
        }
        public void ActionItemSelected()
        {
            int id = selectedClient.Id;
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
