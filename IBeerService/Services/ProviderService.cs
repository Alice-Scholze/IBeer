using IBeerCore.Entities;
using IBeerData.Repository;
using IBeerService.POCO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace IBeerService.Services
{
    public class ProviderService
    {
        public DrinkProvider GetProviderDrinkAsync(string api, Int64 barCode)
        {
            DrinkProvider drinkProvider = new DrinkProvider();
            string drink = "";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(api + "/" + barCode);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(api + "/" + barCode).Result;
                if (response.IsSuccessStatusCode)
                {
                    drink = response.Content.ReadAsStringAsync().Result;
                }
                drinkProvider = new JavaScriptSerializer().Deserialize<DrinkProvider>(drink);
            }
            return drinkProvider;
        }
        public List<Provider> GetAll()
        {
            return new ProviderRepository().GetAll();
        }
    }
}
