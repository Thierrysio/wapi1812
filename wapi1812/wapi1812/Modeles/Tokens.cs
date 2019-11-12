using System;
using System.Collections.Generic;
using System.Text;

namespace wapi1812.Modeles
{
    class Tokens
    {

        private string _token;

        public Tokens(string token)
        {
            Token = token;
        }

        public string Token { get => _token; set => _token = value; }
    }
}
