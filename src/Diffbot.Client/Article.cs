// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Article.cs" company="KriaSoft LLC">
//   Copyright © 2014 Konstantin Tarkus, KriaSoft LLC. See LICENSE.txt
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Diffbot.Client
{
    // TODO: Add all the required fields and JSON mapping attributes
    public class Article
    {
        public string Url { get; set; }

        public string ResolvedUrl { get; set; }

        public string Icon { get; set; }

        public string Title { get; set; }

        public string BodyText { get; set; }

        public string BodyHtml { get; set; }
    }
}
