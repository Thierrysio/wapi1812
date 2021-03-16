using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace wapi1812.Modeles
{
    class Banque
    {
        #region Attributs
        public static ArrayList CollClasseBanque = new ArrayList();
        private string _laDate;
        private double _leMontant;
        private string _lettrage;
        private string _libelle;
        #endregion
        #region Constructeurs
        public Banque(string laDate, double leMontant, string lettrage, string libelle)
        {
            _laDate = laDate;
            _leMontant = leMontant;
            _lettrage = lettrage;
            _libelle = libelle;
            Banque.CollClasseBanque.Add(this);
        }
        #endregion
        #region Getters/Setters
        public string LaDate { get => _laDate; set => _laDate = value; }
        public double LeMontant { get => _leMontant; set => _leMontant = value; }
        public string Lettrage { get => _lettrage; set => _lettrage = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
        #endregion
        #region Methodes
        public static ObservableCollection<Banque> Recup()
        {
            ObservableCollection<Banque> resultat = new ObservableCollection<Banque>();

            foreach (Banque laBanque in Banque.CollClasseBanque)
            {
                resultat.Add(laBanque);
            }

            return resultat;
        }
        #endregion

    }
}
