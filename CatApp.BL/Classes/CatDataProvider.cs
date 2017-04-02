using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CatApp.BL.Interfaces;
using CatApp.Models;
using CatApp.Models.DTO;
using Newtonsoft.Json;

namespace CatApp.BL.Classes
{
    public class CatDataProvider : ICatDataProvider
    {
        public async Task<List<CatDataModel>> GetCatData()
        {
            string rawDataFacts;
            string rawDataImages;
            using (var client = new HttpClient())
            {
                rawDataFacts =
                    await (await client.GetAsync("http://catfacts-api.appspot.com/api/facts?number=20")).Content
                    .ReadAsStringAsync();
                rawDataImages =
                    await (await client.GetAsync("http://thecatapi.com/api/images/get?format=xml&results_per_page=20")).Content
                    .ReadAsStringAsync();
            }

            var output = new List<CatDataModel>();

            var facts = JsonConvert.DeserializeObject<CatFactsDTO>(rawDataFacts);
            var images = new List<string>();

            var doc = XDocument.Parse(rawDataImages);
            foreach (var node in doc.Element("response").Element("data").Element("images").Elements("image"))
            {
                images.Add(node.Element("url").Value);
            }

            for (int i = 0; i < 20; i++)
            {
                output.Add(new CatDataModel
                {
                    Fact = facts.facts[i],
                    ImgUrl = images[i],
                });
            }

            return output;
        }
    }
}
