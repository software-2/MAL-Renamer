using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    static class Jikan
    {
        private static readonly RestClient client = new RestClient("https://api.jikan.moe/v3/");

        public class Episode
        {
            [JsonProperty(PropertyName = "episode_id")]
            public int ID { get; set; }

            [JsonProperty(PropertyName = "title")]
            public string Title { get; set; }

            [JsonProperty(PropertyName = "title_japanese")]
            public string TitleJP { get; set; }

            [JsonProperty(PropertyName = "title_romanji")]
            public string TitleRO { get; set; }
            
        }

        private class EpisodesList
        {
            [JsonProperty(PropertyName = "episodes")]
            public List<Episode> Episodes { get; set; }

        }

        public class Picture
        {
            [JsonProperty(PropertyName = "large")]
            public string Large { get; set; }

            [JsonProperty(PropertyName = "small")]
            public string Small { get; set; }
        }

        private class PicturesList
        {
            [JsonProperty(PropertyName = "pictures")]
            public List<Picture> Pictures { get; set; }
        }

        static public List<Episode> GetEpisodes(string animeId)
        {
            var request = new RestRequest("anime/" + animeId + "/episodes", Method.GET);
            var response = client.Execute(request);
            var episodes = JsonConvert.DeserializeObject<EpisodesList>(response.Content).Episodes;

            return episodes;
        }

        static public List<Picture> GetPictures(string animeId)
        {
            var request = new RestRequest("anime/" + animeId + "/pictures", Method.GET);
            var response = client.Execute(request);
            var pictures = JsonConvert.DeserializeObject<PicturesList>(response.Content).Pictures;

            return pictures;
        }
    }
}
