using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace wapi1812.Modeles
{
    class User
    {
        #region Attributs
        public static ArrayList CollClasseUser = new ArrayList();

        private string _identifant;
        private string _motDePasse;


        #endregion
        #region Constructeurs
        public User(string identifant, string motDePasse)
        {
            username = identifant;
            password = motDePasse;

            User.CollClasseUser.Add(this);
        }

        #endregion
        #region Getters/Setters
        public string username { get => _identifant; set => _identifant = value; }
        public string password { get => _motDePasse; set => _motDePasse = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
