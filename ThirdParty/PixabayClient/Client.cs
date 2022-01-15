using PixabayClient.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PixabayClient
{
    public class Client
    {
        private string key = "25142007-564b281953c9a63889dec4e64";
        public async Task GetImages()
        {
            string jsonResult = String.Empty;
            string query = "calm+morning&image_type=photo&category=nature&pretty=true&per_page=50";
            using (HttpClient client = new HttpClient())
            {
                UriBuilder builder = new UriBuilder("https://pixabay.com/api/");
                builder.Query = String.Format("key={0}&q={1}", key, query);
                HttpResponseMessage response = await client.GetAsync(builder.Uri);
                if (response.IsSuccessStatusCode)
                {
                    jsonResult = await response.Content.ReadAsStringAsync();
                }
            };
            var options = new JsonSerializerOptions
            {
             PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            ImageResponse images = JsonSerializer.Deserialize<ImageResponse>(jsonResult,options);
            DownloadImages(images?.Hits);

        }
        private void DownloadImages(List<ImageInfo> images)
        {
            var directory = Directory.CreateDirectory(String.Format("{0}{1}",
                @"E:\Projects\automatic-youtube_upload-service\Files\Images\", DateTime.Today.ToString("dd/MM/yyyy")));
            foreach (ImageInfo image in images)
            {
                using (WebClient client = new WebClient())
                { 
                    string imageType = image.LargeImageURL.Substring(image.LargeImageURL.LastIndexOf('.'));
                    client.DownloadFile(image.LargeImageURL, String.Format("{0}\\{1}.{2}", directory.FullName ,image.Id, imageType));
                }
            }
        }
    }
}
