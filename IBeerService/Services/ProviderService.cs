using IBeerCore.Entities;
using IBeerData.Repository;
using IBeerService.POCO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace IBeerService.Services
{
    public class ProviderService
    {
        public async Task<DrinkProvider> GetProviderDrinkAsync(string api, Int64 barCode)
        {
            DrinkProvider drinkProvider = new DrinkProvider();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(api + "/" + barCode);
                var response = await client.GetAsync("");
                string drink = await response.Content.ReadAsStringAsync();
                
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
