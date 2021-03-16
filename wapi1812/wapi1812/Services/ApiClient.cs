using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using wapi1812.Modeles;
using Xamarin.Essentials;

namespace wapi1812.Services
{
    class ApiClient
    {
        #region Methodes
        public async Task<ObservableCollection<Banque>> GetBanqueAsync()
        {
            string letoken;
            try
            {
                /*letoken = await SecureStorage.GetAsync("token");
                var clientHttp = new HttpClient();
                clientHttp.DefaultRequestHeaders.Authorization = 
                    new AuthenticationHeaderValue("Bearer", letoken);
                var json = await clientHttp.GetStringAsync(Constantes.BaseApiAddress + "api/banque");

                */
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(ApiClient)).Assembly;
                Stream stream = assembly.GetManifestResourceStream("wapi1812.json.banque");
                string text = "";
                using (var reader = new System.IO.StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                }
                JsonConvert.DeserializeObject<List<Banque>>(text);


            }
            catch (Exception ex)
            {
                // Possible that device doesn't support secure storage on device.
            }

            return Banque.Recup();

        }

        public async Task<bool> GetAuthAsync(string nom, string ville)
        {

            Clients modelData = new Clients(0,nom, ville);
            var jsonstring = JsonConvert.SerializeObject(modelData);
            try
            {
                var client = new HttpClient();

                var jsonContent = new StringContent(jsonstring, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(Constantes.BaseApiAddress + "api/login_check", jsonContent);
                var content = await response.Content.ReadAsStringAsync();
                
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
        #endregion
    }
}
