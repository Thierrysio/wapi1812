using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace wapi1812.Modeles
{
    class Clients
    {
        #region Attributs
        public static ArrayList CollClasseClient = new ArrayList();
        private int _id;
        private string _nom;
        private string _ville;
        #endregion
        #region Constructeurs
        public Clients(int id, string nom, string ville)
        {
            this._id = id;
            this._nom = nom;
            this._ville = ville;
            Clients.CollClasseClient.Add(this);
        }
        #endregion
        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Ville { get => _ville; set => _ville = value; }
        #endregion
        #region Methodes
        public static ObservableCollection<Clients> Recup()
        {
            ObservableCollection<Clients> resultat = new ObservableCollection<Clients>();

            foreach (Clients leClient in Clients.CollClasseClient)
            {
                resultat.Add(leClient);
            }

            return resultat;
        }
        #endregion
    }
}
