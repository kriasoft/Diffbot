// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiffbotClientTest.cs" company="KriaSoft LLC">
//   Copyright © 2014 Konstantin Tarkus, KriaSoft LLC.  See LICENSE.txt
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Diffbot.Client.Tests
{
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DiffbotClientTest
    {
        private const string ValidApiKey = "<your api key>";

        private const string InvalidApiKey = "b2571e7c9108ac25ef31cdd30ef83194";

        [TestMethod, TestCategory("Integration")]
        public async Task DiffbotClient_GetArticle_Should_Return_an_Article()
        {
            // Arrange
            var client = new DiffbotClient(ValidApiKey);

            // Act
            var article = await client.GetArticle(
                "http://gigaom.com/cloud/silicon-valley-royalty-pony-up-2m-to-scale-diffbots-visual-learning-robot/");

            // Assert
            Assert.IsNotNull(article);
            Assert.AreEqual("Silicon Valley stars pony up $2M to scale Diffbot’s visual learning robot", article.Title);
        }
    }
}
