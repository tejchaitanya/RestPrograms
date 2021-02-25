using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestPrograms
{
   public class RestSetUp
    {
        public ListUsersDto GetUsers()
        {
            var restClient = new RestClient("https://reqres.in/");
            var restRequest = new RestRequest("/api/users?page=2",Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;
            var users = JsonConvert.DeserializeObject<ListUsersDto>(content);
            return users;

        }
    }
}
