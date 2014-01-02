// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiffbotClientTest.cs" company="KriaSoft LLC">
//   Copyright © 2014 Konstantin Tarkus, KriaSoft LLC.  See LICENSE.txt
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Diffbot.Client.Tests
{
    using System.Net.Http;
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DiffbotClientTest
    {
        private const string ValidApiKey = "<your api key>";

        private const string InvalidApiKey = "b2571e7c9108ac25ef31cdd30ef83194";

        private const string WebPageUrl1 =
            "http://gigaom.com/cloud/silicon-valley-royalty-pony-up-2m-to-scale-diffbots-visual-learning-robot/";

        [TestMethod, TestCategory("Integration")]
        public async Task DiffbotClient_GetArticle_Should_Return_an_Article()
        {
            // Arrange
            var client = new DiffbotClient(ValidApiKey);

            // Act
            var article = await client.GetArticle(WebPageUrl1);

            // Assert
            Assert.IsNotNull(article);
            Assert.AreEqual("Silicon Valley stars pony up $2M to scale Diffbot’s visual learning robot", article.Title);
        }

        [TestMethod, TestCategory("Integration"), ExpectedException(typeof(HttpRequestException))]
        public async Task DiffbotClient_GetArticle_Should_Throw_an_Exception()
        {
            // Arrange
            var client = new DiffbotClient(InvalidApiKey);

            // Act
            await client.GetArticle(WebPageUrl1);
        }
    }
}
