using System.Net;
using Newtonsoft.Json;

namespace OMDB_API_Lab.Models
{
    public class MovieDAL
    {
        public static MovieModel GetMovie(string title) //Adjust
        {
            //adjust
            //setup
            string url = $"http://www.omdbapi.com/?apikey=82e93224&t={title}";
            //NEED TO HIDE API KEY
            //use .gitignore and add class to be hidden

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust
            //Convert to c#
            //Install Newtonsoft.json
            MovieModel result = JsonConvert.DeserializeObject<MovieModel>(JSON);
            return result;
        }
    }
}
