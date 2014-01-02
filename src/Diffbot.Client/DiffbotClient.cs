// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiffbotClient.cs" company="KriaSoft LLC">
//   Copyright © 2014 Konstantin Tarkus, KriaSoft LLC.  See LICENSE.txt
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Diffbot.Client
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    public class DiffbotClient : IDisposable
    {
        private const string ArticleServiceUri = "http://api.diffbot.com/v2/article";

        private readonly HttpClient httpClient;

        private readonly string token;

        public DiffbotClient(string token, int timeout = 0)
        {
            this.token = token;
            this.httpClient = new HttpClient();
        }

        public async Task<Article> GetArticle(string url)
        {
            var uri = ArticleServiceUri +
                "?token=" + Uri.EscapeDataString(this.token) +
                "&url=" + Uri.EscapeDataString(url);

            // TODO: Add exception handling
            var json = await this.httpClient.GetStringAsync(uri);
            var article = await JsonConvert.DeserializeObjectAsync<Article>(json);

            return article;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && this.httpClient != null)
            {
                this.httpClient.Dispose();
            }
        }
    }
}
