using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TestExample
{
    public class BookService : IBookService
    {
        public List<BookIngDetail> GetAllBooking()
        {
            string data = "";
            using (HttpClient client = new HttpClient())
            {
                //parametrai (PARAMS of your call)
                //var parameters = new Dictionary<string, string> { { "username", "YOURUSERNAME" }, { "password", "YOURPASSWORD" } };
                //Uzkoduojama URL'ui 
                //var encodedContent = new FormUrlEncodedContent(parameters);
                try
                {
                    //Post http callas.
                    HttpResponseMessage response = client.GetAsync("https://localhost:44337/Booking").Result;
                    //nesekmes atveju error..
                    response.EnsureSuccessStatusCode();
                    //responsas to string
                    string responseBody = response.Content.ReadAsStringAsync().Result;

                    data = responseBody;
                    var model = JsonConvert.DeserializeObject<List<BookIngDetail>>(data);
                    return model;


                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }


            }
            return null;
        }

    }
}
